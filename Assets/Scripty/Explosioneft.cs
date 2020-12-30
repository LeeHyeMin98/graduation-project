using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosioneft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("destroy", 0.7f);
    }
    void destroy() {
        Destroy(this.gameObject);
    }
}
