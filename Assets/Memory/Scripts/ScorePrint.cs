using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScorePrint : MonoBehaviour {

    public Text score;

    private Logic getLogicInfo;

    private int numberOfTries;

    private bool winStatus;
	// Use this for initialization
	void Start () {
        getLogicInfo = GetComponent<Logic>();
        score = GetComponent<Text>();
        numberOfTries = getLogicInfo.GetNumber();
        winStatus = getLogicInfo.GetWin();

        if(winStatus == true)
        {
            score.text = "You are a winner! Your number of tries is " + numberOfTries.ToString();
        }
        else
        {
            score.text = "Sorry, but you lose. Your number of tries is " + numberOfTries.ToString();
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ToStartScreen()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
