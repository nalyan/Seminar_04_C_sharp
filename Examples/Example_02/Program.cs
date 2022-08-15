// Написать программу преобразования десятичного числа в двоичное
int ToBinar(int value){
    int binar = 0;
    int i = 0;
    while(value >= 1){
        binar = binar + value % 2 * (int)Math.Pow(10, i);
        Console.WriteLine(binar);
        value = value / 2;
        i++;
    }
    return binar;
}
Console.Clear();
int value = int.Parse(Console.ReadLine());
Console.WriteLine(ToBinar(value));
