using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovmentFunc : MonoBehaviour
{
    public float speed;
    float xPos;
    float yPos;
    public GameObject FirePrefab;

    void Start()
    {
        speed = 10;
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x + xPos * speed * Time.deltaTime, transform.position.y + yPos * speed * Time.deltaTime);
    }

    public void PlayerMovementFunc(string direction)
    {
        if (direction == "Right" && transform.position.x < 7.9f)
        {
            xPos = 1;
            yPos = 0;
        }
        if (direction == "Left" && transform.position.x > -7.54f)
        {
            xPos = -1;
            yPos = 0;
        }
        if (direction == "Up" && transform.position.y < 3.8f)
        {
            xPos = 0;
            yPos = 1;
        }
        if (direction == "Down" && transform.position.y > -3.67f)
        {
            xPos = 0;
            yPos = -1;
        }
        if (direction == "Stop")
        {
            xPos = 0;
            yPos = 0;
        }
    }

    public void PlayerShooting(string press)
    {
        if (press == "Yes")
        {
           Instantiate(FirePrefab, transform.position, transform.rotation);
           Destroy(FirePrefab, 2);
        }
    }
}
