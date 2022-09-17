using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class StringList
    {
        public string[] list = new string[100];

        public int Insert(string str, int palce)
        {
            int k = list.Where(v => v != null).ToArray().Length;
            if (k < 100)
            {

                for (int i = k; i > palce; i--)
                {
                    list[i] = list[i - 1];
                }

                list[palce] = str;

                return 1;
            }
            else
                return -1;
        }

        public void Delite(int a)
        {
            if (list[a] != null && a < 100)
                list[a] = null;            
        }

        public int Search(string str)
        {
            int k = list.Where(v => v != null).ToArray().Length;
            int t = -1;
            for (int i = 0; i < k; i++)
                if (list[i] == str)
                    t = i;
            return t;
        }

        public void Update(int a, string str)
        {
            if (list[a] != null && a < 100)
                list[a] = str;
        }

        public string GetAt(int a)
        {
            string t = " ";
            if (list[a] != null && a < 100)
                t = list[a];
            return t;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======Заполните список строк (не более чем 100 строками). Чтобы прекратить добавление списков введите -1======");

            //Ввод элементов списка
            StringList str = new StringList();
            string tmp = "";
            int t = 0;
            while (tmp != "-1")
            {
                tmp = Console.ReadLine();
                if (tmp != "-1")
                {
                    str.list[t] = tmp;
                    t++;
                }
            }

            Console.WriteLine("======Для начала работы над списком введите любое число, кроме -1======");

            int num = Convert.ToInt32(Console.ReadLine());

            while (num != -1) {
                Console.WriteLine("======Вы можете взаимодействовать со списком следующими способами====== \n 1. Добавть элемент на нужную позтцию " +
               "\n 2. Удалить элемент \n 3. Найти место положение нужного элемента в списке \n 4. Заменить элемент в списке" +
               "\n 5. Найти узнать содержимое ечейки списка по номеру \n 6. Вывести список");

                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Введите строку, которую хотите добавить:");
                        string a = Console.ReadLine();
                        Console.WriteLine("Введите позицию, в которую хотите добавить строку:");
                        int b = Convert.ToInt32(Console.ReadLine());
                        str.Insert(a, b);
                        break;

                    case 2:
                        Console.WriteLine("Введите позицию элемента, который хотите удалить:");
                        int c = Convert.ToInt32(Console.ReadLine()); 
                        str.Delite(c);
                        break;

                    case 3:
                        Console.WriteLine("Введите строку, которую хотите найти:");
                        string d = Console.ReadLine();
                        Console.WriteLine("Искомая позиция:");
                        Console.WriteLine(str.Search(d));
                        break;

                    case 4:
                        Console.WriteLine("Введите позицию, которую хотите изменить:");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите строку, которую хотите добавить:");
                        int f = Convert.ToInt32(Console.ReadLine());
                        str.Update(0, "Hi");
                        break;

                    case 5:
                        Console.WriteLine("Введите позицию, которую хотите найти:");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Искомая строка:");
                        Console.WriteLine(str.GetAt(3));
                        break;

                    case 6:
                        Console.WriteLine("Ваш список: ");

                        int k = str.list.Where(v => v != null).ToArray().Length;

                        for (int i = 0; i < str.list.Length; i++)
                            Console.WriteLine(str.list[i]);

                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
