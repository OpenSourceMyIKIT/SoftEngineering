// Лабораторная работа №2.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <Windows.h>
#include <conio.h>
#include <iostream>
using namespace std;

void proverkaVvoda(int *vvod); //Функция проверки на введение целочисленного значения

int _tmain(int argc, _TCHAR* argv[])
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	int size;
	cout << "Введите размер массива: ";
	proverkaVvoda(&size);
	if (size)
	{
		int *a = new int[size];


		cout << "Заполните массив" << endl;
		for (int i = 0; i < size; i++)
		{
			cout << i + 1 << ". ";
			proverkaVvoda(&a[i]);
		}

		cout << "Нажмите любую клавишу для начала сортировки массива" << endl;
		_getch();

		for (int i = 1; i < size; i++) //Движение  по исходной части массива
		{
			int tmp = a[i];
			for (int j = 0; j <= i; j++) //Проверка готовой части массива на упорядоченность
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
		cout << "Массив успешно отсортирован" << endl;
		for (int i = 0; i < size; i++)
			cout << a[i] << " ";

		cout << endl;
	}
	else
		cout << "Неверно" << endl;
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