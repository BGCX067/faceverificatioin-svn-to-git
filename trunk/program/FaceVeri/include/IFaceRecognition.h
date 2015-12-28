//////////////////////////////////////////////////////////////////////
//
//	FileName:	IFaceRecognition.h 
//	Version:	1.0
//	Creator:	Liu Guangkai
//	Date:		2011/02/28 17:00
//	Comment:	
//
//	Copyright:	copyright (c) , All copyright reserved
//
//////////////////////////////////////////////////////////////////////

#ifndef _FACERECOGNITION_H_
#define _FACERECOGNITION_H_

#include "FRCOMUnknown.h"


#ifdef __cplusplus
extern "C" {
#endif

typedef struct
{
    RECT rcFace;
    RECT rcNose;
    RECT rcMouth;
    RECT rcLeftEye;
    RECT rcRightEye;
}FACECOMPONENTS, *PFACECOMPONENTS;

namespace Gdiplus
{
    class Bitmap;
}
using namespace Gdiplus;

class IFaceRecognition : public FRCOMUnknown
{
public:
    virtual HRESULT STDMETHODCALLTYPE LoadModels(
        __in const wchar_t* pwszModelPath) = 0;

    virtual HRESULT STDMETHODCALLTYPE LoadFaceRecognitionBase(
        __in const wchar_t* wszDir, 
        __in const wchar_t* wszFeatureFileRead = NULL,
        __in const wchar_t* wszFeatureFileWrite = NULL) = 0;

    virtual HRESULT STDMETHODCALLTYPE AddItemToBaseMemory(
        __in const wchar_t* wszAddItemFilePath) = 0;

    virtual HRESULT STDMETHODCALLTYPE ReleaseFaceRecognitionBase() = 0;

    virtual HANDLE STDMETHODCALLTYPE BeginFaceRecognition(
        __in  const wchar_t *pwszImagePath, 
        __in  double        dThreshold,
        __out wchar_t       *pwszRecgFacePath,
        __in  unsigned int  nRecgFacePathSize,
        __out unsigned int  &nRecognizedFaceNum) = 0;

    virtual HANDLE STDMETHODCALLTYPE BeginFaceRecognition(
        __in  Bitmap        &bmpInput, 
        __in  double        dThreshold,
        __out wchar_t       *pwszRecgFacePath,
        __in  unsigned int  nRecgFacePathSize,
        __out unsigned int  &nRecognizedFaceNum) = 0;

    virtual BOOL STDMETHODCALLTYPE NextRecognizedFace(
        __in  HANDLE        hFaceRecg, 
        __out wchar_t       *pwszRecgFacePath,
        __in  unsigned int  nRecgFacePathSize ) = 0;

    virtual BOOL STDMETHODCALLTYPE CloseFaceRecognition(
        __in HANDLE hFaceRecg) = 0;

public:

    virtual BOOL STDMETHODCALLTYPE FaceVerification(
        __in const wchar_t *pwszSrcImage, 
        __in const wchar_t *pwszDstImage,
        __in double         dThreshold) = 0;

	virtual double STDMETHODCALLTYPE FaceVerification(
        __in const wchar_t *pwszSrcImage, 
        __in const wchar_t *pwszDstImage) = 0;

    virtual HRESULT STDMETHODCALLTYPE ExtractFaceComponents( 
        __in const wchar_t   *pwszImagePath,
        __out FACECOMPONENTS &faceComponents) = 0;

    virtual HRESULT STDMETHODCALLTYPE ComputeFaceQuality( 
        __in const wchar_t *pwszImagePath,
        __out unsigned int &unQualityScore) = 0;

    virtual HRESULT STDMETHODCALLTYPE DetectFaces( 
        __in  int        nWidth,
        __in  int        nHeight,
        __in  const BYTE *pbImage,
        __in  int        nStride,
        __in  int        nColorSequence,
        __in  BOOL       bTopDown,
        __in  LPRECT     lpRect,
        __out int        *pnCount,
        __out RECT       **ppRcFace ) = 0;

    virtual HRESULT STDMETHODCALLTYPE FreeFaceRect( 
        __in RECT* pRcFace ) = 0;

    virtual HRESULT STDMETHODCALLTYPE FaceRecognitionTest( 
        __in const wchar_t* wszDir) = 0;
};

HRESULT STDMETHODCALLTYPE FRGetModule(
    __out void  **ppvObject,
    __in  DWORD dwReserve = 0
    );

#ifdef __cplusplus
}
#endif

#endif