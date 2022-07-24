namespace Human
{
    class Human
{
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;
    
    // add a public "getter" property to access health
    public int Health
    {
        get
        {
            return health;
        }
    }
    
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    public string humanName(string name)
    {
        Name = name;
        Strength = 100;
        Intelligence = 100;
        Dexterity = 100;
        health = 100;
    }
    // Add a constructor to assign custom values to all fields
    public Custom(string name, int strength, int intel, int dext, int heal)
    {
        Name = name;
        Strength = strength;
        Intelligence = intel;
        Dexterity = dext;
        health = heal;
    }
    // Build Attack method
    public int Attack(Human target)
    {
        target.health -= 5;
        return target.health;
    }
}



}