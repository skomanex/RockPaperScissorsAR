using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterStats : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHP;
    public int attack;
    public int defense;

    void Start()
    {
        currentHP = maxHP;
    }

    public void TakeTrueDamage(int damage)
    {
        int damageTaken = damage;
        currentHP -= damageTaken;
        Debug.Log($"{gameObject.name} took {damageTaken} damage! Current HP: {currentHP}");
    }

    public void TakeReducedDamage(int damage)
    {
        int damageTaken = Mathf.Max(0, damage - defense);
        currentHP -= damageTaken;
        Debug.Log($"{gameObject.name} took {damageTaken} damage! Current HP: {currentHP}");
    }

    public void TakeHyperReducedDamage(int damage)
    {
        int damageTaken = Mathf.Max(0, damage - 2 * defense);
        currentHP -= damageTaken;
        Debug.Log($"{gameObject.name} took {damageTaken} damage! Current HP: {currentHP}");
    }
}
