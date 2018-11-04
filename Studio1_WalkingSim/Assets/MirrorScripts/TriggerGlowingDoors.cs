using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = System.Object;

public class TriggerGlowingDoors : MonoBehaviour
{


	public Animator myanim;
	
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//myanim.Play();
		
		
		
	}

	void OnTriggerEnter(Collider other)
	{
		print("true1");
		
		
		if (other.gameObject.CompareTag("Player"))
		{
			print("true2");
			myanim.SetBool("TRIGGERED",true);
			
			
		}

		//if (other.gameObject.CompareTag("Player"))
		//{

		//	Boolean DoorsGlow = true;
		//	print("true");
		//}
		
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{

			//Boolean DoorsGlow = false;
			print("false");
			myanim.SetBool("TRIGGERED",false);
		}
	}
}
