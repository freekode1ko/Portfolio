#pragma once

#include "stdafx.h"

/*
Структура параметров рекламной заставки
*/
struct PromoParameters
{	
	HWND hwndParent;
	HINSTANCE hInstance;
	COLORREF backColor;
	POINT size;
	
	COLORREF logoBackColor;
	COLORREF logoCenterColor;
	COLORREF logoTextColor;
	COLORREF logoPetalColor;
	
	COLORREF nameColor;
	COLORREF tegColor;
	COLORREF directorColor;
	COLORREF phoneColor;


	double scale;

	PromoParameters() {
		hwndParent = NULL;
		hInstance = NULL;
		backColor = RGB(0, 0, 255);
		size = { 800, 600 };

		logoBackColor = RGB(128, 128, 255);
		logoCenterColor = RGB(100, 100, 0);
		logoTextColor = RGB(0, 0, 128);
		logoPetalColor = RGB(200, 200, 0);

		nameColor = RGB(255, 255, 0);
		tegColor = RGB(128, 128, 255);
		directorColor = RGB(255, 128, 0);
		phoneColor = RGB(255, 255, 255);
		scale = 1.0;
	}
};

/*
Функция отображения рекламной заставки
*/
extern void showPromo(PromoParameters pParams);

/*
Функция обратного вызова для диалога рекламной заставки
*/
extern INT_PTR CALLBACK promoCallBack(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam);