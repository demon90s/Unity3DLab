using UnityEngine;

public class physics : MonoBehaviour {

	public float upforce = 5f;

	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			// 修改速度
			rb.velocity = Vector2.up * upforce;
		}
	}
}
