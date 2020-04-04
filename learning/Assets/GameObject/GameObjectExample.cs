using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectExample : MonoBehaviour {

	// gameObject 自身

	// tag
	// 实体的标签，在物体的 Inspector 面板最开始那里设置
	void Test_tag() {
		Debug.Log ("test_cude's tag is: " + gameObject.tag);
	}

	// CompareTag 比较标签
	void Test_CompareTag() {
		// 方法1：使用字符串比较
		// 方法2：使用成员函数
		//if (tag == "test_cube") {
		if (gameObject.CompareTag ("test_cube")) {
			Debug.Log ("CompareTag succ");
		} else {
			Debug.Log ("CompareTag failure");
		}
	}

	// SetActive
	// 激活/取消激活物体，没有激活的不会激活它的所有组件
	// 即可以隐藏掉实体

	public GameObject test_cube;

	void Test_SetActive() {
		if (Input.GetButton ("Fire1")) {
			test_cube.SetActive (false);
		} else {
			test_cube.SetActive (true);
		}
	}

	// Use this for initialization
	void Start () {
		//Test_tag ();
		//Test_CompareTag();
	}

	// Update is called once per frame
	void Update () {
		Test_SetActive();
	}
}
