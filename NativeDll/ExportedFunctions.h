#ifdef MY_EXPORTS
#define MY_EXPORTS __declspec(dllexport) 
#else
#define MY_EXPORTS __declspec(dllimport) 
#endif


namespace MyExportFunctions
{
	extern "C" MY_EXPORTS void SetToOne(double a);


}