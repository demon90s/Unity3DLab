using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Quaternion
// 用来代表旋转角
// 是一个四元组，x y z表明一个向量，w表明一个旋转量，不要直接修改它们，而应该使用方法
// unity 把物体的 quaternion 转换成了欧拉角，用于在 Inspector 面板上做调整，这样是为了方便手动操作，欧拉角也有局限性，就是会有一个叫做 gimbal lock 的问题

public class QuaternionExample : MonoBehaviour {

	public GameObject test_obj;

	// 移动物体
	void Move() {
		float h_axis = Input.GetAxis ("Horizontal");
		float v_axis = Input.GetAxis ("Vertical");

		transform.Translate (new Vector3 (h_axis, 0, v_axis) * 10.0f * Time.deltaTime);
	}

	// Quaternion.LookRotation
	// public static Quaternion LookRotation(Vector3 forward, Vector3 upwards = Vector3.up);
	// 根据向量创建一个对应的旋转角
	void Test_LookRotation() {
		Vector3 relativePos = transform.position - test_obj.transform.position;
		test_obj.transform.rotation = Quaternion.LookRotation (relativePos);
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Move ();
		Test_LookRotation ();
	}
}
