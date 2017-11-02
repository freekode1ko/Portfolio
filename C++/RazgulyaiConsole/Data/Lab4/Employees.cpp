#include "stdafx.h"
#include "Employees.h"
using namespace std;
// ��������� ������������ ����� � ��������� �� ������������ ����
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

// ��������� ������������ ����� �������� max � ��������� �� ������������ ����
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

// ����� ������ text "�� ������" � ����� length
void printCenterText(char *text, int length) {
	int len = strlen(text);
	int position = (length - len) / 2;

	for (int i = 0; i < length; i++)
		cout << ((i >= position && i < length - position) ? text[i - position] : ' ');
}

// ������ ������� ����� �������
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

// ������ ������ ����� �������
void printFooter() {
	 cout << "=================================================" <<  endl;
}

// ������ ������ ������ ��������� �� ����
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

// ������ ���� �����
void PWorkshops(const char *filePath) {
	printHeader("Table with all Workshops");

	 ifstream f;
	f.open(filePath,  ios::in |  ios::binary);
	EmployeeT Employee;

	// ������, ���� ��������
	while (f.read((char*)&Employee, sizeof(Employee)))
		printElement(Employee);

	f.close();

	printFooter();
}

// ���� ������ � ����
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

// ���������� ������ � ����
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

// ��������� ������� ���������� �� �����
EmployeeT *GetEmployees(const char *filePath, int &size) {
	size = 1;
	int index = 0;
	EmployeeT *Employees = new EmployeeT[size];
	EmployeeT Employee;

	 ifstream f;
	f.open(filePath,  ios::in |  ios::binary);

	// ��������� ����� ���������� �� �����
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