#include "stdafx.h"
#include "FileData.h"
#include "resource.h"
#include <fstream>
#include <locale>



Worker gCurrentWorker;
std::wstring gResult;



std::wstring WorkerToLine(Worker pWorker)
{
	std::wstring result;

	result += pWorker.id;
	result += L";";
	result += pWorker.marked;
	result += L";";
	result += pWorker.name;
	result += L";";
	result += pWorker.birthday;
	result += L";";
	result += pWorker.brig;
	result += L";";
	result += pWorker.specialty;
	result += L";";
	result += pWorker.salary;

	return result;
}



Worker lineToWorker(std::wstring pLine)
{
	Worker result;

	size_t pos = pLine.find_first_of(L";");
	result.id = pLine.substr(0, pos);
	pLine = pLine.substr(pos + 1, pLine.length() - pos - 1);

	pos = pLine.find_first_of(L";");
	result.marked = pLine.substr(0, pos);
	pLine = pLine.substr(pos + 1, pLine.length() - pos - 1);

	pos = pLine.find_first_of(L";");
	result.name = pLine.substr(0, pos);
	pLine = pLine.substr(pos + 1, pLine.length() - pos - 1);

	pos = pLine.find_first_of(L";");
	result.birthday = pLine.substr(0, pos);
	pLine = pLine.substr(pos + 1, pLine.length() - pos - 1);

	pos = pLine.find_first_of(L";");
	result.brig = pLine.substr(0, pos);
	pLine = pLine.substr(pos + 1, pLine.length() - pos - 1);

	pos = pLine.find_first_of(L";");
	result.specialty = pLine.substr(0, pos);
	pLine = pLine.substr(pos + 1, pLine.length() - pos - 1);

	pos = pLine.find_first_of(L";");
	result.salary = pLine.substr(0, pos);
	pLine = pLine.substr(pos + 1, pLine.length() - pos - 1);

	return result;
}



bool loadFile()
{
	FILE_CONTENT = L"";
	std::wifstream file("data.txt");
	file.imbue(std::locale("Russian"));
	if (file.is_open())
	{
		std::wstring line;
		while (getline(file, line))
		{
			Worker work = lineToWorker(line);
			if (lastID < std::stoi(work.id)) {
				lastID = std::stoi(work.id);
			}
			FILE_CONTENT += line;
			FILE_CONTENT += L'\n';
		}
		file.close();
		return true;
	}
	return false;
}



bool saveFile()
{
	std::wofstream file("data.txt");
	file.imbue(std::locale("Russian"));
	file << FILE_CONTENT;
	file.close();
	return true;
}



bool addWorker(Worker pNewWorker)
{
	loadFile();
	lastID++;
	pNewWorker.id = std::to_wstring(lastID);
	FILE_CONTENT += WorkerToLine(pNewWorker);
	FILE_CONTENT += L'\n';
	saveFile();
	return true;
}



bool getWorker(int pID, Worker& pWorker)
{
 	loadFile();
	
	size_t currentPos = 0;
	size_t lastPos = -1;
	currentPos = FILE_CONTENT.find('\n', lastPos + 1);
	std::wstring line = FILE_CONTENT.substr(lastPos + 1, currentPos - lastPos - 1);
	while (line.size() != 0) {
		Worker worker = lineToWorker(line);
		if (std::stoi(worker.id) == pID) {
			pWorker = worker;
			return true;
		}
		lastPos = currentPos;
		currentPos = FILE_CONTENT.find('\n', lastPos + 1);
		line = FILE_CONTENT.substr(lastPos + 1, currentPos - lastPos - 1);
	}

 	return false;
}

bool setWorker(int pID, Worker pWorker)
{
	loadFile();

	size_t currentPos = 0;
	size_t lastPos = -1;
	currentPos = FILE_CONTENT.find('\n', lastPos + 1);
	std::wstring line = FILE_CONTENT.substr(lastPos + 1, currentPos - lastPos - 1);
	while (line.size() != 0) {
		Worker worker = lineToWorker(line);
		if (std::stoi(worker.id) == pID) {
			pWorker.id = std::to_wstring(pID);
			std::wstring newLine = WorkerToLine(pWorker) + L"\n";
			FILE_CONTENT.replace(lastPos + 1, line.size() + 1, newLine);
			saveFile();
			return true;
		}
		lastPos = currentPos;
		currentPos = FILE_CONTENT.find('\n', lastPos + 1);
		line = FILE_CONTENT.substr(lastPos + 1, currentPos - lastPos - 1);
	}

	return false;
}

bool mark(int pID)
{
	loadFile();
	Worker worker;
	if (!getWorker(pID, worker))
	{
		return false;
	}
	worker.marked = L"1";
	setWorker(pID, worker);
	return true;
}

bool unmark(int pID)
{
	loadFile();
	Worker worker;
	if (!getWorker(pID, worker))
	{
		return false;
	}
	worker.marked = L"0";
	setWorker(pID, worker);
	return true;
}

bool deleteMarked()
{
	loadFile();

	size_t currentPos = 0;
	size_t lastPos = -1;
	currentPos = FILE_CONTENT.find('\n', lastPos + 1);
	std::wstring line = FILE_CONTENT.substr(lastPos + 1, currentPos - lastPos - 1);
	while (line.size() != 0) {
		Worker worker = lineToWorker(line);
		if (worker.marked == L"1") {
			FILE_CONTENT.replace(lastPos + 1, line.size() + 1, L"");
		}
		if (currentPos > FILE_CONTENT.length()) {
			break;
		}
		lastPos = currentPos;
		currentPos = FILE_CONTENT.find('\n', lastPos + 1);
		line = FILE_CONTENT.substr(lastPos + 1, currentPos - lastPos - 1);
	}
	saveFile();

	return false;
}

std::wstring getStringEB()
{
	std::wstring result;
	loadFile();
	result = FILE_CONTENT;

	loadFile();

	size_t currentPos = 0;
	size_t lastPos = -1;
	currentPos = result.find('\n', lastPos + 1);
	while (currentPos != std::wstring::npos) {
		result.replace(currentPos, 1, L"\r\n");
		lastPos = currentPos + 1;
		currentPos = result.find('\n', lastPos + 1);
	}

	return result;
}

long bidthdayToAge(std::wstring pBirthday)
{
	size_t pos = pBirthday.find(L'.');
	int day = 0;
	int mounth = 0;
	int year = 0;
	if (pos != std::wstring::npos) {
		day = std::stoi(pBirthday.substr(0, pos));
	}
	size_t lastPos = pos;

	pos = pBirthday.find(L'.', lastPos + 1);
	if (pos != std::wstring::npos) {
		mounth = std::stoi(pBirthday.substr(lastPos + 1, pos));
	}
	lastPos = pos;

	pos = pBirthday.find(L'.', lastPos);
	if (pos != std::wstring::npos) {
		year = std::stoi(pBirthday.substr(lastPos + 1, pos));
	}
	lastPos = pos;

	return day + mounth * 30 + year * 365;
}

void sort(Worker* pWorkers, int pCount)
{
	bool swap = true;
	while (swap) {
		swap = false;
		for (int i = 0; i < (pCount - 1); i++) {
			long currentAge = bidthdayToAge(pWorkers[i].birthday);
			long nextAge = bidthdayToAge(pWorkers[i + 1].birthday);
			if (currentAge < nextAge) {
				Worker temp = pWorkers[i];
				pWorkers[i] = pWorkers[i + 1];
				pWorkers[i + 1] = temp;
				swap = true;
			}
		}
	}
}


std::wstring query(int pBrig)
{
	std::wstring result;

	loadFile();

	int count = 0;
	
	Worker* workers = new Worker[1024];

	size_t currentPos = 0;
	size_t lastPos = -1;
	currentPos = FILE_CONTENT.find('\n', lastPos + 1);
	std::wstring line = FILE_CONTENT.substr(lastPos + 1, currentPos - lastPos - 1);
	while (line.size() != 0) {
		Worker worker = lineToWorker(line);
		if (std::stoi(worker.brig) == pBrig) {
			workers[count] = worker;
			count++;
		}
		lastPos = currentPos;
		currentPos = FILE_CONTENT.find('\n', lastPos + 1);
		line = FILE_CONTENT.substr(lastPos + 1, currentPos - lastPos - 1);
	}

	sort(workers, count);
	result = L"БРИГАДА № " + workers[0].brig + L"\r\n";
	result += L"Самые молодые:\r\n";
	for (int i = 0; (i < count) && (i < 3); i++) {
		result += WorkerToLine(workers[i]);
		result += L"\r\n";
	}

	result += L"Самые старые:\r\n";
	for (int i = count - 3; ((i < count) &&(i >=0)); i++) {
		result += WorkerToLine(workers[i]);
		result += L"\r\n";
	}

	return result;
}


INT_PTR CALLBACK getIDCallBack(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
	UNREFERENCED_PARAMETER(lParam);
	switch (message)
	{
	case WM_INITDIALOG:
		{
			CenterWnd(hDlg, GetParent(hDlg));
		}
		return (INT_PTR)TRUE;

	case WM_COMMAND:
		if (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL)
		{
			HWND editHWND = GetDlgItem(hDlg, IDC_EDIT1);
			WCHAR buffer[256];
			GetWindowText(editHWND, (LPWSTR)&buffer, 256);
			
			try {
				int id = std::stoi(std::wstring(buffer));
				if (getWorker(id, gCurrentWorker)) {
					DialogBox(gHInstance, MAKEINTRESOURCE(IDD_DIALOG2), hDlg, editCallBack);
				}
			}
			catch (std::exception ex){
				MessageBox(hDlg, _T("Запись не найдена."), _T("Сообщение"), MB_ICONINFORMATION);
			}

			EndDialog(hDlg, LOWORD(wParam));
			return (INT_PTR)TRUE;
		}
		break;
	}
	return (INT_PTR)FALSE;
}



INT_PTR CALLBACK editCallBack(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
	UNREFERENCED_PARAMETER(lParam);
	switch (message)
	{
	case WM_INITDIALOG:
		{
			CenterWnd(hDlg, GetParent(hDlg));

			HWND ctrlHWND = GetDlgItem(hDlg, IDC_ID);
			SetWindowText(ctrlHWND, gCurrentWorker.id.c_str());

			ctrlHWND = GetDlgItem(hDlg, IDC_NAME);
			SetWindowText(ctrlHWND, gCurrentWorker.name.c_str());

			ctrlHWND = GetDlgItem(hDlg, IDC_BIRTH);
			SetWindowText(ctrlHWND, gCurrentWorker.birthday.c_str());

			ctrlHWND = GetDlgItem(hDlg, IDC_BRIG);
			SetWindowText(ctrlHWND, gCurrentWorker.brig.c_str());

			ctrlHWND = GetDlgItem(hDlg, IDC_SPEC);
			SetWindowText(ctrlHWND, gCurrentWorker.specialty.c_str());

			ctrlHWND = GetDlgItem(hDlg, IDC_SALARY);
			SetWindowText(ctrlHWND, gCurrentWorker.salary.c_str());

			ctrlHWND = GetDlgItem(hDlg, IDC_DELETE);
			int marked = std::stoi(gCurrentWorker.marked);
			PostMessage(ctrlHWND, BM_SETCHECK, (marked) ? BST_CHECKED : BST_UNCHECKED, 1);

			return (INT_PTR)TRUE;
		}

	case WM_COMMAND:
		switch (LOWORD(wParam))
		{
		case IDOK:
			{
				int id = std::stoi(gCurrentWorker.id);

				WCHAR buffer[256];
				HWND ctrlHWND = GetDlgItem(hDlg, IDC_NAME);
				GetWindowText(ctrlHWND, (LPWSTR)&buffer, 256);
				gCurrentWorker.name = buffer;

				ctrlHWND = GetDlgItem(hDlg, IDC_BIRTH);
				GetWindowText(ctrlHWND, (LPWSTR)&buffer, 256);
				gCurrentWorker.birthday = buffer;

				ctrlHWND = GetDlgItem(hDlg, IDC_BRIG);
				GetWindowText(ctrlHWND, (LPWSTR)&buffer, 256);
				gCurrentWorker.brig = buffer;

				ctrlHWND = GetDlgItem(hDlg, IDC_SPEC);
				GetWindowText(ctrlHWND, (LPWSTR)&buffer, 256);
				gCurrentWorker.specialty = buffer;

				ctrlHWND = GetDlgItem(hDlg, IDC_SALARY);
				GetWindowText(ctrlHWND, (LPWSTR)&buffer, 256);
				gCurrentWorker.salary = buffer;

				ctrlHWND = GetDlgItem(hDlg, IDC_DELETE);
				int marked = SendMessage(ctrlHWND, BM_GETCHECK, 0, 0);
				gCurrentWorker.marked = std::to_wstring(marked);

				setWorker(id, gCurrentWorker);
			}
		case IDCANCEL:
			EndDialog(hDlg, LOWORD(wParam));
			return (INT_PTR)TRUE;
			break;
		default:
			break;
		}
		if (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL)
		{
		}
		break;
	}
	return (INT_PTR)FALSE;
}



INT_PTR CALLBACK getBrigCallBack(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
	UNREFERENCED_PARAMETER(lParam);
	switch (message)
	{
	case WM_INITDIALOG:
	{
		CenterWnd(hDlg, GetParent(hDlg));
	}
	return (INT_PTR)TRUE;

	case WM_COMMAND:
		if (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL)
		{
			HWND editHWND = GetDlgItem(hDlg, IDC_EDIT1);
			WCHAR buffer[256];
			GetWindowText(editHWND, (LPWSTR)&buffer, 256);

			try {
				int brig = std::stoi(std::wstring(buffer));
				gResult = query(brig);
				DialogBox(gHInstance, MAKEINTRESOURCE(IDD_FORMVIEW1), hDlg, resultCallBack);
			}
			catch (std::exception ex) {
				MessageBox(hDlg, _T("Запись не найдена."), _T("Сообщение"), MB_ICONINFORMATION);
			}

			EndDialog(hDlg, LOWORD(wParam));
			return (INT_PTR)TRUE;
		}
		break;
	}
	return (INT_PTR)FALSE;
}



INT_PTR CALLBACK resultCallBack(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
	UNREFERENCED_PARAMETER(lParam);
	switch (message)
	{
	case WM_INITDIALOG:
	{
		CenterWnd(hDlg, GetParent(hDlg));
		HWND ctrlHWND = GetDlgItem(hDlg, IDC_RESULT);
		SetWindowText(ctrlHWND, gResult.c_str());

		ctrlHWND = GetDlgItem(hDlg, IDOK);
		SetFocus(NULL);
	}
	return (INT_PTR)TRUE;

	case WM_COMMAND:
		if (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL)
		{
			EndDialog(hDlg, LOWORD(wParam));
			return (INT_PTR)TRUE;
		}
		break;
	}
	return (INT_PTR)FALSE;
}