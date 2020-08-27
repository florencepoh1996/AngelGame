using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject target;

    public float followHeight;
    public float followDistance;
    public float followSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        Vector3 targetPosition = target.transform.position;
        targetPosition.y += followHeight;
        targetPosition.z -= followDistance;

        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);

    }
}
