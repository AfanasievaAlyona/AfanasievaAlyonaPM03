using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afanasieva03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Autos = new  int[];
            int n;
			cout << "Введите массив: " << n << endl;
			if (!n) 
			{
				cout << "Не введено число";
			}
			else 
			{
				int i = 0;
				write (n) 
				{
					cout << "Автомобиль " << i + 1 << endl;
					cout << "Марка " << i + 1 << n->mark << endl;
				cin >> Autos[i].mark;

				cout << "Модель " << i + 1 << n->model << endl;
				cin >> Autos[i].model;

				cout << "Цена " << i + 1 <<n-> cum << endl;
				cin >> Autos[i].cum;
				}
			}
        }
    }
}
