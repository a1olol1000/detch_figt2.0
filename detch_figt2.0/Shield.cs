
namespace detch_figt2._0;

public class Shield
{
    public string shieldName = "shieldname";
    public int maxBlock = 20;
    public int minBlock = 1;
    public Random generation;
    
    public Shield()
    {
        generation = new();
    }
    public int GetBlock()
    {
        return generation.Next(minBlock,maxBlock);
    }
}
