#include<windows.h>
#include<vector>
#include<string>
#include <algorithm>
#include<iostream>
#pragma once
using namespace std;
extern DWORD WINAPI Threadrun(LPVOID lparam);
class Abstractnet;
class NetandSock
{
public:
	Abstractnet * abs;
	SOCKET* sock;
	SOCKADDR_IN* sockaddr;
};
class AbstractNet
{
public:
	AbstractNet(void);
	~AbstractNet(void);
	void add(SOCKET* socket,SOCKADDR_IN* addr);
};