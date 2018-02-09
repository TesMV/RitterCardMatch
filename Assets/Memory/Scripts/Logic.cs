using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Logic : MonoBehaviour {

    private SelectDifficulty difficulty;
	private MemoryCard[] cards = new MemoryCard[2];
	private int setsofcards;
	private static int nroftries = 0;
    private float timeLeft;
    private int timeLeftInteger;
    private static bool win = false;
    public static bool gameEnd = false;
    public Text timer;
	
	// Use this for initialization
	void Start () {
        if(gameEnd == false)
        {
            difficulty = GetComponent<SelectDifficulty>();
            timeLeft = difficulty.ReturnDifficility();
        }      
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        Debug.Log((int)timeLeft);
        timeLeftInteger = (int)timeLeft;
        try
        {
            timer.GetComponent<Text>().text = "Time remaining: " + timeLeftInteger.ToString();
        }
        catch(System.Exception ex)
        {
            Debug.Log("Text is null");
        }
        if (timeLeft < 0.0f) //если истекло время заканчиваем игру
        {
            GameEnd();
        }
	}
	
	public void CheckCards(MemoryCard mc){
		if(cards[0] == null)
			cards[0] = mc;
		else{
			cards[1] = mc;
			nroftries++;
			
			if(cards[0].cardnumber == cards[1].cardnumber)
				CardsMatching();
			else
				CardsNotMatching();
			
			cards[0] = null;
			cards[1] = null;
		}
	}
	
	void CardsMatching(){
		cards[0].RemoveCard();
		cards[1].RemoveCard();
		
		setsofcards--;
		if(setsofcards == 0)
        {
            win = true; //если не осталось карт защитываем выйгрыш.
            GameEnd();
        }
			
	}
	void CardsNotMatching(){
		cards[0].Hide();
		cards[1].Hide();
	}
	void GameEnd(){
		Debug.Log("Game has ended, number of tries: " + nroftries);
        if (!gameEnd)
            SceneManager.LoadScene(3);
        gameEnd = true;
    }

    public int GetNumber()
    {
        return nroftries;
    }

    public bool GetWin()
    {
        return win;
    }

    public void SetSetsOfCards(int i){
		setsofcards = i;
	}
}
