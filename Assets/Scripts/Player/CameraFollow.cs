using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float speed=0.125f;
    public float limitX;
    public Vector3 offset;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

      

        Vector3 desiredPosition =new Vector3(Mathf.Clamp(target.position.x,0,limitX),0,0 )+ offset;

        
        transform.position = desiredPosition;

       // transform.LookAt(target);
	}
}
