using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public float health;
    // Use this for initialization
    void Start()
    {
        health = 100f;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("Hurt :(");
            health -= 1f;
            Destroy(collision.gameObject);
        }
    }
}