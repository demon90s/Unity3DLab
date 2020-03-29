using UnityEngine;
﻿using System.Collections;
using System.Collections.Generic;

public class Log : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 3种不同的输出到 Console 窗口的方式
		Debug.Log("Normal Log");
		Debug.LogWarning ("Warning Log");
		Debug.LogError ("Error Log");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
