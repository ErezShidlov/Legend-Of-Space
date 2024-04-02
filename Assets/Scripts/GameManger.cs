using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public static int score;
    public static int highScore;
    public static int hp;
    void Start()
    {
        score = 0;
        hp = 3;
    }

    void Update()
    {
        if (highScore < score)
        {
            highScore = score;
        }
    }
}
