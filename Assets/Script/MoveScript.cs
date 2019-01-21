using UnityEngine;

public class MoveScript : MonoBehaviour

{

	/// 1 - скорость движения
	/// 
	public Vector2 speed = new Vector2(10, 10);
	public Vector2 direction = new Vector2 (-1,0);
	private Rigidbody2D rb;
	// 2 - направление движения

	private Vector2 movement;

	void Start ()
	{
		rb = GetComponent <Rigidbody2D> ();


	}

	void Update()

	{
			movement = new Vector2 (speed.x * direction.x,speed.y * direction.y);

	}

	void FixedUpdate() 
	{

		// 5 - перемещение игрового объекта
		rb.MovePosition (rb.position +  movement * Time.deltaTime);

	}
}















