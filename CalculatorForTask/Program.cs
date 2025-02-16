using System;
class Program
{
    static void Main()
    {
        #region Task_1
        Console.Write("Birinchi sonni kiriting: ");
        if (double.TryParse(Console.ReadLine(), out double son1))
        {
            Console.Write("Amalni kiriting (+, -, *, /): ");
            char amal = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Ikkinchi sonni kiriting: ");
            if (double.TryParse(Console.ReadLine(), out double son2))
            {
                double natija = 0;
                bool valid = true;

                switch (amal)
                {
                    case '+':
                        natija = son1 + son2;
                        break;
                    case '-':
                        natija = son1 - son2;
                        break;
                    case '*':
                        natija = son1 * son2;
                        break;
                    case '/':
                        if (son2 != 0)
                            natija = son1 / son2;
                        else
                        {
                            Console.WriteLine("Xatolik: 0 ga bo'lib bo'lmaydi.");
                            valid = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Noto'g'ri amal kiritildi.");
                        valid = false;
                        break;
                }

                if (valid)
                    Console.WriteLine($"Natija: {natija}");
            }
            else
            {
                Console.WriteLine("Noto'g'ri ikkinchi son kiritildi.");
            }
        }
        else
        {
            Console.WriteLine("Noto'g'ri birinchi son kiritildi.");
        }
        #endregion

        #region Task_2
        Console.Write("N musbat butun sonni kiriting: ");
        if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
        {
            int yigindi = (N * (N + 1)) / 2;
            Console.WriteLine($"Yig'indi: {yigindi}");
        }
        else
        {
            Console.WriteLine("Noto'g'ri qiymat kiritildi. Iltimos, musbat butun son kiriting.");
        }
        #endregion

        #region Task_3
        Console.Write("Butun son kiriting: ");
        if (int.TryParse(Console.ReadLine(), out int son))
        {
            if (son % 2 == 0)
                Console.WriteLine("Juft");
            else
                Console.WriteLine("Toq");
        }
        else
        {
            Console.WriteLine("Noto'g'ri qiymat kiritildi. Iltimos, butun son kiriting.");
        }
        #endregion

    }
}
