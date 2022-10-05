using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameManager : MonoBehaviour
{
    private GameObject NamePlayer;
  

 
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        NamePlayer = GameObject.FindGameObjectWithTag("NamePlayer");
        NamePlayer.GetComponent<Text>().text = "Name:  " + PlayerPrefs.GetString("NamePlayer") + "  Score:" + PlayerPrefs.GetInt("MaxScore",0).ToString();
    }
   
}
