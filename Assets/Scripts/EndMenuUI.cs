using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndMenuUI : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text highestScoreText;
    void Start()
    {
        
    }
    void Update()
    {
        scoreText.text = "Score: " + GameManger.score.ToString();
        highestScoreText.text = "Highest Score: " + GameManger.highScore.ToString();
    }
    public void TryAgainButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
