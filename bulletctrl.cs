using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletctrl : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll) {
        Destroy(this.gameObject);
    }
}
