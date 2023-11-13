using detch_figt2._0;

Figter figter1 = new();
figter1.name = "manemanet";
figter1.wapon = new();
figter1.wapon.waponName = "antimagnet";
figter1.Shield = new();
figter1.Shield.shieldName = "manetfält";
int coice1 = 0;

Figter figter2 = new();
figter2.name = "mangemagnet";
figter2.wapon = new();
figter2.wapon.waponName = "turtel";
figter2.Shield = new();
figter2.Shield.shieldName = "magnetfält";
int coice2 = 0;
while (figter1.hp>0&&figter2.hp>0)
{
    coice2 = figter2.wapon.generation.Next(1,20);
    ChangeColor("red");
    if (coice2 > 15)
    {
        figter2.Block(figter2);
    }
    if (coice2<15)
    {
        Console.WriteLine($"{figter2.name}coses to attack");
    }
    ChangeColor("");
    Console.WriteLine("Chose what to do 1 attack or 2 defend");
    while (coice1 ==0)
    {
        string inpat = Console.ReadLine();
        int result =0;
        Int32.TryParse(inpat, out result);
        coice1 =  result;
        if (coice1 == 0)
        {
            Console.WriteLine("You must write 1 or 2");
        }
    }
    ChangeColor("green");
    if (coice1==2)
    {
        figter1.Block(figter1);
    }
    ChangeColor("red");
    if (coice2 <15)
    {
        figter2.Attack(figter1);
    }
    ChangeColor("green");
    if (figter1.hp>0)
    {
        if (coice1 == 1)
        {
            figter1.Attack(figter2);
        }
    }
    ChangeColor("");
    coice1 =0;
    Console.ReadLine();
    Console.Clear();
}

if (figter1.hp>0)
{
    ChangeColor("green");
    Console.WriteLine($"{figter1.name} Won hurra!");
}
else if (figter2.hp>0)
{
    ChangeColor("red");
    Console.WriteLine($"{figter2.name} Won hurra!");
}
Console.ReadLine();

void ChangeColor(string color)
{
    if (color == "green")
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    else if (color == "red")
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
    }
}