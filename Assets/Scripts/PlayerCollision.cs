using TMPro;
using UnityEngine;

using System;

public class PlayerCollision : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == "ScoreSphere") {
            scoreText.text = (Int32.Parse(scoreText.text) + 1).ToString();
            Destroy(collision.gameObject);
        }

        if (collision.collider.tag == "ObstacleCube") {
            GetComponent<PlayerControls>().enabled = false;
            FindObjectOfType<GameManager>().LoseGame();
        }

        if (collision.collider.tag == "WinningCube") {
            GetComponent<PlayerControls>().enabled = false;
            FindObjectOfType<GameManager>().WinGame();
        }
    }
}
