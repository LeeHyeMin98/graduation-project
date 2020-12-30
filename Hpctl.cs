using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hpctl : MonoBehaviour
{
    private int hp=5;

    public Rigidbody2D rb;

    public Text HpText;





    // Start is called before the first frame update
    void Start()
    {
        HpText.text = "Hp:" + 5;
       // rb= GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame

        void OnTriggerEnter2D(Collider2D coll)
        {
            if (coll.CompareTag("ENEMY"))
            {
                hp = hp - 1;
                HpText.text = "Hp:" + hp;
            if (hp < 0) hp = 0;
            }
        
        }
    

}


