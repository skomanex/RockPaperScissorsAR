using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeRender : MonoBehaviour
{
    public characterStats stats;
    public Renderer currentLifeRender; // Use Renderer to access the material color

    private void Start()
    {
        stats = gameObject.GetComponentInParent<characterStats>();
    }

    void Update()
    {
        float percentHP = (float)stats.currentHP / stats.maxHP;

        Color green = Color.green;
        Color yellow = Color.yellow;
        Color red = Color.red;

        if (percentHP > 0.5f)
        {
            currentLifeRender.material.color = Color.Lerp(yellow, green, (percentHP - 0.5f) * 2f);
        }
        else
        {
            currentLifeRender.material.color = Color.Lerp(red, yellow, percentHP * 2f);
        }
    }
}

