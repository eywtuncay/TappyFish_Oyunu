using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static Vector2 buttonLeft;
    public static bool gameOver;
    public GameObject gameOverPanel;
    public GameObject GetReady;
    public static int gameScore;
    public GameObject score;

    public static bool gameStarted;

    private void Awake()
    {
        buttonLeft = Camera.main.ScreenToViewportPoint(new Vector2(0, 0));
    }

    public void RestartBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        gameStarted = false;
    }

    public void GameHasStarted()
    {
        gameStarted = true;
        GetReady.SetActive(false);
    }

    public void GameOver()
    {
        gameOver=true;
        gameOverPanel.SetActive(true);
        score.SetActive(false);
        gameScore = score.GetComponent<Score>().GetScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
