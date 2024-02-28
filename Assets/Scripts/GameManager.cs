using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    private bool isScreenBlack = false;
    public UnityEngine.Camera playerCamera;
    public TextMeshProUGUI youDiedText;
    public TextMeshProUGUI youWonText;

    public void WinGame() {
        if (!gameHasEnded) {
            EndGame();
            youWonText.text = "рш ондеахк";
            Invoke("Restart", 5f);
        }
    }

    public void LoseGame() {
        if (!gameHasEnded) {
            EndGame();
            youDiedText.text = "рш онлеп";
            Invoke("Restart", 5f);
        }
    }

    public void EndGame() {
        gameHasEnded = true;
        if (!isScreenBlack) {
            isScreenBlack = true;
            playerCamera.clearFlags = CameraClearFlags.SolidColor;
            playerCamera.backgroundColor = Color.black;
        }
        foreach (GameObject o in GameObject.FindGameObjectsWithTag("ObstacleCube")) {
            o.SetActive(false);
        }
        foreach (GameObject o in GameObject.FindGameObjectsWithTag("ScoreSphere")) {
            o.SetActive(false);
        }
        GameObject.FindGameObjectWithTag("Ground").SetActive(false);
        GameObject.FindGameObjectWithTag("Player").SetActive(false);
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
