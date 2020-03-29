using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneExample : MonoBehaviour {

	// height, width
	// 当前游戏窗口的高度和宽度（像素值）
	void Test_height_width() {
		int height = Screen.height;
		int width = Screen.width;

		Debug.Log ("Window height: " + height + " width: " + width);
	}

	// Use this for initialization
	void Start () {
		Test_height_width ();
	}

	// Update is called once per frame
	void Update () {

	}
}
