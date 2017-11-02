#include "stdafx.h"
#include "Dryabkov_8.h"
#include "Promo.h"
#include "FileData.h"
#include "About.h"



#pragma comment(linker, \
  "\"/manifestdependency:type='Win32' "\
  "name='Microsoft.Windows.Common-Controls' "\
  "version='6.0.0.0' "\
  "processorArchitecture='*' "\
  "publicKeyToken='6595b64144ccf1df' "\
  "language='*'\"")

#pragma comment(lib, "ComCtl32.lib")



INT_PTR CALLBACK mainCallBack(HWND, UINT, WPARAM, LPARAM);


/*
Главная функция программы
*/
int APIENTRY wWinMain(_In_ HINSTANCE pHInstance, _In_opt_ HINSTANCE pHPrevInstance, _In_ LPWSTR pLpCmdLine, _In_ int pNCmdShow)
{
	HWND hDlg;
	MSG msg;
	BOOL ret;

	gHInstance = pHInstance;

	InitCommonControls();
	hDlg = CreateDialogParam(gHInstance, MAKEINTRESOURCE(IDD_DIALOG1), 0, mainCallBack, 0);
	ShowWindow(hDlg, pNCmdShow);

	while ((ret = GetMessage(&msg, 0, 0, 0)) != 0) {
		if (ret == -1)
			return -1;

		if (!IsDialogMessage(hDlg, &msg)) {
			TranslateMessage(&msg);
			DispatchMessage(&msg);
		}
	}

	return 0;
}


/*
Функция обратного вызова основного окна программы
*/
INT_PTR CALLBACK mainCallBack(HWND pHDlg, UINT pUMsg, WPARAM pWParam, LPARAM pLParam)
{
	switch (pUMsg)
	{
	case WM_INITDIALOG:
		{
			HMENU hMenu = LoadMenu(gHInstance, MAKEINTRESOURCE(IDC_DRYABKOV_8));
			SetMenu(pHDlg, hMenu);
			CenterWnd(pHDlg);
			std::wstring fileContent = getStringEB();
			HWND ctrlHWND = GetDlgItem(pHDlg, IDC_EDIT1);
			SetWindowText(ctrlHWND, fileContent.c_str());
			
			ctrlHWND = GetDlgItem(pHDlg, IDC_DELETE);
			SetFocus(ctrlHWND);
		}
		break;
	case WM_COMMAND:
		switch (LOWORD(pWParam))
		{
            case IDM_ABOUT:
                DialogBox(gHInstance, MAKEINTRESOURCE(IDD_ABOUTBOX), pHDlg, aboutCallBack);
                break;
			case IDM_PROMO:
				{
					PromoParameters params;
					
					params.hwndParent = pHDlg;
					params.hInstance = gHInstance;
					params.backColor = RGB(0, 0, 255);
					params.size = { 800, 500 };

					showPromo(params);
				}
				break;
			case IDM_EDIT:
			{
				DialogBox(gHInstance, MAKEINTRESOURCE(IDD_DIALOG3), pHDlg, getIDCallBack);
				std::wstring fileContent = getStringEB();
				HWND ctrlHWND = GetDlgItem(pHDlg, IDC_EDIT1);
				SetWindowText(ctrlHWND, fileContent.c_str());
				SetFocus(ctrlHWND);
			}
			break;

			case IDM_QUERY:
			{
 				DialogBox(gHInstance, MAKEINTRESOURCE(IDD_DIALOG4), pHDlg, getBrigCallBack);
			}
			break;

			case IDC_DELETE:
			{
				deleteMarked();
				std::wstring fileContent = getStringEB();
				HWND ctrlHWND = GetDlgItem(pHDlg, IDC_EDIT1);
				SetWindowText(ctrlHWND, fileContent.c_str());
				SetFocus(ctrlHWND);
			}
			break;
		case IDCANCEL:
			SendMessage(pHDlg, WM_CLOSE, 0, 0);
			return TRUE;
		}
		break;

	case WM_CLOSE:
			DestroyWindow(pHDlg);
		return TRUE;

	case WM_DESTROY:
		PostQuitMessage(0);
		return TRUE;
	}

	return FALSE;
}
