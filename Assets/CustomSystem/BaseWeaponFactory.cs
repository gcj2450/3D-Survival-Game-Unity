using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 武器工厂类
/// </summary>
public class BaseWeaponFactory
{
    private Dictionary<string, List<BaseMaterial>> _recipes = new Dictionary<string, List<BaseMaterial>>();

    public void AddRecipe(string weaponName, List<BaseMaterial> materials)
    {
        if (!_recipes.ContainsKey(weaponName))
            _recipes[weaponName] = materials;
    }

    public BaseWeapon CreateWeapon(string weaponName)
    {
        if (!_recipes.ContainsKey(weaponName))
            throw new System.Exception("No such weapon recipe!");

        return new BaseWeapon(weaponName, _recipes[weaponName]);
    }
}
