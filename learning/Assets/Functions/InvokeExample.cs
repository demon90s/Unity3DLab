using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Invoke - 若干秒后调用指定函数
		//Invoke ("OnInvoke", 2);

		// InvokeRepeating - 若干秒后调用指定函数，然后在每若干秒继续调用
		InvokeRepeating("OnInvoke", 2, 1);
	}

	// Update is called once per frame
	void Update () {
		// CancelInvoke - 停止对某函数的 Invoke
		if (Input.GetKeyDown (KeyCode.Space)) {
			CancelInvoke ("OnInvoke");
		}
	}

	private int invoke_times = 0;
	void OnInvoke() {
		invoke_times += 1;
		Debug.Log ("Wow~ I am invoking~~~ times: " + invoke_times);
	}
}
