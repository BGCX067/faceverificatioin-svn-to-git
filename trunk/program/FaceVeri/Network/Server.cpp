#include "StdAfx.h"
#include "Server.h"


Server::Server(void)
{
}


Server::~Server(void)
{
}

void Server::init()
{
	WORD wVersionRequested;
	WSADATA wsaData;
	int err;
	wVersionRequested=MAKEWORD(1,1);
	err=WSAStartup(wVersionRequested,&wsaData);
	//若发生错误处理
	if(err!=0)
	{
		return;
	}
	//若获得的不符合实际情况的处理
	if(LOBYTE(wsaData.wVersion)!=1||HIBYTE(wsaData.wVersion)!=1)
	{
		WSACleanup();
		return;
	}
	//创建用于监听的套接字
	sockSrv=socket(AF_INET,SOCK_STREAM,0);
	SOCKADDR_IN addrSrv;
	addrSrv.sin_addr.S_un.S_addr=htonl(INADDR_ANY);
	addrSrv.sin_family=AF_INET;
	addrSrv.sin_port=htons(6000);
	//绑定套接字
	bind(sockSrv,(SOCKADDR*)&addrSrv,sizeof(SOCKADDR));
	//将套接字设为监听模式，准备接受客户的请求
	//开启一个新的线程进行客户信息的读取
	cout<<"Server created!!"<<endl;
}

void Server::run()
{
	while(1)
	{
		listen(sockSrv,5);//Listen to the server socket
		SOCKET* clientSocket=new SOCKET();// create a new empty client socket
		SOCKADDR_IN *addrClient=new SOCKADDR_IN();//create a new empty client address
		int len=sizeof(SOCKADDR);//get the length of the SOCKADDR
		(*clientSocket)=accept(sockSrv,(SOCKADDR*)addrClient,&len);//Accept and get the client socket and the addrss
		cout<<"New connection received!"<<endl;
		this->add(clientSocket,addrClient);
	}
}