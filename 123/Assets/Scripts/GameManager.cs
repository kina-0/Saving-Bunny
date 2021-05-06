using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    bool gameOver = false;
    int score=0;
    public Text S_text;
    public Text GameOverPanel_text;
    public GameObject gameOverPanel;
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
    }

    public void GameOver()
    {
        gameOver = true;
        GameObject.Find("EnemySpawn").GetComponent<EnemySpawn>().StopSpawning();
        //taking access of EnemySpawn script bcz from that script we are going to used existing function.
        gameOverPanel.SetActive(true);

    }


    public void Score()
    {
        if(!gameOver)
        {
            score = score + 10;
            //print(score);
            S_text.text = score.ToString();
            GameOverPanel_text.text = "Score: " + score;
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("GameScene");
    }



}
