#include "stdafx.h"
#include "Tools.h"

void CenterWnd(HWND pWindow, HWND pParentWindow/* = NULL*/)
{
	RECT r, r1;
	GetWindowRect(pWindow, &r);
	GetWindowRect((pParentWindow == NULL) ? GetDesktopWindow() : pParentWindow, &r1);
	MoveWindow(pWindow, r1.left + ((r1.right - r1.left) - (r.right - r.left)) / 2,
		r1.top + ((r1.bottom - r1.top) - (r.bottom - r.top)) / 2,
		(r.right - r.left), (r.bottom - r.top), 0);
}

void drawText(HDC pHdc, RECT pRectangle, FontParameters pFont, LPTSTR pText)
{
	HFONT hfont = CreateFont
	(
		pFont.size,
		0, 0, 0, pFont.bold, pFont.italic, pFont.underline, 0, DEFAULT_CHARSET, OUT_OUTLINE_PRECIS,
		CLIP_DEFAULT_PRECIS, ANTIALIASED_QUALITY, FF_MODERN, pFont.name
	);

	HFONT hfontOld = (HFONT)SelectObject(pHdc, hfont);

	int bkModeOld = GetBkMode(pHdc);
	SetTextColor(pHdc, pFont.color);
	SetBkColor(pHdc, pFont.backColor);

	DrawText(pHdc, pText, -1, &pRectangle, pFont.justify | DT_BOTTOM | DT_NOCLIP);

	//SetBkMode(pHdc, bkModeOld);
	SelectObject(pHdc, hfontOld);
	DeleteObject(hfontOld);
}