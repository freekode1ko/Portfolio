#ifndef _Employees_H_
#define _Employees_H_

#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <cstring>

// описание структуры о ЗП в цехах
typedef struct EmployeeT {
	int number;
	char surname[100];
	int payment;
} EmployeeT;

// получение целого числа с проверкой на некорректный ввод
int getInteger(const char *msg = "");
int getInteger(int max, const char *msg = "");

void printCenterText(char *text, int length);
void printHeader(char *headerText = "");
void printFooter();
void printElement(EmployeeT &Employee);

// печать всех цехов
void PWorkshops(const char *filePath);
// ввод данных в файл
void REmployeesToFile(const char *filePath, int n);
// добавление данных в файл
void AEmployeesToFile(const char *filePath);
// получение массива работников из файла
EmployeeT *GetEmployees(const char *filePath, int &size);

#endif