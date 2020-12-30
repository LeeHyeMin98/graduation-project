using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goooood : MonoBehaviour
{
    private GameObject[] characterLists;
    private int indexs;

    private void Start()
    {

        indexs = PlayerPrefs.GetInt("CharacterSelecteds");
        characterLists = new GameObject[transform.childCount];


        for (int i = 0; i < transform.childCount; i++)
        {
            characterLists[i] = transform.GetChild(i).gameObject;
        }
        foreach (GameObject go in characterLists)

        { go.SetActive(false); }

        if (characterLists[indexs])
            characterLists[indexs].SetActive(true);

       



    }




    public void ToggleLeft()
    {

        //toggle off the current model
        characterLists[indexs].SetActive(false);
        indexs--;
        if (indexs < 0)
            indexs = characterLists.Length - 1;

        characterLists[indexs].SetActive(true);

    }
    public void Toggleright()
    {

        //toggle off the current model
        characterLists[indexs].SetActive(false);
        indexs++;
        if (indexs == characterLists.Length)
        {
            indexs = 0;


            characterLists[indexs].SetActive(true);
        }
    }
    public void Confirm()
    {

        PlayerPrefs.SetInt("CharacterSelecteds", indexs);
        SceneManager.LoadScene("main");
    }
}
