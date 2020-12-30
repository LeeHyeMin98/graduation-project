using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    [SerializeField]
    private float startSpeed = 1;

    [SerializeField]
    private Rigidbody2D objectRigidobody2d;

    // Use this for initialization
    void Start()
    {
        float randomX, randomY;
        randomX = Random.Range(-1.0f, 1.0f);
        randomY = Random.Range(-1.0f, 1.0f);

        Vector2 vector2 = new Vector2(randomX, randomY);
        vector2 = vector2.normalized;

        objectRigidobody2d.AddForce(vector2 * startSpeed);
    }
}