using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firee : MonoBehaviour
{
    public GameObject[] pos;
    public GameObject bullet;

    public float ab = 0.2f; //총알나가는속도
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 1.0f, ab);
    }

    // Update is called once per frame
    void Update()
    {
       // Fire();
    }
    void Fire() {
        for (int i = 0; i < pos.Length; i++) {
            Instantiate(bullet, pos[i].transform.position, pos[i].transform.rotation);
    }
    }
}
