#include<afxsock.h>
#include<Windows.h>
#include<fstream>
#include"threadrun.h"
#pragma once
using namespace std;
class CServerSocket
{
public:
	CSocket listensocket,socketReceive;
	CServerSocket(void);
	~CServerSocket(void);
	void init();
	void run();
	void receiveFile(CString cstr);
};

