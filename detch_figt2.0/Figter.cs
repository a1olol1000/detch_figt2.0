namespace detch_figt2._0;

public class Figter
{
    public string name = "name";
    public Wapon wapon;
    public float hp = 100;
    public void Attack(Figter target)
    {
        int damage = wapon.GetDamage();
        target.hp -= damage;
        target.hp = Math.Max(0, target.hp);
        Console.WriteLine($"{name}deals:{damage} damage to {target.name}.");
    }
}