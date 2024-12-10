using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class TestGameManager : MonoBehaviour
{
    public BaseCreature player;

    private void Start()
    {
        // Simulate taking damage
        player.TakeDamage(20);

        // Simulate healing
        player.Heal(10);

        // Simulate adding a buff
        var buffManager = player.GetComponent<BuffManager>();
        Buff attackBuff = new Buff("Attack Boost", "Attack", 5, 10);
        buffManager.AddBuff(attackBuff);

        Debug.Log($"New Attack Value: {player.AttributeManager.GetAttribute("Attack").Value}");


        // Create materials
        BaseMaterial wood = new BaseMaterial("Wood", 10, 5, 2);
        BaseMaterial stone = new BaseMaterial("Stone", 20, 15, 5);
        BaseMaterial metal = new BaseMaterial("Metal", 50, 30, 10);

        // Create WeaponFactory
        BaseWeaponFactory factory = new BaseWeaponFactory();

        // Add recipes
        factory.AddRecipe("Stone Axe", new List<BaseMaterial> { wood, stone });
        factory.AddRecipe("Iron Sword", new List<BaseMaterial> { wood, metal });
        factory.AddRecipe("Metal Hammer", new List<BaseMaterial> { metal, metal });

        // Create weapons
        BaseWeapon stoneAxe = factory.CreateWeapon("Stone Axe");
        BaseWeapon ironSword = factory.CreateWeapon("Iron Sword");
        BaseWeapon metalHammer = factory.CreateWeapon("Metal Hammer");

        // Display weapon details
        Debug.Log(stoneAxe);
        Debug.Log(ironSword);
        Debug.Log(metalHammer);
    }
}
