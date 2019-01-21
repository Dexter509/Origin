﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsHelper : MonoBehaviour {


	public static SoundEffectsHelper Instance;
	public AudioClip explosionSound;
	public AudioClip playerShotSound;
	public AudioClip enemyShotSound;


	void Awake()
	{
		if (Instance)
			Debug.LogError ("Несколько экземпляров SoundEffectsHelper");

		Instance = this;

	}
	public void MakeExplosionSound ()
	{
		MakeSound (explosionSound);
	}
	public void MakePlayerShotSound()
	{
		MakeSound (playerShotSound);

	}

	public void MakeEnemySound ()
	{
		MakeSound (enemyShotSound);

	}

	private void MakeSound (AudioClip originalClip)
	{
		AudioSource.PlayClipAtPoint (originalClip, transform.position);
	}
}
