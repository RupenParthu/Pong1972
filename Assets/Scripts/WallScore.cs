using UnityEngine;

public class WallScore : MonoBehaviour
{
    public ScoringZone scoringZone;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (gameObject.CompareTag("PlayerGoal"))
            {
                scoringZone.AddPlayerScore();

            }
            else if (gameObject.CompareTag("CompGoal"))
            {
                scoringZone.AddComputerScore();
            }
        }
        other.GetComponent<BallBehavior>().ballreset();
    }
}
