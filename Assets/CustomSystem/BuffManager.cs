using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

/// <summary>
/// Buff/Debuffϵͳ
/// </summary>
public class Buff
{
    public string Name { get; private set; }
    public float Duration { get; private set; }
    public float Modifier { get; private set; }
    public string TargetAttribute { get; private set; }

    public Buff(string name, string targetAttribute, float modifier, float duration)
    {
        Name = name;
        TargetAttribute = targetAttribute;
        Modifier = modifier;
        Duration = duration;
    }
}

public class BuffManager : MonoBehaviour
{
    private List<Buff> _activeBuffs = new List<Buff>();
    private BaseCreature _character;

    private void Start()
    {
        _character = GetComponent<BaseCreature>();
    }

    public void AddBuff(Buff buff)
    {
        _activeBuffs.Add(buff);
        _character.AttributeManager.ModifyAttribute(buff.TargetAttribute, buff.Modifier);
        StartCoroutine(RemoveBuffAfterDuration(buff));
    }

    private IEnumerator RemoveBuffAfterDuration(Buff buff)
    {
        yield return new WaitForSeconds(buff.Duration);
        _character.AttributeManager.ModifyAttribute(buff.TargetAttribute, -buff.Modifier);
        _activeBuffs.Remove(buff);
    }
}
