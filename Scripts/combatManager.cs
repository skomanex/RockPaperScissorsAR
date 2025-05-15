using UnityEngine;

public class combatManager : MonoBehaviour
{
    public playerManager playerManager;
    public enemyManager enemyManager;
    public characterStats playerStats;
    public characterStats enemyStats;

    public AudioClip winSound;
    public AudioClip loseSound;
    public AudioClip tieSound;

    public AudioSource audioSource;

    public void PlayGame()
    {
        enemyManager.SetComputerChoice();

        Debug.Log($"Player chose: {playerManager.choice}");
        Debug.Log($"Computer chose: {enemyManager.choice}");

        DetermineWinner();
    }

    private void DetermineWinner()
    {
        string playerChoice = playerManager.choice;
        string computerChoice = enemyManager.choice;

        if (playerChoice == computerChoice)
        {
            audioSource.PlayOneShot(tieSound);
            Debug.Log("It's a tie!");
        }
        else if ((playerChoice == "rock" && computerChoice == "scissors") ||
                 (playerChoice == "paper" && computerChoice == "rock") ||
                 (playerChoice == "scissors" && computerChoice == "paper"))
        {
            Debug.Log("Player wins!");
            audioSource.PlayOneShot(winSound);
            enemyStats.TakeTrueDamage(playerStats.attack);
        }
        else
        {
            Debug.Log("Computer wins!");
            audioSource.PlayOneShot(loseSound);
            playerStats.TakeTrueDamage(enemyStats.attack);
        }
    }
}

