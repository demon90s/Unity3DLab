using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRenderExample : MonoBehaviour {

	void Test_MeshRender() {
		// 修改obj颜色
		if (Input.GetKeyDown (KeyCode.R)) {
			GetComponent<MeshRenderer> ().material.color = Color.red;
		} else if (Input.GetKeyDown (KeyCode.G)) {
			GetComponent<MeshRenderer> ().material.color = Color.green;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			GetComponent<MeshRenderer> ().material.color = Color.blue;
		}
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Test_MeshRender ();
	}
}
