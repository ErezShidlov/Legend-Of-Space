using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovmentKeyboard : MonoBehaviour
{
    public float speed;
    float xPos;
    float yPos;
    public GameObject FirePrefab;
    public static float playerXpos;
    void Start()
    {
        speed = 10;
    }

    void Update()
    {
        playerXpos = transform.position.x;

        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 7.9f)
        {
            xPos = 1;
            yPos = 0;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -7.54f)
        {
            xPos = -1;
            yPos = 0;
        }
        else if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 3.8f)
        {
            xPos = 0;
            yPos = 1;
        }
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -3.67f)
        {
            xPos = 0;
            yPos = -1;
        }
        else
        {
            xPos = 0;
            yPos = 0;
        }
        transform.position = new Vector2(transform.position.x + xPos * speed * Time.deltaTime, transform.position.y + yPos * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(FirePrefab, transform.position, transform.rotation);
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameManger.hp -= 1;
            Destroy(collision.gameObject);

        }
    }
}
