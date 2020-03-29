using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourExample : MonoBehaviour {

	// 初始化函数，在游戏开始时系统自动调用
	// 一般用来创建变量
	// 无论脚本组件是否被激活，都能被调用
	void Awake() {
		Debug.Log (name + " Awake");
	}

	// 初始化函数，在所有 Awake 函数运行完之后 Update 函数运行之前调用
	// 一般用来给变量赋值
	// 只有脚本组件激活才能被调用
	void Start () {
		Debug.Log (name + " Start");
	}

	// 每隔固定时间调用一次 （菜单栏 Edit -> Project Settings -> Time 可以找到时间间隔 ）
	// 一般用于物理运动
	void FixedUpdate () {
		Debug.Log (name + " FiexedUpdate");
	}

	// 每一帧调用一次（但时间间隔不固定）
	// 一般用于非物理运动
	void Update () {
		Debug.Log (name + " Update");
	}

	// 所有 Update 结束后调用
	void LateUpdate () {
		Debug.Log (name + " LateUpdate");
	}
}
