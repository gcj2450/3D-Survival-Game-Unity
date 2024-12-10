using System;
using System.Collections.Generic;

/// <summary>
/// 属性基类
/// </summary>
public class EntityAttribute
{
    public string Name { get; private set; }
    public float BaseValue { get; private set; }
    private float _modifier;

    public EntityAttribute(string name, float baseValue)
    {
        Name = name;
        BaseValue = baseValue;
        _modifier = 0;
    }

    public float Value => BaseValue + _modifier;

    public void AddModifier(float value)
    {
        _modifier += value;
    }

    public void ResetModifier()
    {
        _modifier = 0;
    }
}
