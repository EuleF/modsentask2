namespace modsen;

class CrocodileService
{
    private List<object> _list = new ();

    public void AddCrocodile(string name, uint weight, uint length, uint age, char gender)
    {
        _list.Add(new Crocodile(name, weight, length, age, gender));
    }

    public List<Crocodile> Crocodiles()
    {
        List<Crocodile> list = new List<Crocodile>();
        foreach (Crocodile croc in _list)
        {
            list.Add(croc);
        }

        return list;
    }

    public Crocodile CrocodileLength(uint length)
    {
        foreach (Crocodile croc in _list)
        {
            if (croc._length > length)
            {
                return croc;
            }
        }

        return null;
    }

    public Crocodile OldCrocodile()
    {
        uint maxAge = 0;
        Crocodile oldCroc = new Crocodile("0", 0, 0, 0, '0');
        
        foreach (Crocodile croc in _list)
        {
            if (croc._age > maxAge)
            {
                maxAge = croc._age;
                oldCroc = croc;
            }
        }
        
        return oldCroc;
    }

    public Crocodile HaviestCrocodile()
    {
        uint maxWeigth = 0;
        Crocodile haviestCroc = new Crocodile("0", 0, 0, 0, '0');
        
        foreach (Crocodile croc in _list)
        {
            if (croc._weight > maxWeigth)
            {
                maxWeigth = croc._weight;
                haviestCroc = croc;
            }
        }
        
        return haviestCroc;
    }
}