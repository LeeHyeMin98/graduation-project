using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reponeManager : MonoBehaviour
{

    public GameObject obj;
    public Transform respawnTr;

 
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RespawnEnemy());  
    }
    private void Update()
    {
        time += Time.deltaTime;
    }
    IEnumerator RespawnEnemy() {
        while (true) {
            if(time<=15)
            {
                yield return new WaitForSeconds(0.9f);

                float range = (float)Screen.width / (float)Screen.height * Camera.main.orthographicSize;
                Instantiate(obj, respawnTr.position + new Vector3(Random.Range(-range, range), Random.Range(-range, range), 0), Quaternion.identity);
            }
            else if(time<=30)
            {
                yield return new WaitForSeconds(0.6f);

                float range = (float)Screen.width / (float)Screen.height * Camera.main.orthographicSize;
                Instantiate(obj, respawnTr.position + new Vector3(Random.Range(-range, range), Random.Range(-range, range), 0), Quaternion.identity);

            }
            else
            {

                yield return new WaitForSeconds(0.4f);

                float range = (float)Screen.width / (float)Screen.height * Camera.main.orthographicSize;
                Instantiate(obj, respawnTr.position + new Vector3(Random.Range(-range, range), Random.Range(-range, range), 0), Quaternion.identity);


            }
        }
    }

}
