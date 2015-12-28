#include<vector>
#include<iostream>
#include<string>
#include"AbsNet.h"
using namespace std;
#pragma once
class Server:AbsNet
{
private:
	SOCKET sockSrv;
public:
	Server(void);
	~Server(void);
	void init();
	void run();
};

