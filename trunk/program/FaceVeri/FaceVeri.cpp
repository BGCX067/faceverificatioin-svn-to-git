// TestVerification.cpp : Defines the entry point for the console application.
//
#include "stdafx.h"
#include "FaceVeri.h"
#include "IFaceRecognition.h"
#include "CServerSocket.h"
#include <string>
HMODULE             m_hModule;
#define FR_MODULE_NAME         _T("FaceRecognitionEx.DLL") 
#define FR_MODULE_EXPORT_FUNC  "FRGetModule"
typedef HRESULT STDMETHODCALLTYPE FnFRGetModule(void **ppvObject, DWORD dwReserved);

IFaceRecognition    *m_pFaceRecogn;

// The one and only application object
CWinApp theApp;

using namespace std;

bool init()
{
	//Load module
	m_hModule = LoadLibrary(FR_MODULE_NAME);
	if (m_hModule == NULL)
	{
		printf("load DLL failed!\n");
		return FALSE;
	}

	FnFRGetModule *fnFRGetModule = (FnFRGetModule *)GetProcAddress(m_hModule, FR_MODULE_EXPORT_FUNC);
	if ( !fnFRGetModule )
	{
		printf("Get module failed!\n");
		return FALSE;
	}

	HRESULT hr = fnFRGetModule((void **)&m_pFaceRecogn, 0);

	//load model file 
	float begin_fe = (float)GetTickCount();
	if (S_OK == hr && S_OK != m_pFaceRecogn->LoadModels(L".\\models"))
	{
		printf("load MODEL failed!\n");
		return FALSE;
	}
	begin_fe = (GetTickCount() - begin_fe)/1000;
	wprintf(L"Initial Load Model Cost: %f Second\n", begin_fe);

	return TRUE;
}

//Main func for the face verification
int _tmain(int argc, TCHAR* argv[], TCHAR* envp[])
{
	int nRetCode = 0;

	HMODULE hModule = ::GetModuleHandle(NULL);

	if (hModule != NULL)
	{
		if (!AfxWinInit(hModule, NULL, ::GetCommandLine(), 0))
		{
			_tprintf(_T("Fatal Error: MFC initialization failed\n"));
			nRetCode = 1;
		}
		else
		{
			int i=2;

			//initial face recognition engine

			if( init() != FALSE )
			{
				while(1)
				{
					//Face verification
					CServerSocket soc;
					soc.run();
					soc.receiveFile(L".\\testdata\\1.jpg");
					soc.run();
					soc.receiveFile(L".\\testdata\\2.jpg");		
					double begin_fe=GetTickCount();		
					double dscore = m_pFaceRecogn->FaceVerification
						(L".\\testdata\\1.jpg",  L".\\testdata\\2.jpg");
					begin_fe = (GetTickCount() - begin_fe)/1000;
					wprintf(L"Recongition Cost: %f Second\n", begin_fe);
					if( dscore > 0.4f )
					{
						wprintf( L"Face Similarity Score: %f, same person!\n", dscore);
					}
					else
					{
						wprintf( L"Face Similarity Score:%f, diff person!\n", dscore);
					}	
				}
			}
		}
	}
	else
	{
		_tprintf(_T("Fatal Error: GetModuleHandle failed\n"));
		nRetCode = 1;
	}

	return nRetCode;

}
