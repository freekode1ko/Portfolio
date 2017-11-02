#ifndef _Employees_H_
#define _Employees_H_

#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <cstring>

// �������� ��������� � �� � �����
typedef struct EmployeeT {
	int number;
	char surname[100];
	int payment;
} EmployeeT;

// ��������� ������ ����� � ��������� �� ������������ ����
int getInteger(const char *msg = "");
int getInteger(int max, const char *msg = "");

void printCenterText(char *text, int length);
void printHeader(char *headerText = "");
void printFooter();
void printElement(EmployeeT &Employee);

// ������ ���� �����
void PWorkshops(const char *filePath);
// ���� ������ � ����
void REmployeesToFile(const char *filePath, int n);
// ���������� ������ � ����
void AEmployeesToFile(const char *filePath);
// ��������� ������� ���������� �� �����
EmployeeT *GetEmployees(const char *filePath, int &size);

#endif