#include "StdAfx.h"
#include "CServerSocket.h"


CServerSocket::CServerSocket(void)
{
	init();
}


CServerSocket::~CServerSocket(void)
{
}

void CServerSocket::init()
{
	if(!AfxSocketInit())
	{
		return;
	}
	listensocket.Create(6000,SOCK_STREAM);
}
void CServerSocket::run()
{	
	listensocket.Listen();
	listensocket.Accept(socketReceive);
	cout<<"connect received"<<endl;
}

void CServerSocket::receiveFile(CString cstr)
{	
	char data[1001];
	memset(data,0,1001);
	CFile cfile;
	cfile.Open((LPCTSTR)cstr,CFile::modeCreate|CFile::modeWrite);
	while(TRUE)
	{	
		int numofbyte=socketReceive.Receive(data,1000,0);
		if(numofbyte<=0)
		{
			socketReceive.Close();
			break;
		}
		else
		{
			cfile.Write(data,numofbyte);
		}
	}
}
