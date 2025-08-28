static void FightSim()
{
    bool programRunning = true;
    while (programRunning)
    {
        string p1Name = "";
        string p2Name = "Oscar";
        while (true)
        {
            Console.WriteLine("Antal spelare 1 eller 2?");
            string players = Console.ReadLine();
            Console.Clear();
            if (players == "1")
            {
                Console.WriteLine("Skriv ditt namn:");
                p1Name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Du spelar mot Oscar.");
                break;
            }
            else if (players == "2")
            {
                Console.WriteLine("Skriv spelare 1:");
                p1Name = Console.ReadLine();
                Console.WriteLine("Skriv spelare 2:");
                p2Name = Console.ReadLine();
                Console.Clear();
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Felaktigt val, försök igen.");
                Thread.Sleep(1500);
                Console.Clear();
            }
        }

        int p1Hp = 100, p2Hp = 100;
        while (p1Hp >= 0 && p2Hp >= 0)
        {
            int p1 = Random.Shared.Next(10, 25);
            int p2 = Random.Shared.Next(10, 25);
            p2Hp -= p1;
            p1Hp -= p2;
            Console.WriteLine($"{p1Name}: {p1Hp} HP | Made {p1} Damage!");
            Console.WriteLine($"{p2Name}: {p2Hp} HP | Made {p2} Damage!");
            if (p1Hp <= 0 || p2Hp <= 0)
            {
                p1Hp = 0;
                p2Hp = 0;
                break;
            }
            Console.ReadLine();
            Console.Clear();
        }
        Console.Clear();
        // svar
        if (p1Hp <= 0 && p2Hp <= 0)
            Console.WriteLine("Oavgjort!");
        else if (p1Hp <= 0)
            Console.WriteLine($"{p2Name} vinner med {p2Hp} HP kvar!");
        else
            Console.WriteLine($"{p1Name} vinner med {p1Hp} HP kvar!");

        // Spela igen?
        Console.WriteLine("Tryck Enter för att spela igen eller skriv 'exit' för att avsluta.");
        string again = Console.ReadLine();
        if (again.ToLower() == "exit")
            programRunning = false;
        Console.Clear();
    }
}

FightSim();
