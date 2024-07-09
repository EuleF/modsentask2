using  modsen;

CrocodileService crocodiles = new CrocodileService();
crocodiles.AddCrocodile("Anton", 100, 200, 5, 'M');
crocodiles.AddCrocodile("Steve", 150, 150, 2, 'M');
crocodiles.AddCrocodile("Anna", 200, 220, 3, 'F');
crocodiles.AddCrocodile("Kira", 120, 100, 1, 'F');


while (true)
{
    Console.WriteLine("""
                      1.Print crocodiles.
                      2.Print crocodiles longer than.
                      3.Print oldest crocodile.
                      4.Print heaviest crocodile.
                      """);
    var str = Console.ReadLine();
    
    Console.Clear();
    
    switch (str)
    {
        case "1":
            foreach (Crocodile croc in crocodiles.Crocodiles())
            {
                Console.WriteLine(croc.ToString());
            }
            break;
        case "2":
            uint lenInt;
            Console.Clear();
            while (true)
            {
               Console.Write("Input length crocodile: ");
               var len = Console.ReadLine();
                
                if (uint.TryParse(len, out lenInt))
                {
                    break;
                }
            }
            
            Console.WriteLine(crocodiles.CrocodileLength(lenInt).ToString());
            break;
        case "3":
            Console.WriteLine(crocodiles.OldCrocodile().ToString());
            break;
        case "4":
            Console.WriteLine(crocodiles.HaviestCrocodile().ToString());
            break;
        default:
            Console.WriteLine("Incorrect value!");
            break;
    }
}