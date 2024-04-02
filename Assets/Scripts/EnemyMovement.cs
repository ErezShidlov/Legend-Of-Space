using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Transform playerTransform;
    float enemySpeed;
    void Start()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
        enemySpeed = 5;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, enemySpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
