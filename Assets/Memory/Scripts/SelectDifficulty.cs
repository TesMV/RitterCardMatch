using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectDifficulty : MonoBehaviour {

    public static float timer;
    Text diffcilityText;

    private void Start()
    {
        diffcilityText = GameObject.Find("TextDifficulty").GetComponent<Text>();
    }

    public void ChooseEasy()
    {
        Debug.Log("You chose easy mode");
        diffcilityText.text = "You chose easy mode";
        timer = 121.00f;
    }

    public void ChooseNormal()
    {
        Debug.Log("You chose normal mode");
        diffcilityText.text = "You chose normal mode";
        timer = 61.00f;
    }

    public void ChooseHard()
    {
        Debug.Log("You chose hard mode");
        diffcilityText.text = "You chose hard mode";
        timer = 31.00f;
    }

    public float ReturnDifficility()
    {
        return timer;
    }

    public void StartGame()
    {
        Logic.gameEnd = false;
        SceneManager.LoadScene(2);
    }
}
