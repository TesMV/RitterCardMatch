using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScorePrint : MonoBehaviour {

    public Text score;

    private Logic getNumber;

    private int numberOfTries;
	// Use this for initialization
	void Start () {
        getNumber = GetComponent<Logic>();
        score = GetComponent<Text>();
        numberOfTries = getNumber.GetNumber();
        score.text = "Number of tries " + numberOfTries.ToString();
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
