using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour {

	private Color[] color_list = { Color.red, Color.blue, Color.yellow, Color.green };

	private SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			int rand_index = Random.Range (0, color_list.Length);
			sr.color = color_list[rand_index];
			Debug.Log ("Change Random Color: " + sr.color);
		}
	}
}