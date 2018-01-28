using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonClick : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}
