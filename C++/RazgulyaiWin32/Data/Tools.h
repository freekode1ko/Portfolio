#pragma once

#include "Tools.h"

/*
��������� ��� �������� ���������� ������
*/
struct FontParameters
{
	int size;
	BOOL bold;
	BOOL italic;
	BOOL underline;
	LPTSTR name;
	COLORREF color;
	COLORREF backColor;
	UINT justify;

	FontParameters()
	{
		size = 20;
		bold = FALSE;
		italic = FALSE;
		underline = FALSE;
		name = _T("Tahoma");
		color = RGB(0, 0, 0);
		backColor = RGB(255, 255, 255);
		justify = DT_LEFT;
	}
};

/*
������� ��������� ����
*/
extern void CenterWnd(HWND pWindow, HWND pParentWindow = NULL);

/*
������� ������ ������
*/
extern void drawText(HDC pHdc, RECT pRectangle, FontParameters pFont, LPTSTR pText);