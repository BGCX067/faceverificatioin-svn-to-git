#include "StdAfx.h"
#include "threadrun.h"
#include"CServerSocket.h"
DWORD WINAPI ListenThread(LPVOID lparam)
{
	CServerSocket* serverSoc=(CServerSocket*)lparam;
	serverSoc->run();
	return 0;
}
DWORD WINAPI ReceivefileThread(LPVOID lparam)
{
	CServerSocket* serverSoc=(CServerSocket*)lparam;
	serverSoc->receiveFile(_T("C:\\Documents and Settings\\Administrator\\×ÀÃæ\\sample3.jpg"));
	return 0;
}