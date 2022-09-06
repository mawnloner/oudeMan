Boolean go = true;
int leeftijd;

while (go == true)
{
    Console.WriteLine("Hoe oud ben je???? (of stop de applicatie met 'stop'");
    string input = Console.ReadLine();
    if (input == "stop")
    {
        go = false;
    }
    else if (int.TryParse(input, out int value))
    {
        leeftijd = Int32.Parse(input);

        if (leeftijd < 0 || leeftijd > 130)
        {
            Console.WriteLine("liegenaar");
        }
        else if (leeftijd >= 0 && leeftijd <= 1)
        {
            Console.WriteLine("baby - justin beiber");
        }

        else if (leeftijd >= 2 && leeftijd <= 4)
        {
            Console.WriteLine("peutertjes zijn echt niet leuk");
        }

        else if (leeftijd >= 5 && leeftijd <= 6)
        {
            Console.WriteLine("je bent geupgrade naar een kleuter lets goo champ");
        }

        else if (leeftijd >= 7 && leeftijd <= 14)
        {
            Console.WriteLine("fakka kindje hoe gaat? (beantwoord dit maar niet schat)");
        }

        else if (leeftijd >= 15 && leeftijd <= 17)
        {
            Console.WriteLine("oh nee pubertje zit op snapchat daar houd ik nie vannnn");
        }

        else if (leeftijd >= 18 && leeftijd <= 21)
        {
            Console.WriteLine("oh nee pubertje zit op snapchat daar houd ik nie vannnn");
            Console.WriteLine("oh maar je mag wel zoomen in de auto als je een rijbewijsie heb");
        }

        else if (leeftijd >= 22 && leeftijd <= 70)
        {
            Console.WriteLine("je bent volwassene, dus betaal ff snel die energierekening");
            Console.WriteLine("oh en vergeet niet de benzinerekening, want je mag al auto rijden");
        }

        else if (leeftijd >= 71 && leeftijd <= 130)
        {
            Console.WriteLine("official bejaarde");
            Console.WriteLine("ja tante bejaarde ik zou niet meer autorijden op deze leeftijd, maar het mag nog wel");
        }
    }
    else
    {
        Console.WriteLine("invalide invoer, probeer opniew noob");
    }
}