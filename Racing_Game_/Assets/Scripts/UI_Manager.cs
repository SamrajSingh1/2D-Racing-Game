using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UI_Manager : MonoBehaviour {
	public Text scoreText;
	public Button[] buttons;
	int score;
	public bool gameOver;
	public carController c;
	// Use this for initialization
	void Start () {
		score = 0;
		gameOver = true;
		InvokeRepeating("scoreUpdate", 1.0f, .5f);
	}
	void scoreUpdate()
	{
		if (gameOver==true)
		{
			score += 1;
		}
	}
	public void gameOverAx()
	{
		gameOver = false;
		foreach(Button button in buttons)
		{
			button.gameObject.SetActive(true);
		}
	}
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score : " + score;
	}
	public void Play()
	{
		Application.LoadLevel("Level_1");
	}
	
	public void Pause()
	{   
		
		if (Time.timeScale == 1)
		{
			Time.timeScale = 0;

			c.am.carSound.Stop();
		}
		else if (Time.timeScale == 0)
		{
			if (gameOver == true)
				c.am.carSound.Play();
			Time.timeScale = 1;
		}
     }
	
	public void menu()
	{
		Application.LoadLevel("menuScene");
	}
	public void exit()
	{
		Application.Quit();
	}
}
