using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение температуры: ");
        string input = Console.ReadLine();
        double t = Double.Parse(input);
        do
        {
            Console.WriteLine("Введите тип шкалы: ");
            input = Console.ReadLine();
        } while (!input.Equals("F") && !input.Equals("f") && !input.Equals("C") && !input.Equals("c"));
        Console.WriteLine("Результат: " + Math.Round(CandF.Convert.CtoFandFtoC(t, input), 2));
    }
}