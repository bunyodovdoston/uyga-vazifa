/*
class Program
{
    static void Main()
    {
*/
///1chi misol
/*
int[][] jaggedArray = new int[3][];

jaggedArray[0] = new int[] { 1, 2, 3 };
jaggedArray[1] = new int[] { 4, 5 };
jaggedArray[2] = new int[] { 6, 7, 8, 9 };

for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine();
}
}
*/
///2chi misol
/*
int[][] jaggedArray = new int[3][];

jaggedArray[0] = new int[] { 1, 2, 3 };
jaggedArray[1] = new int[] { 4, 5 };
jaggedArray[2] = new int[] { 6, 7, 8, 9 };

int sum = 0;

for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        sum += jaggedArray[i][j];
    }
}
Console.WriteLine(" yig'indi: " + sum);

}
*/
///3chi misol
/*  
    int[][] jaggedArray = new int[3][];

    jaggedArray[0] = new int[] { 1, 2, 3 };
    jaggedArray[1] = new int[] { 4, 5 };
    jaggedArray[2] = new int[] { 6, 7, 8, 9 };

    int max = jaggedArray[0][0]; 

    for (int i = 0; i < jaggedArray.Length; i++)
    {
        for (int j = 0; j < jaggedArray[i].Length; j++)
        {
            if (jaggedArray[i][j] > max)
            {
                max = jaggedArray[i][j];
            }
        }
    }
    Console.WriteLine("eng katta element: " + max);
}
*/
///4chi misol
/*
int[][] jaggedArray = new int[3][];

jaggedArray[0] = new int[] { 1, 2, 3 };
jaggedArray[1] = new int[] { 4, 5 };
jaggedArray[2] = new int[] { 6, 7, 8, 9 };

int min = jaggedArray[0][0];

for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        if (jaggedArray[i][j] < min)
        {
            min = jaggedArray[i][j];
        }
    }
}
Console.WriteLine("eng kichik element: " + min);
}
*/
///5chi misol
/*
    int[][] jaggedArray = new int[3][];

    jaggedArray[0] = new int[] { 1, 2, 3 };
    jaggedArray[1] = new int[] { 4, 5 };
    jaggedArray[2] = new int[] { 6, 7, 8, 9 };

    for (int i = 0; i < jaggedArray.Length; i++)
    {
        int quti = 0; 
        for (int j = 0; j < jaggedArray[i].Length; j++)
        {
            quti += jaggedArray[i][j];
        }
        Console.WriteLine( quti);
    }
}
*/
///6chi misol
/*
    int[][] jaggedArray = new int[3][];

    jaggedArray[0] = new int[] { 1, 2, 3, 4 };
    jaggedArray[1] = new int[] { 5, 6, 7, 8 };
    jaggedArray[2] = new int[] { 9, 10, 11, 12 };

    for (int i = 0; i < jaggedArray.Length; i++)
    {
        for (int j = 0; j < jaggedArray[i].Length; j++)
        {
            if (jaggedArray[i][j] % 2 == 0)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
        }
    }
}
*/
///7chi misol
/*
int[][] jaggedArray = new int[3][];

jaggedArray[0] = new int[] { 1, 2, 3, 4 };
jaggedArray[1] = new int[] { 5, 6, 7, 8 };
jaggedArray[2] = new int[] { 9, 10, 11, 12 };

for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        if (jaggedArray[i][j] % 2 != 0)
        {
            Console.Write(jaggedArray[i][j] + " ");
        }
    }
}
}
*/
///8chi misol
/*
    int[][] jaggedArray = new int[3][];

    jaggedArray[0] = new int[] { 1, 2, 3, 4 };
    jaggedArray[1] = new int[] { 5, 6, 7 };
    jaggedArray[2] = new int[] { 8, 9, 10, 11, 12 };

    for (int i = 0; i < jaggedArray.Length; i++)
    {
        Console.WriteLine( jaggedArray[i].Length);
    }
}
}
*/
class Bankomat
{
    double qwert = 0;
    private double hsobim = 1000000;
    private string parol = "4321";
    public void Login()
    {
        Console.Write("Parolni kiriting: ");
        string parol = Console.ReadLine();

        if (parol == parol)
        {
            Console.WriteLine("Tizimga kirdingiz!");
            hsob();
            pullar();
            chekchqarish();
        }

    }
    public void hsob()
    {
        Console.WriteLine($"balansingizda {hsobim} so'm.bor");
    }
    public void pullar()
    {
        Console.Write("\nQancha pul yechmoqchisiz? ");
        double pul = Convert.ToDouble(Console.ReadLine());

        if (pul <= hsobim)
        {
            hsobim = hsobim - pul;
            Console.WriteLine($"Siz {pul} so'm pul yechdingiz.");
            Console.WriteLine($"Yangi balans: {hsobim} so'm.");
            qwert = pul;
        }
        else
        {
            Console.WriteLine("Balansda yetarli mablag yo'q!");
        }
    }
    public void chekchqarish()
    {
        Console.WriteLine("chek");
        Console.WriteLine(DateTime.Now);
        Console.WriteLine($"{qwert}pul yechildi");
    }
}


class Program
{
    static void Main()
    {
        Bankomat bankomat = new Bankomat();
        bankomat.Login();
    }
}
















