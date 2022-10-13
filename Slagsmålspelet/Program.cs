Random generator = new Random();

int dudeHp= 50;
int boyHp= 50;
int dudeDamage;
int boyDamage;



Console.WriteLine(dudeHp> 0 && boyHp > 0);


string dude ="dude";
string boy  = "boy";

while (dudeHp > 0 && boyHp > 0)
{
    Console.WriteLine($"dude: {dudeHp} boy {boyHp}:\n");
    boyDamage = generator.Next(10);
    dudeHp -= boyDamage;
    Console.WriteLine($"boy deals {boyDamage} on {dudeHp} ");

    dudeDamage = generator.Next(10);
    boyHp = dudeDamage;
    Console.WriteLine($" dude deals {dudeDamage} on {boyHp}  ");
    break;



    Console.ReadKey();
}

if (dudeHp == 0 && boyHp == 0)
{
   Console.WriteLine("You both suck!");
}
else if (boyHp == 0)
{
    Console.WriteLine("The dude won!");
}
else if (dudeHp == 0)
{
    Console.WriteLine("Good boy you won!");
}

Console.ReadLine();
