using UnityEngine;

public class CircleControler : MonoBehaviour {

	public float speed = 100f;

	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 0, speed * Time.deltaTime);
	}

	void OnTriggerEnter2D (Collider2D other) {
		Debug.Log ("OnTriggerEnter2D");
	}
}