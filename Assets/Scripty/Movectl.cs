using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movectl : MonoBehaviour
{
    public Transform tr;
    public float speed = 10f;
    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.CompareTag("DESTROYER"))
        {
            Destroy(this.gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        tr.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
