using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public GameObject Bullet;
	public Vector3 spawnValues;
	public int BulletsCount;
	public float startWait;
	public float spawnWait;
	public float WaveWait;


	public int ScoreReward;
	private int  TotalScore = 0;
	private int life = 0;
	Text canvas;
	Text Lifetext;
	HealthScript healscript;


	private void Start ()
	{
		canvas  = GameObject.Find ("Canvas/Text").GetComponent<Text>() ;
		Lifetext = GameObject.Find ("Canvas/Life").GetComponent<Text> ();
		canvas.text = "Total Score: "+ TotalScore ;
		Lifetext.text = "Life: ";
		healscript = GameObject.Find ("Player").GetComponent<HealthScript> ();
		StartCoroutine (	SpawnWaves ());
	}


	IEnumerator SpawnWaves()
	{

		while (true) {
			for (int i = 0; i < BulletsCount; i++) {
				Vector3 spawnPosition = new Vector3 (spawnValues.x, Random.Range (-spawnValues.y, spawnValues.y), spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (Bullet, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (Random.Range(0.5f, spawnWait));
			}
			yield return new WaitForSeconds ( WaveWait);

		}

	}

	public void Score()
	{
		TotalScore += ScoreReward;

		canvas.text = "Total Score: "+ TotalScore ;

	}
	void Update () {

		Lifetext.text = "Life: " + healscript.hp;

	}
}
