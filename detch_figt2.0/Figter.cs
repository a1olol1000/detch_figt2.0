namespace detch_figt2._0;

public class Figter
{
    public string name = "name";
    public Wapon wapon;
    public Shield Shield;
    public float hp = 100;
    public float shielding = 0;
    public void Attack(Figter target)
    {
        int damage = wapon.GetDamage();
        float blockedDamage =target.shielding;
        target.shielding -= damage;
        if (target.shielding<0)
        {
            target.hp += target.shielding;
        }
        target.hp = Math.Max(0, target.hp);
        Console.WriteLine($"{name}deals:{damage} damage to {target.name} using {wapon.waponName}.");
        Console.WriteLine($"{target.name} Shields: {blockedDamage} damage leaving {target.name} with: {target.hp} Health");
        if (target.shielding<0)
        {
            target.shielding =0;
        }
    }
    public void Block(Figter target)
    {
        int blocking = Shield.GetBlock();
        target.shielding += blocking;
        Console.WriteLine($"{target.name} uses {target.Shield.shieldName} to block: {target.shielding} Damage");
    }
}