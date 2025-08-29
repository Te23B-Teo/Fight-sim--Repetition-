static void FightSim()
{
    bool programRunning = true;
    while (programRunning)
    {
        int skada = 10;
        int skada2 = 25;
        int pengar = 100;
        string p1Name = "";
        string[] names = ["Anna", "Bertil", "Cecilia", "David", "Eva", "Fredrik", "Gunilla", "Hans", "Ingrid", "Johan"];
        string p2Name = names[Random.Shared.Next(names.Length)];
        int players = 1;

        while (true)
        {
            Console.WriteLine("Antal spelare 1 eller 2?");
            if (!int.TryParse(Console.ReadLine(), out players))
            {
                Console.Clear();
                Console.WriteLine("Felaktigt val, försök igen.");
                Thread.Sleep(1500);
                Console.Clear();
                continue;
            }
            Console.Clear();
            if (players == 1)
            {
                Console.WriteLine("Skriv ditt namn:");
                p1Name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Du spelar mot {p2Name}.");
                Console.WriteLine("skriv fusk om du vill fuska annars tryck enter");
                string fusk = Console.ReadLine();
                if (fusk.ToLower() == "fusk")
                {
                    skada = 40;
                    skada2 = 50;
                    break;
                }
                else
                {
                    break;
                }
            }
            else if (players == 2)
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
            int p1 = Random.Shared.Next(skada, skada2);
            int p2 = Random.Shared.Next(10, 25);
            p2Hp -= p1;
            p1Hp -= p2;
            if (players == 1 && p1Hp <= 0)
            // if (p1Hp <= 0)
            {
                Console.Clear();
                Console.WriteLine("Du Dog du kan köpa mer liv om du vill fortsätta betala 20 för 20 HP mer eller 40 för 50 HP mer!");
                Console.Write("SKRIV 20 ELLER 40: ");
                Console.WriteLine($"du har {pengar}kr kvar");
                string liv = Console.ReadLine();
                if (liv == "20" && pengar >= 20)
                {
                    p1Hp += 20;
                    pengar -= 20;
                    Console.Clear();
                    Console.WriteLine($"Du köpte 20 HP för 20 kr du har nu {pengar}kr pengar kvar");
                }
                else if (liv == "40" && pengar >= 40)
                {
                    p1Hp += 50;
                    pengar -= 40;
                    Console.Clear();
                    Console.WriteLine($"Du köpte 50 HP för 40 pengar du har nu {pengar}kr pengar kvar");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Du har inte råd eller så skrev du fel, du dog!");
                    p1Hp = 0;
                }
            }
            Console.WriteLine($"{p1Name}: {p1Hp} HP | Made {p1} Damage!");
            Console.WriteLine($"{p2Name}: {p2Hp} HP | Made {p2} Damage!");
            if (p1Hp <= 0 || p2Hp <= 0)
            {
                break;
            }
            Console.ReadLine();
            Console.Clear();
        }
        Console.Clear();
        // svar
               if (p1Hp <= 0 && p2Hp <= 0)
        {
            if (p1Hp == p2Hp)
                Console.WriteLine("Oavgjort!");
        }
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
