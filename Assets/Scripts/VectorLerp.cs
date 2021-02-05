using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorLerp : MonoBehaviour
{
	public Transform mTarget;

	public float mSpeed = 0.25f;
	const float EPSILON = 0.1f;

	Vector3 mLookDritection;

    void Start()
    {
    	
    }

    void Update()
    {
    	//transform.LookAt(mTarget.position);

    	//if ((transform.position - mTarget.position).magnitude > EPSILON)
    	//	transform.Translate(0.0f, 0.0f, mSpeed*Time.deltaTime);

    	mLookDritection = (mTarget.position - transform.position).normalized;

    	if ((transform.position - mTarget.position).magnitude > EPSILON)
    		transform.Translate(mLookDritection * mSpeed*Time.deltaTime);

    }
}
