// ���� ifdef ���Ǵ���ʹ�� DLL �������򵥵�
// ��ı�׼�������� DLL �е������ļ��������������϶���� FILETRANSMIT_EXPORTS
// ���ű���ġ���ʹ�ô� DLL ��
// �κ�������Ŀ�ϲ�Ӧ����˷��š�������Դ�ļ��а������ļ����κ�������Ŀ���Ὣ
// FILETRANSMIT_API ������Ϊ�Ǵ� DLL ����ģ����� DLL ���ô˺궨���
// ������Ϊ�Ǳ������ġ�
#ifdef FILETRANSMIT_EXPORTS
#define FILETRANSMIT_API __declspec(dllexport)
#else
#define FILETRANSMIT_API __declspec(dllimport)
#endif

// �����Ǵ� Filetransmit.dll ������
class FILETRANSMIT_API CFiletransmit {
public:
	CFiletransmit(void);
	// TODO: �ڴ�������ķ�����
};

extern FILETRANSMIT_API int nFiletransmit;

FILETRANSMIT_API int fnFiletransmit(void);
