// Лабораторная работа №1.cpp: определяет точку входа для консольного приложения.
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

	cout << "Пожалуйста, введите строку: ";
	string stroka;
	getline(cin, stroka, '\n');
	cout << "Пожалуйста, введите искомый образ: ";
	string obraz;
	getline(cin, obraz, '\n');

	int d[256]; //Матрица смещения
	int len = obraz.length();
	int lenStroka = stroka.length();

	for (int i = 0; i < 256; i++) //Заполняем матрицу смещения длиной образа
		d[i] = len;

	for (int i = 0; i < len; i++)
	{
		char currSym = obraz[len - 1 - i]; //Идем по образу справа на лево
		
		if (d[(int)currSym] == len) //Если в матрице смещения на позиции кода текущего символа образа записана длина образа (этот символ еще не встречался)
		{
			d[(int)currSym] = len - (len - i); //тогда записываем на его место расстояние от текущего символа образа до конца образа
		}
	}

	int countRepeat = 1;
	for (int i = 1; i < len; i++) //Алгоритм по проверки образа на однородность
	{
		
		if (obraz[i] == obraz[i - 1])
			countRepeat++;
		if (countRepeat == len) //Если строка состоит только из одинаковых символов, 
			for (int j = 0; j < 256; j++) //Заполняем матрицу смещения единицами, это не даст возможность образу проскочить позицию в строке
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
			j += sm; //Определяет смещение образа по строке
			k = 1; //Определят количество совпавших элементов
			while ((k <= len) && (obraz[len - k] == stroka[len - k + j]))
				k++;

			if (k - 1 != len)
			{
				sm = d[(int)stroka[len - k + j]]; //Смещения согласно матрицы смещения
				n++; //Увеличение счетчика смещений (для вычисления эффективности алгоритма)
			}
			else
			{
				cout << "Позиция первого вхождения: " << j + 1 << endl;
				cout << "Количество смещений: " << n << endl;
			}

		} while ((k - 1 != len) && (j < lenStroka - len));

		if (k - 1 != len)
			printf("Образ не найден\n"); //Строка не найдена
	}
	else if (!len)
		cout << "Образ не введен" << endl;
	else
		cout << "Строка пуста" << endl;
	system("pause");
	return 0;
}