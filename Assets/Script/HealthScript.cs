using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {

	public int hp ;

	public bool isEnemy = true;
	private GameController score;



	public void Damage (int damageCount)

	{

		hp -= damageCount;

		if (hp <= 0) {

			Destroy (gameObject);

		}

	}



	void OnTriggerEnter2D (Collider2D otherCollider)

	{

		ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript> ();

		if (shot != null)

		if (shot.isEnmyShot != isEnemy)

		{

			Damage (shot.damage);
			if (hp <= 0) {

	
				SoundEffectsHelper.Instance.MakeExplosionSound ();
				Destroy (gameObject);

			}

			Destroy (shot.gameObject);
			SoundEffectsHelper.Instance.MakeExplosionSound ();
			score.Score ();
	}
	}


	void Start () {
		GameObject gameObject = GameObject.FindWithTag ("GameController");
		 score = gameObject.GetComponent<GameController>(); 
	}



	void Update () {

	}

}