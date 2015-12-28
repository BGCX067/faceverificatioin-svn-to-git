#include<vector>
#include<string>
#include<algorithm>
#include<fstream>
#include<iostream>
#include<stdio.h>
#pragma once
using namespace std;
DWORD WINAPI ListenThread(LPVOID lparam);
DWORD WINAPI ReceivefileThread(LPVOID lparam);