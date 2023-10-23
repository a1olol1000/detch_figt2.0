namespace detch_figt2._0;

public class Wapon
{
    public string waponName= "waponName";
    public int maxDamage = 20;
    public int minDamage = 2;
    public Random generation;

    public Wapon()
    {
        generation = new();
    }
    public int GetDamage()
    {
        return generation.Next(minDamage,maxDamage);
    }
}