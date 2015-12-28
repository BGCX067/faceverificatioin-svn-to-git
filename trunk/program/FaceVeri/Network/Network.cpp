// Network.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Server.h"
int _tmain(int argc, _TCHAR* argv[])
{
	Server *server=new Server();
	server->init();
	server->run();
	return 0;
}