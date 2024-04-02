using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEngine : MonoBehaviour
{
    void Start()
    {

       
    }

    void Update()
    {
        transform.Translate(0, 12 * Time.deltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            GameManger.score += 10;
        }
    }
}