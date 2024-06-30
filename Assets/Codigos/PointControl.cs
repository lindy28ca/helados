using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointControl : MonoBehaviour
{
    public GameObject NexPoint;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag== "enemigo")
        {
            collision.gameObject.GetComponent<EnemyControl>().LLenar(NexPoint);
        }
        if (collision.gameObject.tag == "zandia")
        {
            collision.gameObject.GetComponent<Zandia>().LLenar(NexPoint);
        }
    }
}
