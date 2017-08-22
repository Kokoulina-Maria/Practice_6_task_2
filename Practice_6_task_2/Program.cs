using System;

namespace Practice_6_task_2
{
    class Program
    {
        static double ReadDouble(string msg)
        {// Ввод вещественного числа с проверкой
            double number; bool ok;// переменная для проверки
            do
            {
                Console.Write("Введите число "+msg+": ");
                ok = double.TryParse(Console.ReadLine(), out number);
                if (!ok) Console.WriteLine("Неверный ввод!");
            } while (!ok);// конец проверки
            return (number);
        }

        static int ReadInt(string msg)
        {// Ввод натурального числа с проверкой
            int number; bool ok;// переменная для проверки
            do
            {
                Console.Write("Введите число N: ");
                ok = int.TryParse(Console.ReadLine(), out number);
                if ((!ok)|| (number<=0)) Console.WriteLine("Неверный ввод! N должно быть натуральным!");
                if ((ok) && (number <= 0)) ok = false;
            } while (!ok);// конец проверки
            return (number);
        }
        static double A(double a1, double a2, double a3, int i)
        {//рекурсивная функция для нахождения элемента последовательности
            double ak;//Нынешний элемент последовательности
            if (i == 1) ak = a1;
            else if (i == 2) ak = a2;
            else if (i == 3) ak = a3;
            else ak = A(a1, a2, a3, i - 2) / A(a1, a2, a3, i - 1) + A(a1, a2, a3, i - 3);//находим нынешний элемент последовательности
            return (ak);//возвращаем нынешний элемент последовательности
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа, генерирующая последовательность ак = а(к–2) / а(к-1) + |а(к–3)|");
            Console.WriteLine("a1, a2, a3 - первые элементы последовательности, M - нижняя грань (все элементы больше M), N - максимальное количество элементов в последовательности (N>=0).");
            do
            {
                //ввод данных
                double a1 = ReadDouble("a1");
                double a2 = ReadDouble("a2");
                double a3 = ReadDouble("a3");
                double M = ReadDouble("M");
                int N = ReadInt("N");

                Console.WriteLine("ОТВЕТ: ");
                if (M >= a1) Console.WriteLine("Последовательность пуста, так как " + M + ">=" + a1);
                else
                {
                    int i;//номер элемента
                    double ak = 0;//элемент
                    Console.Write("Последовательность: ");
                    for (i=1; i<=N; i++)//находим и перебираем N элементов
                    {
                        ak = A(a1, a2, a3, i);//находим элемент
                        if (ak > M) Console.Write(ak + " ");//если элемент больше M, выводим его
                        else break;//иначе прекращаем строить последовательность
                    }
                    Console.WriteLine();
                    Console.Write("Причина останова: ");
                    if (i == N+1) Console.WriteLine("В последовательности " + N + " элементов");
                    else Console.WriteLine(ak + "<=" + M);
                }                
                Console.ReadLine();
            } while (true);
        }
    }
}
