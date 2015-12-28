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
	//������������
	if(err!=0)
	{
		return;
	}
	//����õĲ�����ʵ������Ĵ���
	if(LOBYTE(wsaData.wVersion)!=1||HIBYTE(wsaData.wVersion)!=1)
	{
		WSACleanup();
		return;
	}
	//�������ڼ������׽���
	sockSrv=socket(AF_INET,SOCK_STREAM,0);
	SOCKADDR_IN addrSrv;
	addrSrv.sin_addr.S_un.S_addr=htonl(INADDR_ANY);
	addrSrv.sin_family=AF_INET;
	addrSrv.sin_port=htons(6000);
	//���׽���
	bind(sockSrv,(SOCKADDR*)&addrSrv,sizeof(SOCKADDR));
	//���׽�����Ϊ����ģʽ��׼�����ܿͻ�������
	//����һ���µ��߳̽��пͻ���Ϣ�Ķ�ȡ
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