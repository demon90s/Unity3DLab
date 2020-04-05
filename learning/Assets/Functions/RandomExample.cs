using UnityEngine;

public class RandomExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float randnum = Random.Range (1, 3);
		Debug.Log (randnum);
	}

	// Update is called once per frame
	void Update () {

	}
}