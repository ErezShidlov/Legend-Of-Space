using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMenuUI : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
