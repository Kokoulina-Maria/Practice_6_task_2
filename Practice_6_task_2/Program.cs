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

        static void Main(string[] args)
        {
            Console.WriteLine("Программа, генерирующая последовательность ак = а(к–2) / а(к-1) + |а(к–3)|");
            Console.WriteLine("a1, a2, a3 - первые элементы последовательности, M - нижняя грань (все элементы больше M), N - максимальное количество элементов в последовательности (N>0).");
            do
            {
                double a1 = ReadDouble("a1");
                double a2 = ReadDouble("a2");
                double a3 = ReadDouble("a3");
                double M = ReadDouble("M");
                int N = ReadInt("N");
                Console.ReadLine();
            } while (true);
        }
    }
}
