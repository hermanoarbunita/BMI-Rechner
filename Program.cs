Console.WriteLine("Wir rechnen jetzt deinen BMI aus");
Console.WriteLine();

Console.WriteLine("Zuerst brauchen wir dein Alter!");
Console.WriteLine();
Console.WriteLine("Gib dein Alter jetzt ein");
string inputAge = Console.ReadLine();
double age = double.Parse(inputAge);

if (age < 18)
{
    Console.WriteLine("Du must mindestens 18 Jahre alt sein");
    return;
}

Console.WriteLine();
Console.WriteLine("Jetzt brauchen wir dein Gewicht");
Console.WriteLine();
Console.WriteLine("Gib dein Gewicht jetzt ein");
string inputWeight = Console.ReadLine();
double weight = double.Parse(inputWeight);

if (weight < 45)
    {
        Console.WriteLine("Zu kleines Gewicht");
    return;
    }
else if (weight > 220)
    {
        Console.WriteLine("Zu hohes Gewicht");
    return;
    }

Console.WriteLine();
Console.WriteLine("Jetzt brauchen wir noch deine Grösse");
Console.WriteLine("");
Console.WriteLine("Gib jetzt deine Grösse in m (z.B. 1.75) an");
string inputHeight = Console.ReadLine();
double height = double.Parse(inputHeight);

if (height < 1.45)
{
    Console.WriteLine("Du bist zu klein");
}
else if (height > 2.20)
{
    Console.WriteLine("Du bist zu gross");
}

Console.WriteLine();
Console.WriteLine("So, jetzt haben wir alle Werte, die wir brauchen. Jetzt werden wir mit der passenden Formel deinen BMI berechnen");


double bmi = (weight / Math.Pow(height, 2));

string rating;
if (bmi < 18.5)
{
    rating = "Untergewicht";
}
else if (bmi > 25)
{
    rating = "Übergewicht";
}
else if (bmi > 30)
{
    rating = "Adipositas";
}
else
{
    rating = "Normal";
}

Console.WriteLine();
Console.WriteLine($"Dein BMI beträgt {bmi:F2}. Gemäss BMI-Tabelle ist das {rating}.");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine();

