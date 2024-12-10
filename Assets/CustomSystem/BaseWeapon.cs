using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 武器类
/// </summary>
public class BaseWeapon
{
    public string Name { get; private set; }
    public List<BaseMaterial> Materials { get; private set; }
    public float AttackPower { get; private set; }
    public float Weight { get; private set; }
    public float Durability { get; private set; }

    public BaseWeapon(string name, List<BaseMaterial> materials)
    {
        Name = name;
        Materials = materials;

        CalculateAttributes();
    }

    private void CalculateAttributes()
    {
        AttackPower = 0;
        Weight = 0;
        Durability = 0;

        foreach (var material in Materials)
        {
            AttackPower += material.BaseAttack;
            Weight += material.Weight;
            Durability += material.Durability;
        }
    }

    public override string ToString()
    {
        return $"Weapon: {Name}, AttackPower: {AttackPower}, Weight: {Weight}, Durability: {Durability}";
    }
}
