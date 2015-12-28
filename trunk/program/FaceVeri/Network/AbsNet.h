#include<windows.h>
#include<vector>
#include<string>
#include <algorithm>
#include<iostream>
#pragma once
using namespace std;
extern DWORD WINAPI threadrun(LPVOID lparam);
class AbsNet;
class NetandSock
{
public:
	AbsNet * abs;
	SOCKET* sock;
	SOCKADDR_IN* sockaddr;
};
class AbsNet
{
public:
	AbsNet(void);
	~AbsNet(void);
	void add(SOCKET* socket,SOCKADDR_IN* addr);
};