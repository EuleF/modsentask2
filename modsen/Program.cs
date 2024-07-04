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
            crocodiles.PrintCrocodiles();
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
            
            crocodiles.PrintCrocodileLength(lenInt);
            break;
        case "3":
            crocodiles.PrintOldCrocodile();
            break;
        case "4":
            crocodiles.PrintHaviestCrocodile();
            break;
        default:
            Console.WriteLine("Incorrect value!");
            break;
    }
}

internal class Crocodile
{
    private string _name;
    private uint _weight, _length, _age;
    private char _gender;

    public Crocodile(string name, uint weight, uint length, uint age, char gender)
    {
        (_name, _weight, _length, _age, _gender) = (name, weight, length, age, gender);
    }

    public override string ToString()
    {
        return "Name: " + _name + " Weight: " + _weight + " Length: " + _length + " Age: " + _age + " Gender: " + _gender;
    }
    
    public uint GetLength()
    {
        return _length;
    }

    public uint GetAge()
    {
        return _age;
    }

    public uint GetWeigth()
    {
        return _weight;
    }
}

class CrocodileService
{
    private List<object> _list = new ();

    public void AddCrocodile(string name, uint weight, uint length, uint age, char gender)
    {
        _list.Add(new Crocodile(name, weight, length, age, gender));
    }

    public void PrintCrocodiles()
    {
        foreach (Crocodile croc in _list)
        {
            Console.WriteLine(croc.ToString());
        }
    }

    public void PrintCrocodileLength(uint length)
    {
        foreach (Crocodile croc in _list)
        {
            if (croc.GetLength() > length)
            {
                Console.WriteLine(croc.ToString());
            }
        }
    }

    public void PrintOldCrocodile()
    {
        uint maxAge = 0;
        Crocodile oldCroc = new Crocodile("0", 0, 0, 0, '0');
        
        foreach (Crocodile croc in _list)
        {
            if (croc.GetAge() > maxAge)
            {
                maxAge = croc.GetAge();
                oldCroc = croc;
            }
        }
        
        Console.WriteLine(oldCroc.ToString());
    }

    public void PrintHaviestCrocodile()
    {
        uint maxWeigth = 0;
        Crocodile haviestCroc = new Crocodile("0", 0, 0, 0, '0');
        
        foreach (Crocodile croc in _list)
        {
            if (croc.GetWeigth() > maxWeigth)
            {
                maxWeigth = croc.GetWeigth();
                haviestCroc = croc;
            }
        }
        
        Console.WriteLine(haviestCroc.ToString());
    }
}