// LibraryForStory.h
#include <iostream>
#pragma once

using namespace System;

namespace LibraryForStory {

	public ref class Sparrow
	{
		public:
			void Sparrow::Kill()
			{
				setlocale(LC_CTYPE, "rus");
				std::cout<< "���� � ������ ��������, ��� � ���� ��������. � ���� �� ���� �� ��������\n";
			}
				void Sparrow::Speak()
				{
					setlocale(LC_CTYPE, "rus");
					std::cout<< "� �������! �������� �� dll C++ \n";
				}
	};
}

