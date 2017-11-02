#pragma once

#include "stdafx.h"
#include <string>

static int lastID = -1;
static std::wstring FILE_CONTENT;

/*
��������� ������ ���������
*/
struct Worker
{
	std::wstring id;
	std::wstring marked;
	std::wstring name;
	std::wstring birthday;
	std::wstring brig;
	std::wstring specialty;
	std::wstring salary;
};



/*
�������� ����������� ����� � ���������� FILE_CONTENT
*/
extern bool loadFile();

/*
���������� ����������� ���������� FILE_CONTENT � ����
*/
extern bool saveFile();

/*
���������� � ���� ������ ���������
*/
extern bool addWorker(Worker pNewWorker);

/*
��������� ������ � ��������� �� ��� ID
*/
extern bool getWorker(int pID, Worker& worker);

/*
��������� ������ � ��������� �� ��� ID
*/
extern bool setWorker(int pID, Worker worker);

/*
�������� ��������� ��� ��������
*/
extern bool mark(int pID);

/*
����� � ��������� ���� �� ��������
*/
extern bool unmark(int pID);

/*
������� ���� ���������� ����������
*/
extern bool deleteMarked();

/*
�������� ��������������� ������ � ������� � ���������� ��� ����������� � ��������� ����
*/
extern std::wstring getStringEB();

/*
�������� ��������������� ������ � ������� � ����� ������� � ����� ������� ���������� � �������
*/
extern std::wstring query(int pBrig);

/*
������� ��������� ������ ������� ����� ID ���������
*/
extern INT_PTR CALLBACK getIDCallBack(HWND, UINT, WPARAM, LPARAM);

/*
������� ��������� ������ ������� ���� �������������� ������ ���������
*/
extern INT_PTR CALLBACK editCallBack(HWND, UINT, WPARAM, LPARAM);

/*
������� ��������� ������ ������� ����� ������ �������
*/
extern INT_PTR CALLBACK getBrigCallBack(HWND, UINT, WPARAM, LPARAM);

/*
������� ��������� ������ ������� ���� � ����������� � ����� ������ � ����� ������� ����������
*/
extern INT_PTR CALLBACK resultCallBack(HWND, UINT, WPARAM, LPARAM);