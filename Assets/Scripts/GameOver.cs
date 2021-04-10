using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject heli;
    public Text gameOverText;
    public int Score;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (heli != null)
        {

            Score = heli.GetComponent<playerMovement>().score;
        }
        if (heli == null)
        {
            gameOverText.text = "Game Over\nScore:\n" + Score.ToString()+" coins\nTouch two fingers to restart!"; ;
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (Input.touchCount == 2)
                {
                    SceneManager.LoadScene("SampleScene");
                }
            }
        }
        else
        {
            gameOverText.text = "";
        }
    }
}
