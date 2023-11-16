using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{

  int score = 50;
  int hits = 0;

  // Everytime the player hits something, reduce the score by 1
  private void OnCollisionEnter(Collision other) {
    if (!other.gameObject.CompareTag("Hit") && !other.gameObject.CompareTag("Finish")) {
      hits++;
      score--;
      Debug.Log("Hit Object! New Score: " + score);
    }

    if (other.gameObject.CompareTag("Finish")) {
      Debug.Log("Game Finished. FINAL SCORE: " + score + ". TOTAL HITS: " + hits);
    }
  }
}
