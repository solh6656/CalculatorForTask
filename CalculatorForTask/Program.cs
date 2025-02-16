using System;
class Program
{
    static void Main()
    {
        #region Basic. Ketma-ketlik boʻlimi uchun 2-amaliy vazifa
        //Task_1
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

        //Task_2
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

        //Task_3
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

        #region Basic. Ketma-ketlik boʻlimi uchun 3-amaliy vazifa
        TubSonTekshirish();
        BoluvchilarniTopish();
        DarajaHisoblash();
        HarajatlarToplami();
        ArmstrongSonTekshirish();
        SifatliBoluvchilarHisoblash();
        #endregion
    }

    #region Basic. Ketma-ketlik boʻlimi uchun 3-amaliy vazifa
    static void TubSonTekshirish()
    {
        Console.Write("Tub sonni tekshirish uchun butun son kiriting: ");
        if (int.TryParse(Console.ReadLine(), out int son))
        {
            Console.WriteLine(IsPrime(son) ? "Tub" : "Tub emas");
        }
    }

    static void BoluvchilarniTopish()
    {
        Console.Write("Bo'luvchilarni topish uchun son kiriting: ");
        if (int.TryParse(Console.ReadLine(), out int son))
        {
            Console.Write("Bo'luvchilari: ");
            for (int i = 2; i <= 10; i++)
            {
                if (son % i == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }

    static void DarajaHisoblash()
    {
        Console.Write("Sonni kiriting: ");
        if (int.TryParse(Console.ReadLine(), out int son))
        {
            Console.Write("Darajani kiriting: ");
            if (int.TryParse(Console.ReadLine(), out int daraja) && daraja > 0)
            {
                Console.WriteLine($"Natija: {Math.Pow(son, daraja)}");
            }
        }
    }

    static void HarajatlarToplami()
    {
        Console.Write("Harajatlar sonini kiriting: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Qiymatni kiriting: ");
                if (int.TryParse(Console.ReadLine(), out int qiymat))
                {
                    sum += qiymat;
                }
            }
            Console.WriteLine($"Yig'indi: {sum}");
        }
    }

    static void ArmstrongSonTekshirish()
    {
        Console.Write("Armstrong son tekshirish uchun son kiriting: ");
        if (int.TryParse(Console.ReadLine(), out int son))
        {
            Console.WriteLine(IsArmstrong(son) ? $"{son} Armstrong son" : $"{son} Armstrong son emas");
        }
    }

    static void SifatliBoluvchilarHisoblash()
    {
        Console.Write("Sifatli bo'luvchilarni hisoblash uchun son kiriting: ");
        if (int.TryParse(Console.ReadLine(), out int son))
        {
            int sifatliBoluvchilar = CountQualityDivisors(son);
            Console.WriteLine($"Sifatli bo'luvchilar soni: {sifatliBoluvchilar}");
        }
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    static bool IsArmstrong(int num)
    {
        int sum = 0, temp = num, length = num.ToString().Length;
        while (temp > 0)
        {
            int digit = temp % 10;
            sum += (int)Math.Pow(digit, length);
            temp /= 10;
        }
        return sum == num;
    }

    static int CountQualityDivisors(int num)
    {
        int count = 0;
        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
                count++;
        }
        return count;
    }
    #endregion
}
