#include "stdafx.h"
#include "Employees.h"
using namespace std;
// получение натурального числа с проверкой на некорректный ввод
int getInteger(const char *msg) {
	char buf[256];
	int n;

	cout << msg;
	gets_s(buf, sizeof(buf));

	while (sscanf_s(buf, "%d", &n) != 1 || n < 1) {
		cout << "Incorrect input. Try again: ";
		gets_s(buf, sizeof(buf));
	}

	return n;
}

// получение натурального числа меньшего max с проверкой на некорректный ввод
int getInteger(int max, const char *msg) {
	char buf[256];
	int n;

	cout << msg;
	gets_s(buf, sizeof(buf));

	while (sscanf_s(buf, "%d", &n) != 1 || n < 1 || n > max) {
		cout << "Incorrect input. Try again: ";
		gets_s(buf, sizeof(buf));
	}

	return n;
}

// вывод текста text "по центру" в длине length
void printCenterText(char *text, int length) {
	int len = strlen(text);
	int position = (length - len) / 2;

	for (int i = 0; i < length; i++)
		cout << ((i >= position && i < length - position) ? text[i - position] : ' ');
}

// печать верхней части таблицы
void printHeader(char *headerText) {
	 cout <<  endl;
	 cout << "=================================================" <<  endl;
	 cout << "|";
	printCenterText(headerText, 48);
	 cout << "|" <<  endl;
	 cout << "=================================================" <<  endl;
	 cout << "| workshop |         Surname         |  payment  |" <<  endl;
	 cout << "=================================================" <<  endl;
}

// печать нижней части таблицы
void printFooter() {
	 cout << "=================================================" <<  endl;
}

// печать одного одного работника из цеха
void printElement(EmployeeT &Employee) {
	char buf[100];

	 cout << "|";
	sprintf_s(buf, "%d", Employee.number);
	printCenterText(buf, 5);
	 cout << "|";
	printCenterText(Employee.surname, 25);
	 cout << "|";
	sprintf_s(buf, "%d", Employee.payment);
	printCenterText(buf, 16);
	 cout << "|" <<  endl;
}

// печать всех цехов
void PWorkshops(const char *filePath) {
	printHeader("Table with all Workshops");

	 ifstream f;
	f.open(filePath,  ios::in |  ios::binary);
	EmployeeT Employee;

	// читаем, пока читается
	while (f.read((char*)&Employee, sizeof(Employee)))
		printElement(Employee);

	f.close();

	printFooter();
}

// ввод данных в файл
void REmployeesToFile(const char *filePath, int n) {
	 ofstream f;
	f.open(filePath,  ios::out |  ios::binary);

	for (int i = 0; i < n; i++) {
		EmployeeT payment;

		payment.number = getInteger("Enter workshop number: ");
		 cout << "Enter surname: ";
		gets_s(payment.surname, sizeof(payment.surname));
		payment.payment = getInteger("Enter payment: ");
		cout << "\n";
		f.write((char*)&payment, sizeof(payment));
	}

	f.close();
}

// добавление данных в файл
void AEmployeesToFile(const char *filePath) {
	 ofstream f;
	f.open(filePath,  ios::app |  ios::binary);

	EmployeeT payment;
	payment.number = getInteger("Enter workshop number: ");
	 cout << "Enter surname: ";
	gets_s(payment.surname, sizeof(payment.surname));
	payment.payment = getInteger("Enter payment: ");

	f.write((char*)&payment, sizeof(payment));

	f.close();
}

// получение массива работников из файла
EmployeeT *GetEmployees(const char *filePath, int &size) {
	size = 1;
	int index = 0;
	EmployeeT *Employees = new EmployeeT[size];
	EmployeeT Employee;

	 ifstream f;
	f.open(filePath,  ios::in |  ios::binary);

	// считываем вссех работников из цехов
	while (f.read((char*)&Employee, sizeof(Employee))) {
		Employees[index++] = Employee;

		if (index >= size) {
			EmployeeT *tmp = new EmployeeT[size * 2];

			for (int i = 0; i < size; i++)
				tmp[i] = Employees[i];

			size *= 2;

			delete[] Employees;
			Employees = tmp;
		}
	}

	f.close();

	size = index;

	return Employees;
}