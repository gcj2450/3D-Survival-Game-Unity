using System.Collections.Generic;
using System;

/// <summary>
/// 属性管理器
/// </summary>
public class EntityAttributeManager
{
    private Dictionary<string, EntityAttribute> _attributes = new Dictionary<string, EntityAttribute>();

    public void AddAttribute(string name, float baseValue)
    {
        if (!_attributes.ContainsKey(name))
            _attributes[name] = new EntityAttribute(name, baseValue);
    }

    public EntityAttribute GetAttribute(string name)
    {
        return _attributes.TryGetValue(name, out var attribute) ? attribute : null;
    }

    public void ModifyAttribute(string name, float value)
    {
        if (_attributes.ContainsKey(name))
            _attributes[name].AddModifier(value);
    }
}
