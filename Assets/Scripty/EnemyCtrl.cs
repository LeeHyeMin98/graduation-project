using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class EnemyCtrl : MonoBehaviour
{
    public int hp = 2;
    public int initHp = 2;
    public Transform tr;
    public GameObject effect;

    //public AudioClip soundExplosion; //Audioclip데이터 타입에 변수 생성
    //AudioSource myAudio;
    //public static EnemyCtrl instance;


  
    //void Awake()  // Start함수보다 먼저 호출됨
    //{
    //    if (EnemyCtrl.instance == null)  //게임시작했을때 이 instance가 없을때
    //        EnemyCtrl.instance = this;  // instance를 생성
    //}

    void Start()
    {

    }
    
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D coll)
    {
        
        if (coll.CompareTag("PLAYER"))
        {
            hp--;
            if (hp == 0)
            {
                SoundManager.instance.PlaySE("breaksound");
                //EnemyCtrl.instance.PlaySound();
                Instantiate(effect, tr.position, Quaternion.identity);
                Destroy(this.gameObject);

            }
        }
        if (coll.CompareTag("DESTROYER"))
        {
            Destroy(this.gameObject);
        }

    }

    //public void PlaySound()
    //{
    //    myAudio.PlayOneShot(soundExplosion);

    //}


}
