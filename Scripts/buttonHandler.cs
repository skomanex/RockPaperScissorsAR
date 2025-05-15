using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonHandler : MonoBehaviour
{
    public playerManager playerManager;
    public combatManager combatManager;

    public void OnRockButtonClick()
    {
        playerManager.SetPlayerChoice("rock");
        combatManager.PlayGame();
    }

    public void OnPaperButtonClick()
    {
        playerManager.SetPlayerChoice("paper");
        combatManager.PlayGame();
    }

    public void OnScissorsButtonClick()
    {
        playerManager.SetPlayerChoice("scissors");
        combatManager.PlayGame();
    }

}
