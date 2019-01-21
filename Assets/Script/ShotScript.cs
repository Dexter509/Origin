using UnityEngine;

public class ShotScript : MonoBehaviour {
	public int damage = 1;
	public bool isEnmyShot = false;

	void Start () {

		Destroy (gameObject, 6);
	}



}
