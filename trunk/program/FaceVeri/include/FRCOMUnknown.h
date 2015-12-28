//////////////////////////////////////////////////////////////////////
//
//	FileName:	FRCOMUnknown.h 
//	Version:	1.0
//	Creator:	Liu Guangkai
//	Date:		2011/02/28 17:00
//	Comment:	
//
//	Copyright:	copyright (c) , All copyright reserved
//
//////////////////////////////////////////////////////////////////////
#ifndef __FR_UNKNOWN_H__
#define __FR_UNKNOWN_H__
#include <unknwn.h>

class FRCOMUnknown
{
public:
    virtual ULONG STDMETHODCALLTYPE AddRef() = 0;
    virtual ULONG STDMETHODCALLTYPE Release() = 0;

public:
    virtual HRESULT STDMETHODCALLTYPE Init(void *pvContext) = 0;
    virtual HRESULT STDMETHODCALLTYPE UnInit(void *pvContext) = 0;
};


#endif // END __FR_UNKNOWN_H__