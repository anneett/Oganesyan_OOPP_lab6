#pragma once

#include "pch.h"

template <typename T>
T GetCorrectData(T min, T max)
{
	T x;
	while ((cin >> x).fail() || (cin).peek() != '\n' || x < min || x > max)
	{
		cin.clear();
		cin.ignore(100000, '\n');
		cout << "\n¬ведите корректные данные! ¬ведите число от " << min << " до " << max << ": ";
	}
	return x;
}