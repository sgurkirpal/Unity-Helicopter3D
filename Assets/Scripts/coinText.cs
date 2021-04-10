using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class coinText : MonoBehaviour
{
    public GameObject sample;
    public int Score=0;
    public Text sco;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(ScoreCard());
        coin Score = GetComponent<coin>();
        //score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sample != null)
        {
            
            Score = sample.GetComponent<playerMovement>().score;
        }
        sco.text = "Score:  " + Score.ToString();
    }
    


}
