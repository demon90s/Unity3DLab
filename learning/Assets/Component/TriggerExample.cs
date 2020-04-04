using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExample : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Move ();
	}

	// 当进入一个勾选了 IsTrigger 的 Collider
	// 而且 gameObject 需要有 rigidbody + collider 组件
	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("OnTriggerEnter, trigger_obj_name: " + other.gameObject.ToString());
	}

	// 当离开 Trigger
	void OnTriggerExit(Collider other)
	{
		Debug.Log ("OnTriggerExit, trigger_obj_name: " + other.gameObject.ToString());
	}

	// 当和 Trigger 接触着
	void OnTriggerStay(Collider other)
	{
		Debug.Log ("OnTriggerStay, trigger_obj_name: " + other.gameObject.ToString());
	}

	void Move()
	{
		float h_axis = Input.GetAxis ("Horizontal");
		float v_axis = Input.GetAxis ("Vertical");

		this.transform.Translate (new Vector3 (h_axis, 0, v_axis) * 5.0f * Time.deltaTime);
	}
}
