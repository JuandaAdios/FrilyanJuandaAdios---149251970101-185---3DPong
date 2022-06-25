using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBorder : MonoBehaviour
{

/// <summary>
	/// Indicates the boder of the left or right player.
	/// </summary>
	public ePlayer player;
	/// <summary>
	/// Reference to the score ui.
	/// </summary>
	public ScoreUI score;
	
	/// <summary>
	/// Invoked by Unity if a GameObject collides with this GameObject.
	/// </summary>
	void OnCollisionEnter(Collision col)
	{
		// Has the GameObject that collides the Ball component?
		BallController ball = col.gameObject.GetComponent<BallController>();
		if (ball != null)
		{
			// move the ball back to the corner of the arena
			ball.transform.position = new Vector3(-9.04f, 1.4f, -9.52f);
			
			// increment score of the other player
			if (player == ePlayer.PlayerOne) score.scorePlayer1++;
			else if (player == ePlayer.PlayerTwo) score.scorePlayer2++;
            else if (player == ePlayer.PlayerThree) score.scorePlayer3++;
            else if (player == ePlayer.PlayerFour) score.scorePlayer4++;
		}
	}

}