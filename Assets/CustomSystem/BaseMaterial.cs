
/// <summary>
/// 原材料类
/// </summary>
public class BaseMaterial
{
    public string Name { get; private set; }
    public float Durability { get; private set; }
    public float Weight { get; private set; }
    public float BaseAttack { get; private set; }

    public BaseMaterial(string name, float durability, float weight, float baseAttack)
    {
        Name = name;
        Durability = durability;
        Weight = weight;
        BaseAttack = baseAttack;
    }
}
