/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour 
{
	public GameObject hazard;
	public int hazardcount;
	public Vector2 spawnValues;
	public float spawnwait;
	public float startwait;
	public float wavewait;
	public int Squadspawn;

	public GUIText scoreText;
	public GUIText restartText;
	public GUIText gameOverText;
	private int score;

	private bool gameOver;
	private bool restart;

	void Start ()
	{
		gameOver = false;
		restart = false;
		restartText.text = "";
		gameOverText.text = "";
		score = 0;
		UpdateScore ();
		StartCoroutine (SpawnWaves ());
	}

	void Update ()
	{

		if (score >= 200) 
		{
			SceneManager.LoadScene ("Carrier1");
		}
		if (restart) 
		{
			if (Input.GetKeyDown (KeyCode.R))
			{
				Application.LoadLevel (Application.loadedLevel);
			}

		}
	}
	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds (startwait);
		while(true)
		{
			for (int i = 0; i < hazardcount; i++) 
			{
				Vector2 spawnPosition = new Vector2  (spawnValues.x,(Random.Range (-spawnValues.y, spawnValues.y)));
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				for (int s = 0; s < Squadspawn; s++)
				{
					yield return new WaitForSeconds (.5f);
					float spawnPositionY = spawnPosition.y;

					float yspread = 1.5f + s;
					Vector2 SquadspawnPosition = new Vector2 ((spawnValues.x + .5f), (spawnPositionY + yspread));
					Instantiate (hazard, SquadspawnPosition, spawnRotation);
		
					Vector2 twoSquadspawnPosition = new Vector2 (spawnValues.x, (spawnPositionY - yspread));
					Instantiate (hazard, twoSquadspawnPosition, spawnRotation);

				}
				yield return new WaitForSeconds (spawnwait);
			}
			yield return new WaitForSeconds (wavewait);

			if (gameOver) 
			{
				restartText.text = "Press 'R' for Restart";
				restart = true;
				break;
			}
		}
	}

	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}

	void UpdateScore()
	{
		scoreText.text = "Score: " + score;
	}
	public void GameOver ()
	{
		gameOverText.text = "Game Over!";
		gameOver = true;
	}
}*/