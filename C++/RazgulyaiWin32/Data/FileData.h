#pragma once

#include "stdafx.h"
#include <string>

static int lastID = -1;
static std::wstring FILE_CONTENT;

/*
Структура данных работнике
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
Загрузка содержимого файла в переменную FILE_CONTENT
*/
extern bool loadFile();

/*
Сохранение собержимого переменной FILE_CONTENT в файл
*/
extern bool saveFile();

/*
Добавление в файл нового работника
*/
extern bool addWorker(Worker pNewWorker);

/*
Получение данных о работнике по его ID
*/
extern bool getWorker(int pID, Worker& worker);

/*
Изменение данных о работнике по его ID
*/
extern bool setWorker(int pID, Worker worker);

/*
Отметить работника для удаления
*/
extern bool mark(int pID);

/*
Снять с работника мету об удалении
*/
extern bool unmark(int pID);

/*
Удалить всех помеченных работников
*/
extern bool deleteMarked();

/*
Получить форматированную строку с данными о работниках для отображения в текстовом поле
*/
extern std::wstring getStringEB();

/*
Получить форматированную строку с данными о самых младших и самых старших работниках в бригаде
*/
extern std::wstring query(int pBrig);

/*
Функция обратного вызова диалога ввода ID работника
*/
extern INT_PTR CALLBACK getIDCallBack(HWND, UINT, WPARAM, LPARAM);

/*
Функция обратного вызова диалога окна редактирования данных работника
*/
extern INT_PTR CALLBACK editCallBack(HWND, UINT, WPARAM, LPARAM);

/*
Функция обратного вызова диалога ввода номера бригады
*/
extern INT_PTR CALLBACK getBrigCallBack(HWND, UINT, WPARAM, LPARAM);

/*
Функция обратного вызова диалога окна с информацией о самых старых и самых молодых работниках
*/
extern INT_PTR CALLBACK resultCallBack(HWND, UINT, WPARAM, LPARAM);