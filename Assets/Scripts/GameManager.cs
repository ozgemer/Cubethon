using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public void EndGame()
    {
        if (!gameEnded)
        {
            Debug.Log("Game Over");
            this.gameEnded = true;
            Invoke("RestartGame", restartDelay);
        }
    }

    public void RestartGame()
    {
        gameEnded = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteGame()
    {
        if (!gameEnded)
        {
            this.gameEnded = true;
            completeLevelUI.SetActive(true);
            Invoke("LoadCredits", 2f);
        }
    }
    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
