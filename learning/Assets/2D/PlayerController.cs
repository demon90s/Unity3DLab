using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float upforce = 5f;

	public Rigidbody2D rb;

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			// 修改速度
			rb.velocity = Vector2.up * upforce;
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		Debug.Log (other.tag);
	}
}