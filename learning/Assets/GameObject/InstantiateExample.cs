using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateExample : MonoBehaviour {

	// Instantiate 根据预制体创建一个实体
	// Destroy 销毁掉一个实体，可以选择一个延迟

	public GameObject prefab_obj;

	void Test_Instantiate()
	{
		if (Input.GetButtonDown ("Fire1")) {
			GameObject obj = Instantiate (prefab_obj, new Vector3(0, 8, 0), Quaternion.identity);
			Destroy (obj, 3);
		}
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Test_Instantiate ();
	}
}
