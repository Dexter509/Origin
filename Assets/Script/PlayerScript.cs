using UnityEngine;

public class PlayerScript : MonoBehaviour

{
	

	/// 1 - скорость движения

	///

	public Vector2 speed = new Vector2(10, 10);

	private Rigidbody2D rb;

	// 2 - направление движения
	public float leftBorder;
	public float rightBorder;
	public float topBorder;
	public float bottomBorder;

	private Vector2 movement;

	void Start ()

	{
		Vector3 pos = transform.position;

		rb = GetComponent <Rigidbody2D> ();
		float dist = Vector3.Distance (pos, Camera.main.transform.position);
		leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).x;
		rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, dist)).x;
		topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, dist)).y;
		bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).y;


	}









	void Update()
	{

		// 3 - извлечь информацию оси

		float inputX = Input.GetAxis ("Horizontal");

		float inputY = Input.GetAxis ("Vertical");

		// 4 - движение в каждом направлении

		movement = new Vector2 (

			speed.x * inputX,

			speed.y * inputY);


		bool shoot = Input.GetKeyDown (KeyCode.Space);
		WeaponScript weapon = GetComponent<WeaponScript> ();

		if (shoot) {

		

			if (weapon != null) {

				weapon.Attack (false);
				SoundEffectsHelper.Instance.MakePlayerShotSound ();
			

			}

		}				


		Vector3 pos = transform.position;
		transform.position = new Vector3 (Mathf.Clamp (pos.x, leftBorder, rightBorder), Mathf.Clamp (pos.y, bottomBorder, topBorder), pos.z);

	}




	



	void OnDestroy()
	{
		transform.parent.gameObject.AddComponent<GameOverScript> ();
	}




	void FixedUpdate()

	{

		// 5 - перемещение игрового объекта

		rb.MovePosition (rb.position + movement * Time.deltaTime);

	}

}