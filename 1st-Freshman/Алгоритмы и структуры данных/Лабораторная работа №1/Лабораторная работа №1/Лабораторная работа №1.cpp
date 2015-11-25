// ������������ ������ �1.cpp: ���������� ����� ����� ��� ����������� ����������.
//

#include "stdafx.h"
#include <Windows.h>
#include <string>
#include <iostream>

using namespace std;


int _tmain(int argc, _TCHAR* argv[])
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	cout << "����������, ������� ������: ";
	string stroka;
	getline(cin, stroka, '\n');
	cout << "����������, ������� ������� �����: ";
	string obraz;
	getline(cin, obraz, '\n');

	int d[256]; //������� ��������
	int len = obraz.length();
	int lenStroka = stroka.length();

	for (int i = 0; i < 256; i++) //��������� ������� �������� ������ ������
		d[i] = len;

	for (int i = 0; i < len; i++)
	{
		char currSym = obraz[len - 1 - i]; //���� �� ������ ������ �� ����
		
		if (d[(int)currSym] == len) //���� � ������� �������� �� ������� ���� �������� ������� ������ �������� ����� ������ (���� ������ ��� �� ����������)
		{
			d[(int)currSym] = len - (len - i); //����� ���������� �� ��� ����� ���������� �� �������� ������� ������ �� ����� ������
		}
	}

	int countRepeat = 1;
	for (int i = 1; i < len; i++) //�������� �� �������� ������ �� ������������
	{
		
		if (obraz[i] == obraz[i - 1])
			countRepeat++;
		if (countRepeat == len) //���� ������ ������� ������ �� ���������� ��������, 
			for (int j = 0; j < 256; j++) //��������� ������� �������� ���������, ��� �� ���� ����������� ������ ���������� ������� � ������
				d[j] = 1;
	}
	/*
	for (int i = 0; i < 256; i++)
		cout << d[i] << " ";
	*/
	/*----------------------------------------------------------------------------------------------------------------------*/
	if (len && stroka.length())
	{
		int k, sm = 1, j = -1, n = 0;

		do
		{
			j += sm; //���������� �������� ������ �� ������
			k = 1; //��������� ���������� ��������� ���������
			while ((k <= len) && (obraz[len - k] == stroka[len - k + j]))
				k++;

			if (k - 1 != len)
			{
				sm = d[(int)stroka[len - k + j]]; //�������� �������� ������� ��������
				n++; //���������� �������� �������� (��� ���������� ������������� ���������)
			}
			else
			{
				cout << "������� ������� ���������: " << j + 1 << endl;
				cout << "���������� ��������: " << n << endl;
			}

		} while ((k - 1 != len) && (j < lenStroka - len));

		if (k - 1 != len)
			printf("����� �� ������\n"); //������ �� �������
	}
	else if (!len)
		cout << "����� �� ������" << endl;
	else
		cout << "������ �����" << endl;
	system("pause");
	return 0;
}