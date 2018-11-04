using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBetweenPlayers : MonoBehaviour
{
	private float PlayerDistanceX;
	private float PlayerDistanceY;
	private float PlayerDistanceZ;

	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		PlayerDistanceX = (GameObject.Find("FPSController_1").transform.position.x +
		                  GameObject.Find("FPSController_2").transform.position.x) / 2f;
		PlayerDistanceY = (GameObject.Find("FPSController_1").transform.position.y +
		                  GameObject.Find("FPSController_2").transform.position.y) / 2f;
		PlayerDistanceZ = (GameObject.Find("FPSController_1").transform.position.z +
		                  GameObject.Find("FPSController_2").transform.position.z) / 2f;

		this.transform.position = new Vector3(PlayerDistanceX, PlayerDistanceY, PlayerDistanceZ);
	}

	
}
