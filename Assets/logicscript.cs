using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicscript : MonoBehaviour
{
    public int playScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    [ContextMenu("Increase score")]
    public void addScore(int scoreToAdd)
    {
        playScore = playScore + scoreToAdd;
        scoreText.text = playScore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

}
