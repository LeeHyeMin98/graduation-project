using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerctl : MonoBehaviour
{
    public int hp = 5;
    public int initHp = 5;
    public Rigidbody2D rb;
    public float speed = 300.1f;
    public Transform tr;
    public GameObject effect;
    private bool isPause = true;

    private float time;
    private int coin;


    // float h;//좌우
    // float v;//상하
    // Start is called before the first frame update
    void Awake() {
        hp = initHp;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     //   h = Input.GetAxis("Horizontal");
       // v = Input.GetAxis("Vertical");

        //Vector2 dir = new Vector2(h, v);
      //  rb.velocity = dir * speed * Time.deltaTime;
        //화면밖못나가는거
        float size = Camera.main.orthographicSize;
        float offset = 0.5f;
        if (tr.position.y >= size - offset)
        {
            tr.position = new Vector3(tr.position.x, size - offset, 0);
        }
        if (tr.position.y <= -size + offset)
        {
            tr.position = new Vector3(tr.position.x, -size + offset, 0);
        }

        float screenRation = (float)Screen.width / (float)Screen.height;
        float wSize = Camera.main.orthographicSize * screenRation;

        if (tr.position.x >= wSize - offset)
        {
            tr.position = new Vector3(wSize - offset, tr.position.y, 0);
        }
        if (tr.position.x <= -wSize + offset)
        {
            tr.position = new Vector3(-wSize + offset, tr.position.y, 0);
        }

        time += Time.deltaTime;

    }
    void OnTriggerEnter2D(Collider2D coll) {


        if (coll.CompareTag("DESTROYER"))
        {
            Destroy(this.gameObject);
        }
        
        if (coll.CompareTag("ENEMY")) {
            hp--;
            SoundManager.instance.PlaySE("damagesound");

        }
        if (hp <= 0) {
            // Instantiate(effect, tr.position, Quaternion.identity);
            // Destroy(this.gameObject);

            //Time.timeScale = 0;
            //isPause = false;
            coin = (int)time;
            SceneManager.LoadScene("End");
            SetData();
        }

        void SetData()
        {
            PlayerPrefs.SetInt("Coin", coin);
            PlayerPrefs.Save();
        }
    }
}