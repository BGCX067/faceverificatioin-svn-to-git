#include "StdAfx.h"
#include "threadrun.h"
DWORD WINAPI threadrun(LPVOID lparam)
{
	ofstream out;
	out.open("C:\\Documents and Settings\\Administrator\\×ÀÃæ\\sample4.jpg");
	bool cancontinue=true;
	NetandSock* netandsock=(NetandSock*) lparam;
	double totalbytes=0;
	char data[1024];	
	memset(data, 0, sizeof(data)/sizeof(char));
	while(cancontinue)
	{
		int result=recv((*netandsock->sock),data,1000,0);
		if((result==0)||(result==SOCKET_ERROR))
		{
			cout<<result<<endl;
			out.close();
			cancontinue=false;
		}
		else
		{
			out.write(data,result);
			memset(data, 0, sizeof(data)/sizeof(char));
			cout<<result<<endl;
			totalbytes+=result;
			out.flush();
		}
	}
	cout<<"totalbytes received:"<<totalbytes<<endl;
	return 0;
}