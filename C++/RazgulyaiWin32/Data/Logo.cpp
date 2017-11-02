#include "stdafx.h"
#include "Logo.h"
#include <math.h>



POINT getRotate(POINT pCenter, POINT pPoint, int pDeg)
{
	POINT result;
	double radian = pDeg / 180.0 * 3.141592654;
	result.x = static_cast<LONG>(pCenter.x + (pPoint.x - pCenter.x) * cos(radian) - (pPoint.y - pCenter.y) * sin(radian));
	result.y = static_cast<LONG>(pCenter.y + (pPoint.y - pCenter.y) * cos(radian) + (pPoint.x - pCenter.x) * sin(radian));
	return result;
}



POINT getScale(POINT pPoint, float pScale)
{
	POINT result;
	result.x = static_cast<LONG>(pPoint.x * pScale);
	result.y = static_cast<LONG>(pPoint.y * pScale);
	return result;
}



RECT drawBack(HDC pHdc, POINT pCenter, COLORREF pColor, COLORREF pTextColor, double pScale = 1.0, bool pDrawName = false)
{
	RECT result;

	HBRUSH hbrush = CreateSolidBrush(pColor);
	HBRUSH hbrushOld = (HBRUSH)SelectObject(pHdc, hbrush);

	HPEN hpen = CreatePen(PS_SOLID, 2, RGB(0, 0, 0));
	HPEN hpenOld = (HPEN)SelectObject(pHdc, hpen);

	RECT rt = {
		pCenter.x - static_cast<int>(160 * pScale),
		pCenter.y - static_cast<int>(160 * pScale),
		pCenter.x + static_cast<int>(160 * pScale),
		pCenter.y + static_cast<int>(240 * pScale)
	};

	result = rt;

	RoundRect(
		pHdc,
		rt.left,
		rt.top,
		rt.right,
		rt.bottom,
		static_cast<int>(20 * pScale),
		static_cast<int>(20 * pScale)
	);

	SelectObject(pHdc, hpenOld);
	DeleteObject(hpen);

	SelectObject(pHdc, hbrushOld);
	DeleteObject(hbrush);

	rt.bottom -= static_cast<int>(30 * pScale);

	SetTextColor(pHdc, pTextColor);
	SetBkColor(pHdc, pColor);

	FontParameters font;

	font.size = static_cast<int>(30 * pScale);
	font.name = _T("Times New Romain");
	font.bold = TRUE;
	font.justify = DT_CENTER | DT_SINGLELINE;
	font.color = pTextColor;
	font.backColor = pColor;

	drawText(pHdc, rt, font, _T("Совхоз \"Разгуляй\""));

	return result;
}



void drawPetal(HDC pHdc, POINT pCenter, int pDeg, COLORREF pColor = RGB(200, 200, 0), double pScale = 1.0)
{
	POINT Pt[4] =
	{
		{ pCenter.x - static_cast<LONG>(142.0 * pScale), pCenter.y },
		{ pCenter.x - static_cast<LONG>(107.0 * pScale), pCenter.y },
		{ pCenter.x - static_cast<LONG>(75.0 * pScale), pCenter.y + static_cast<LONG>(67.0 * pScale) },
		pCenter
	};

	POINT Pt2[4] =
	{
		{ pCenter.x - static_cast<LONG>(142.0 * pScale), pCenter.y },
		{ pCenter.x - static_cast<LONG>(68.0 * pScale), pCenter.y - static_cast<LONG>(68.0 * pScale) },
		{ pCenter.x - static_cast<LONG>(36.0 * pScale), pCenter.y },
		pCenter
	};


	Pt[0] = getRotate(pCenter, Pt[0], pDeg);
	Pt[1] = getRotate(pCenter, Pt[1], pDeg);
	Pt[2] = getRotate(pCenter, Pt[2], pDeg);

	Pt2[0] = getRotate(pCenter, Pt2[0], pDeg);
	Pt2[1] = getRotate(pCenter, Pt2[1], pDeg);
	Pt2[2] = getRotate(pCenter, Pt2[2], pDeg);

	HPEN hpen, hpenOld;
	HBRUSH hbrush, hbrushOld;


	hpen = CreatePen(PS_SOLID, 1, pColor);
	hpenOld = (HPEN)SelectObject(pHdc, hpen);

	hbrush = CreateSolidBrush(pColor);
	hbrushOld = (HBRUSH)SelectObject(pHdc, hbrush);

	BeginPath(pHdc);
	PolyBezier(pHdc, Pt, 4);
	PolyBezier(pHdc, Pt2, 4);

	EndPath(pHdc);

	StrokeAndFillPath(pHdc);

	SelectObject(pHdc, hpenOld);
	DeleteObject(hpen);

	SelectObject(pHdc, hbrushOld);
	DeleteObject(hbrush);

	hpen = CreatePen(PS_SOLID, 2, RGB(0, 0, 0));
	SelectObject(pHdc, hpen);

	PolyBezier(pHdc, Pt, 4);
	PolyBezier(pHdc, Pt2, 4);

	SelectObject(pHdc, hpenOld);
	DeleteObject(hpen);
}



void drawCenter(HDC pHdc, POINT pCenter, COLORREF pColor = RGB(100, 100, 0), double pScale = 1.0)
{
	HBRUSH hbrush = CreateSolidBrush(pColor);
	HBRUSH hbrushOld = (HBRUSH)SelectObject(pHdc, hbrush);

	HPEN hpen = CreatePen(PS_SOLID, 2, RGB(0, 0, 0));
	HPEN hpenOld = (HPEN)SelectObject(pHdc, hpen);

	Ellipse(
		pHdc,
		pCenter.x - static_cast<int>(40 * pScale),
		pCenter.y - static_cast<int>(40 * pScale),
		pCenter.x + static_cast<int>(40 * pScale),
		pCenter.y + static_cast<int>(40 * pScale)
	);

	SelectObject(pHdc, hbrushOld);
	DeleteObject(hbrush);

	SelectObject(pHdc, hpenOld);
	DeleteObject(hpen);
}



RECT drawLogo(HDC pHdc, POINT pCenter, COLORREF pBackColor, COLORREF pTextColor, COLORREF pPetalColor, COLORREF pCenterColor, double pScale)
{
	RECT result = drawBack(pHdc, pCenter, pBackColor, pTextColor, pScale);

	drawPetal(pHdc, pCenter, 0,		pPetalColor, pScale);
	drawPetal(pHdc, pCenter, 45,	pPetalColor, pScale);
	drawPetal(pHdc, pCenter, 90,	pPetalColor, pScale);
	drawPetal(pHdc, pCenter, 135,	pPetalColor, pScale);
	drawPetal(pHdc, pCenter, 180,	pPetalColor, pScale);
	drawPetal(pHdc, pCenter, 225,	pPetalColor, pScale);
	drawPetal(pHdc, pCenter, 270,	pPetalColor, pScale);
	drawPetal(pHdc, pCenter, 315,	pPetalColor, pScale);

	drawCenter(pHdc, pCenter, pCenterColor, pScale);

	return result;
}