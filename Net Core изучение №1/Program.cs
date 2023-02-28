// See https://aka.ms/new-console-template for more information



int[,] NewArray = new int[3, 5]
    {
        {55,11,254,18,15 },
        {448,548,252,18,1 },
        {47,87,98,36,21 },
};
Console.WriteLine("Значение массива по Y");
int Number = int.Parse(Console.ReadLine());
Console.WriteLine("Значение массива по Х");
int TwoNumber = int.Parse(Console.ReadLine());
for (int i = 0; i < NewArray.Length; i++)
{
    if (Number == i)
    {
        Console.WriteLine(NewArray[Number, TwoNumber]);
    }
}
