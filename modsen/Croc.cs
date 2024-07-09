namespace modsen;

class Crocodile
{
    private string Name;
    private uint Weight, Length, Age;
    private char Gender;
    
    public string _name
    {
        get { return Name; }
        private set { Name = value; }
    }

    public uint _weight
    {
        get { return Weight; }
        private set { Weight = value; }
    }
    
    public uint _length 
    {
        get { return Length; }
        private set { Length = value; }
    }
    
    public uint _age
    {
        get { return Age; }
        private set { Age = value; }
    }
    
    public char _gender
    {   
        get { return Gender; }
        private set { Gender = value; }
    }

    public Crocodile(string name, uint weight, uint length, uint age, char gender)
    {
        (_name, _weight, _length, _age, _gender) = (name, weight, length, age, gender);
    }

    public override string ToString()
    {
        return "Name: " + _name + " Weight: " + _weight + " Length: " + _length + " Age: " + _age + " Gender: " + _gender;
    }
}