using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    
	public int scorePlayer1;
	public int scorePlayer2;
    public int scorePlayer3;
    public int scorePlayer4;



	/// <summary>
	/// Style that is used to display the score text.
	/// </summary>
	public GUIStyle style;

	/// <summary>
	/// Score that must be reached, to win the game.
	/// </summary>
	public int winningScore = 5;

	void OnGUI()
	{
		// calculate the top screen center of the screen
		float x = Screen.width/2f;
		float y = 30f;
		float width = 300f;
		float height = 20f;
		string text = scorePlayer1 + " / " + scorePlayer2 + " / " + scorePlayer3 + " /" + scorePlayer4;
		
		// draw the label at the top center of the screen
		GUI.Label(new Rect(x-(width/2f), y, width, height), text, style);

		// check for winning condition
		if (scorePlayer1 >= winningScore || scorePlayer2 >= winningScore || scorePlayer3 >= winningScore || scorePlayer4 >= winningScore)
		{
			// disable ball
			GameObject ball = GameObject.Find("Ball");
			if (ball != null)
			{
				ball.SetActive(false);
			}

			// create winning message
			string winMessage = "Player 2 won";
			if (scorePlayer1 >= winningScore)
			{
				winMessage = "Player 1 won";
			}

            string winMessage2 = "Player 4 won";
			if (scorePlayer3 >= winningScore)
			{
				winMessage = "Player 3 won";
			}

			// show winning message at the center of the screen
			y = Screen.height/2f;
			GUI.Label(new Rect(x-(width/2f), y+(height/2f), width, height), winMessage, style);
		}

	}
}
