#include "StdAfx.h"
#include "AbsNet.h"


AbsNet::AbsNet(void)
{
}


AbsNet::~AbsNet(void)
{
}

void AbsNet::add(SOCKET* socket,SOCKADDR_IN* addr)
{
	NetandSock * netandsock=new NetandSock();
	netandsock->abs=(AbsNet *)this;
	netandsock->sock=socket;
	netandsock->sockaddr=addr;
	HANDLE handle=CreateThread(0,0,threadrun,(LPVOID) netandsock,0,0);
}