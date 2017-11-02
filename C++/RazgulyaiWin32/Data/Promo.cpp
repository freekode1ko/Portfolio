#include "stdafx.h"

#include "Logo.h"
#include "Promo.h"
#include "resource.h"



static PromoParameters params;



void showPromo(PromoParameters pParams)
{
	params = pParams;
	params.scale = pParams.size.x / 800.0;
	DialogBox(params.hInstance, MAKEINTRESOURCE(IDD_FORMVIEW), params.hwndParent, promoCallBack);
}



void drawPromo(HWND pHDlg)
{
	PAINTSTRUCT ps;
	HDC hdc = BeginPaint(pHDlg, &ps);

//= = = = =

	RECT rt = drawLogo(
		hdc,
		{ static_cast<LONG>(150 * params.scale), static_cast<LONG>(150 * params.scale) },
		params.logoBackColor,
		params.logoTextColor,
		params.logoPetalColor,
		params.logoCenterColor,
		0.75 * params.scale);

	FontParameters font;
	
	font.size = static_cast<int>(60 * params.scale);
	font.name = _T("Tahoma");
	font.bold = TRUE;
	font.color = params.nameColor;
	font.backColor = params.backColor;
	font.justify = DT_LEFT;

	rt.left = static_cast<LONG>(rt.right + 10 * params.scale);
	rt.right = static_cast<int>(params.size.x - (rt.right - rt.left) - 50 * params.scale);
	rt.bottom = rt.top + font.size;
	drawText(hdc, rt, font, _T("СОВХОЗ \"РАЗГУЛЯЙ\""));

	font.size = static_cast<int>(50 * params.scale);
	font.color = params.tegColor;
	rt.top = rt.bottom;
	rt.bottom = static_cast<int>(rt.top + font.size + 5 * params.scale);
	drawText(hdc, rt, font, _T("Лучшие свежие продкуты,\nпо адекватной цене!"));

	rt.top = static_cast<int>(rt.bottom + font.size + 20 * params.scale);
	font.size = static_cast<int>(30 * params.scale);
	font.color = params.directorColor;
	font.italic = TRUE;
	rt.bottom = static_cast<int>(rt.top + font.size + 5 * params.scale);
	drawText(hdc, rt, font, _T("Руководитель: Астраханцев Ю.Н."));

	font.size = static_cast<int>(20 * params.scale);
	font.italic = FALSE;
	font.underline = TRUE;
	font.justify = DT_RIGHT;
	font.color = params.phoneColor;
	rt.top = static_cast<int>(rt.bottom + 60 * params.scale);
	rt.bottom = static_cast<int>(rt.top + font.size + 5 * params.scale);
	drawText(hdc, rt, font, _T("телефон/факс: (495) 517-92-14"));

//= = = = =

	EndPaint(pHDlg, &ps);
}



INT_PTR CALLBACK promoCallBack(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
	UNREFERENCED_PARAMETER(lParam);
	switch (message)
	{
	case WM_INITDIALOG:
	{
		SetWindowPos(hDlg, NULL, 0, 0, params.size.x, params.size.y, SWP_NOMOVE);
		CenterWnd(hDlg, GetParent(hDlg));

		HWND hButton = GetDlgItem(hDlg, IDOK);
		RECT rt;
		GetWindowRect(hButton, &rt);
		rt.right -= rt.left;
		rt.bottom -= rt.top;
		SetWindowPos(hButton, NULL, params.size.x - rt.right - 16, params.size.y - rt.bottom - 16, 0, 0, SWP_NOSIZE);
		return (INT_PTR)TRUE;
	}
	case WM_PAINT:
		drawPromo(hDlg);
		break;
	case WM_CTLCOLORDLG:
	{
		HBRUSH hbrush = CreateSolidBrush(params.backColor);
		return (INT_PTR)hbrush;
	}
		break;
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