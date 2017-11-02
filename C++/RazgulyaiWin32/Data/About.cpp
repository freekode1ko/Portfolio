#include "stdafx.h"
#include "About.h"
#include "resource.h"


std::wstring gInfo = L"Вариант №8\r\nИсполнитель: Дрябков Олег БСТ-1602\r\nРуководитель: Кувыкина М.И.";

INT_PTR CALLBACK aboutCallBack(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
	UNREFERENCED_PARAMETER(lParam);
	switch (message)
	{
	case WM_INITDIALOG:
		{
			CenterWnd(hDlg, GetParent(hDlg));

			HBITMAP hBitmap;
			hBitmap = (HBITMAP)LoadImage(NULL, _T("photo.bmp"), IMAGE_BITMAP, 0, 0, LR_LOADFROMFILE);
			HWND hPic = GetDlgItem(hDlg, IDC_PHOTO);
			SendMessage(hPic, STM_SETIMAGE, IMAGE_BITMAP, LPARAM(hBitmap));		

			HWND ctrlHWND = GetDlgItem(hDlg, IDC_INFO);
			HFONT hfont = CreateFont
			(
				20,
				0, 0, 0, TRUE, FALSE, FALSE, 0, DEFAULT_CHARSET, OUT_OUTLINE_PRECIS,
				CLIP_DEFAULT_PRECIS, ANTIALIASED_QUALITY, FF_MODERN, _T("Tahoma")
			);
			SendMessage(ctrlHWND, WM_SETFONT, (WPARAM)hfont, (LPARAM)FALSE);		
			SetWindowText(ctrlHWND, gInfo.c_str());

 		}
		return (INT_PTR)TRUE;

	case WM_COMMAND:
		if (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL)
		{
			EndDialog(hDlg, LOWORD(wParam));
			return (INT_PTR)TRUE;
		}
		break;
	}
	return (INT_PTR)FALSE;
}