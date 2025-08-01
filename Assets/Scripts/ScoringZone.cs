using UnityEngine;
using TMPro; 

public class ScoringZone : MonoBehaviour
{
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI computerScoreText;

    private int playerScore = 0;
    private int computerScore = 0;

    public void AddPlayerScore()
    {
        playerScore++;
        UpdateScoreUI();
    }

    public void AddComputerScore()
    {
        computerScore++;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        playerScoreText.text = playerScore.ToString();
        computerScoreText.text = computerScore.ToString();
    }
}