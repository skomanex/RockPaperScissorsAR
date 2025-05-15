using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
    public string choice { get; private set; }

    public void SetPlayerChoice(string playerChoice)
    {
        choice = playerChoice;
    }
}
