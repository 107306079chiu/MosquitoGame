using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Button restartButton;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (score==100){
            Time.timeScale = 0;
            GameOver();
        }
    }

    public void addScore(int n){
        score += n;
        scoreText.text = "HP " + score;
    }

    public void dead(){
        score = 0;
        scoreText.text = "HP " + score;        
    }

    public void GameOver(){
        restartButton.gameObject.SetActive(true);    
    }

    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
