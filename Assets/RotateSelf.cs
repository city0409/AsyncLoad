using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSelf : MonoBehaviour 
{

	private void Awake() 
	{
		
	}
	
	private void Update () 
	{
        transform.Rotate(new Vector3(0, 0, Time.deltaTime * 10));
	}
}
