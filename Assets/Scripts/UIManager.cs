using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject firstHeart;
    public GameObject secondHeart;
    public GameObject thirdHeart;
    public TMP_Text scoreText;
    void Start()
    {
        
    }

    void Update()
    {
        if (GameManger.hp == 2)
        {
            firstHeart.SetActive(false);
        }
        else if (GameManger.hp == 1)
        {
            secondHeart.SetActive(false);
        }
        else if (GameManger.hp == 0)
        {
            SceneManager.LoadScene("EndMenu");
        }
        scoreText.text = "Score: " + GameManger.score.ToString();
    }
}
