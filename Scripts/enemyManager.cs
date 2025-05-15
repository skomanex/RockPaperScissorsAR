using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour
{
    public string choice { get; private set; }

    public void SetComputerChoice()
    {
        List<string> choices = new List<string> { "rock", "paper", "scissors" };
        choice = choices[Random.Range(0, choices.Count)];
    }
}
