using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//DrawLine_Example();
		DrawRay_Example();
	}

    // Draw方法只能在 Scene 视图下有效果

	void DrawLine_Example()
	{
		float offset = 5.0f;
        Vector3 position = transform.position;

        Vector3 start = new Vector3 (position.x + offset,
                            position.y + offset,
                            position.z + offset);

        Vector3 end = new Vector3 (position.x - offset,
            position.y - offset,
            position.z - offset);

        Debug.DrawLine (start, end, Color.red);
	}

	void DrawRay_Example()
	{
		Vector3 forward = transform.TransformDirection (Vector3.up) * 10; // 10是长度
        Debug.DrawRay (transform.position, forward, Color.red);
	}
}
