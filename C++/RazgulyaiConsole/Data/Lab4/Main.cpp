#include "stdafx.h"
#include "Employees.h"
#include <iostream>
#include <cstring>
#include <Windows.h>
using namespace std;

const char *filePath = "Employees.bin";

// вывод цеха с максимальной средней зарплатой и таблички, отсортированной по цехам
void printCehWithMaxAvgSalary() {
	int size;
	EmployeeT *Employees = GetEmployees(filePath, size);

	bool isSorted = false;

	// сортируем по цехам
	while (!isSorted) {
		isSorted = true;

		for (int i = 0; i < size - 1; i++)
			if (Employees[i].number > Employees[i + 1].number) {
				EmployeeT tmp = Employees[i];
				Employees[i] = Employees[i + 1];
				Employees[i + 1] = tmp;
				isSorted = false;
			}
	}

	double maxAvg = 0;
	int maxNumber = -1;
	int currNumber = Employees[0].number;
	int i = 0;

	// вычисляем среднее арифметическое для каждого цеха и сравниваем его с максимальным
	while (i < size) {
		double avg = 0;
		double count = 0;

		while (Employees[i].number == currNumber && i < size) {
			avg += Employees[i].payment;
			count++;
			i++;
		}
		avg /= count;

		if (avg > maxAvg) {
			maxAvg = avg;
			maxNumber = currNumber;
		}

		if (i < size)
			currNumber = Employees[i].number;
	}

	 cout <<  endl << "workshop with max average payment is " << maxNumber << " (average payment: " << maxAvg << ")" <<  endl <<  endl;

	// выводим таблицу сгруппированную по цехам
	printHeader("Table with Workshops");
	for (int i = 0; i < size; i++) {
		if (i > 0 && Employees[i].number != Employees[i - 1].number)
			printFooter();

		printElement(Employees[i]);
	}
	printFooter();
}

// вывод работников в цехе workshop
void printCeh(int workshop) {
	int size, count = 0;
	EmployeeT *Employees = GetEmployees(filePath, size);

	printHeader("Your workshop");
	for (int i = 0; i < size; i++) 
		if (Employees[i].number == workshop) {
			count++;
			printElement(Employees[i]);
		}

	if (count == 0) {
		printCenterText("No Employees in this workshop", 50);
		 cout <<  endl;
	}

	printFooter();
}

// основное меню программы
void main() {
	SetConsoleCP(1251);// установка кодовой страницы win-cp 1251 в поток ввода
	SetConsoleOutputCP(1251); // установка кодовой страницы win-cp 1251 в поток вывода

	bool exit = false;
	bool was_added = false;

	do {
		system("cls");

		 cout << "What do you want to do?" <<  endl;

		 cout << "1. Enter employees to program (it delete all users before)" <<  endl;
		 cout << "2. Add one employee" <<  endl;
		 cout << "3. Print all employees" <<  endl;
		 cout << "4. Print employees of workshop by workshop number" <<  endl;
		 cout << "5. Print workshop with max average payment" <<  endl;
		 cout << "6. Exit" <<  endl;

		 cout <<  endl;

		int variant = getInteger(6, ">");

		// если ещё не вводили данные, то нельзя выполнить действия 3 - 5
		if (!was_added && variant > 2 && variant < 6) {
			 cout << "No Employees were added in program. Please, add employees" <<  endl;
			system("pause");
			continue;
		}

		if (was_added && variant == 1)
			if (getInteger(2, "Are you sure to enter new records to program? (1- yes, 2 - no)") == 2)
				continue;

		switch (variant) {
		case 1:
			REmployeesToFile(filePath, getInteger("How much Employees do you want to enter? "));
			was_added = true;
			break;

		case 2:
			AEmployeesToFile(filePath);
			was_added = true;
			break;

		case 3:
			PWorkshops(filePath);
			break;

		case 4:
			printCeh(getInteger("Enter workshop number: "));
			break;

		case 5:
			printCehWithMaxAvgSalary();
			break;

		case 6:
			exit = true;
			break;
		}

		if (!exit)
			system("pause");
	} while (!exit);
	
}


