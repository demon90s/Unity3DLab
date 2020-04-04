using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentExample : MonoBehaviour {

	// enabled 属性控制 Component 是否激活

	public Light my_light;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Space)) {
			my_light.enabled = !my_light.enabled;
		}
	}
}
