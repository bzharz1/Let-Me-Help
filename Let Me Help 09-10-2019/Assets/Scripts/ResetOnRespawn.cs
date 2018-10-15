using UnityEngine;
using System.Collections;

public class ResetOnRespawn : MonoBehaviour {

    private Vector3 startPosition;
    private Quaternion startRotation;
    private Vector3 startLocalScal;


	// Use this for initialization
	void Start () {
    startPosition = transform.position;
    startRotation = transform.rotation;
    startLocalScal = transform.localScale;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ResetObject ()
    {
        transform.position = startPosition;
        transform.rotation = startRotation;
        transform.localScale = startLocalScal;
    }
}
