using UnityEngine;

/// <summary>
/// 角色类
/// </summary>
public class BaseCreature : MonoBehaviour
{
    public EntityAttributeManager AttributeManager { get; private set; }

    private void Awake()
    {
        AttributeManager = new EntityAttributeManager();
        AttributeManager.AddAttribute("Health", 100);
        AttributeManager.AddAttribute("Attack", 10);
        AttributeManager.AddAttribute("Defense", 5);
    }

    public void TakeDamage(float damage)
    {
        float defense = AttributeManager.GetAttribute("Defense").Value;
        float actualDamage = Mathf.Max(0, damage - defense);
        AttributeManager.ModifyAttribute("Health", -actualDamage);

        Debug.Log($"Took {actualDamage} damage, Health remaining: {AttributeManager.GetAttribute("Health").Value}");
    }

    public void Heal(float amount)
    {
        AttributeManager.ModifyAttribute("Health", amount);
        Debug.Log($"Healed {amount}, Health now: {AttributeManager.GetAttribute("Health").Value}");
    }
}
