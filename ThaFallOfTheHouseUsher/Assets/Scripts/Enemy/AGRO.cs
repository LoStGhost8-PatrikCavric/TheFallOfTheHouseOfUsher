using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AGRO : MonoBehaviour
{
    public Transform player;
    public Rigidbody2D rb;
    public float agroRange;
    public float speed;

    void Start()
    {

    }

    void Update()
    {
        float distance = Vector2.Distance(this.transform.position, player.transform.position);
        if (distance <= agroRange)
        {
            ChasePlayer();
        }
        else
        {
            StopChasing();
        }
    }
    public void ChasePlayer()
    {
        if (transform.position.x < player.transform.position.x)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (transform.position.y < player.transform.position.y)
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        else
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
    }
    public void StopChasing()
    {
        transform.Translate(0, 0, 0);
    }
}
