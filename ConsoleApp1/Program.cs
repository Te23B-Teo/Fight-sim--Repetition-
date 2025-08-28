static void Fight()
{

    int p1Hp = 100;
    int p2Hp = 100;

    string p1Name = "Elis";
    string p2Name = "Oscar";
    bool running = true;
    while (running)
    {
        Console.WriteLine($"{p1Name}: {p1Hp} HP");
        Console.WriteLine($"{p2Name}: {p2Hp} HP");
        p2Hp -= Random.Shared.Next(10, 25);
        p1Hp -= Random.Shared.Next(10, 25);
        Console.WriteLine("Press Enter to continue or type 'exit' to quit.");
        string loop = Console.ReadLine();
        Console.Clear();
        if (loop == "exit" || p1Hp <= 0 || p2Hp <= 0)
        {
            if (p1Hp <= 0 && p2Hp <= 0)
            {
                Console.WriteLine("It's a draw!");
            }
            else if (p1Hp <= 0)
            {
                Console.WriteLine($"{p2Name} wins! With {p2Hp}HP kvar.");
            }
            else if (p2Hp <= 0)
            {
                Console.WriteLine($"{p1Name} wins! With {p1Hp}HP kvar.");
            }
            Console.WriteLine("Press Enter to restart or Write exit to quit.");
            string con = Console.ReadLine();
            Console.Clear();
            if (con == "exit")
            {
                running = false;
            }
            else
            {
                p1Hp = 100;
                p2Hp = 100;
            }
        }
    }
}

Fight();