using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Арифметическая прогрессия");
            ArithProgression p = new ArithProgression(1, 2);
            p.SetStart(2);
            Console.WriteLine("Начало 2, шаг 2, следующее значение: {0}", p.GetNext());
            p.Reset();
            p.SetStep(5);
            Console.WriteLine("Сброс к 2, шаг 5 следующее значение: {0}", p.GetNext());;

            Console.WriteLine("Геометрическая прогрессия");
            GeomProgression g = new GeomProgression(1, 2);
            g.SetStart(2);
            Console.WriteLine("Начало 2, коэффициент 2, следующее значение: {0}", g.GetNext());
            g.Reset();
            g.SetK(5);
            Console.WriteLine("Сброс к 2, коэффициент 5 следующее значение: {0}", g.GetNext());
            Console.ReadKey();
        }
    }
}
