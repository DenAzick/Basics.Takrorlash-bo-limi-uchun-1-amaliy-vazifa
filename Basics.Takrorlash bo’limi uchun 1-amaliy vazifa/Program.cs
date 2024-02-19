

Console.WriteLine("1. 1 dan 1000 gacha bo’lgan toq sonlarni yig’indisini ekranga chiqaradigan dastur tuzing. While loop dan foydalaning!");

int summ = 0;

//for (int i = 1; i <= 1000; i++)
//{
//    if (i % 2 == 1)
//    {
//        summ += i;
//    }
//}
int i = 0;

while (i <= 1000)
{
    if (i % 2 == 1)
    {
        summ += i;
    }
    i++;
}

Console.WriteLine(summ);


Console.WriteLine("/////////////////////////////////////////////////////////////////////////");


Console.WriteLine("2. Array ichidagi eng katta va eng kichik qiymatlarni ko’paytmasini ekranga chiqaradigan dastur tuzing. For loop dan foydalaning!");


Console.Write("yaratmoqchi bo'lgan listni uzunligini kiriting: ");

while (true)
{
    int lenght = Convert.ToInt32(Console.ReadLine());
    if (lenght == 1)
    {
        Console.WriteLine("iltimos listning uzunligini 1 dan kattaroq son tanlang!!!");
        continue;
    }
    MaxMin(lenght);
    break;
}




void MaxMin(int lenght)
{
    double[] arr = new double[lenght];

    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write($"{j + 1}. ");
        var element = Convert.ToDouble(Console.ReadLine());
        //bool isNum = int.TryParse(element, out element);
        arr[j] = element;

    }
    var minNumber = arr[0];
    var maxNumber = arr[0];

    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] < minNumber)
        {
            minNumber = arr[j];
        }

        if (arr[j] > maxNumber)
        {
            maxNumber = arr[j];
        }
    }

    Console.WriteLine(minNumber * maxNumber);
}




//Console.WriteLine(arr.Min() * arr.Max());

Console.WriteLine("/////////////////////////////////////////////////////////////////////////");

Console.WriteLine("3. Consolga int tipidagi butun son kiritilgan => int x x! (x factorial) ni hisoblaydigan dastur tuzing");


Console.Write("faktorial raqmini kiriting: ");

int num = Convert.ToInt32(Console.ReadLine());
int faktorial = 1;

for (int j = 1; j <= num; j++)
{
    faktorial *= j;
}
Console.WriteLine(faktorial);