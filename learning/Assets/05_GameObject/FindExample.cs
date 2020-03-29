using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindExample : MonoBehaviour {

	// Find: 通过 GameObject 的名字查找物体，可以通过 Hierarchy 路径查询
	void Test_Find()
	{
		GameObject obj = GameObject.Find ("/CubeContainer/Cube");
		if (obj) {
			Debug.Log ("Find obj: " + obj.ToString ());
		} 
		else {
			Debug.Log ("Find obj failed");
		}
	}

	// Use this for initialization
	void Start () {
		Test_Find ();
	}

	// Update is called once per frame
	void Update () {

	}
}
