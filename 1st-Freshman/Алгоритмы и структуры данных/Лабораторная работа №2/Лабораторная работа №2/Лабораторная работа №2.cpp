// ������������ ������ �2.cpp: ���������� ����� ����� ��� ����������� ����������.
//

#include "stdafx.h"
#include <Windows.h>
#include <conio.h>
#include <iostream>
using namespace std;

void proverkaVvoda(int *vvod); //������� �������� �� �������� �������������� ��������

int _tmain(int argc, _TCHAR* argv[])
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	int size;
	cout << "������� ������ �������: ";
	proverkaVvoda(&size);
	if (size)
	{
		int *a = new int[size];


		cout << "��������� ������" << endl;
		for (int i = 0; i < size; i++)
		{
			cout << i + 1 << ". ";
			proverkaVvoda(&a[i]);
		}

		cout << "������� ����� ������� ��� ������ ���������� �������" << endl;
		_getch();

		for (int i = 1; i < size; i++) //��������  �� �������� ����� �������
		{
			int tmp = a[i];
			for (int j = 0; j <= i; j++) //�������� ������� ����� ������� �� ���������������
			{
				if (tmp < a[j])
				{
					tmp = a[j];
					a[j] = a[i];
					a[i] = tmp;
				}
			}
		}

		system("cls");
		cout << "������ ������� ������������" << endl;
		for (int i = 0; i < size; i++)
			cout << a[i] << " ";

		cout << endl;
	}
	else
		cout << "�������" << endl;
	system("pause");
	return 0;
}

void proverkaVvoda(int *vvod)
{
	while (scanf_s("%d", vvod) != 1)
	{
		_flushall();
		printf("Error! Please, enter again: ");
	}
}