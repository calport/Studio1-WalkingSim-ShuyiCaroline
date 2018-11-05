using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Flicker : MonoBehaviour
{

	private Light lightComponent;
	private int currentFrame;
	
	// Range over which height varies.
	//public float HeightScale = 1.0f;

	// Distance covered per second along X axis of Perlin plane.
	public float xScale = 1.0f;

	// Use this for initialization
	void Start ()
	{
		lightComponent = this.GetComponent<Light>();
		currentFrame = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
//		currentFrame++;
//
//		if (currentFrame % 2 == 0)
//		{
		
		
			lightComponent.intensity = 0.2f + (Mathf.PerlinNoise(Time.time * xScale, 1));
		
//			lightComponent.intensity = Mathf.Clamp(Mathf.Abs(NextGaussianFloat()) + 0.5f, 0f, 1.0f );
//		}
		
	}
	
	//Courtesy of stackoverflow answer found at: https://stackoverflow.com/questions/5817490/implementing-box-mueller-random-number-generator-in-c-sharp
//	private float NextGaussianFloat()
//	{
//		float u, v, S;
//		do
//		{
//			u = 2.0f * Random.Range(0f, 1f) - 1.0f;
//			v = 2.0f * Random.Range(0f, 1f) - 1.0f;
//			S = u * u + v * v;
//		}
//		while (S >= 1.0);
//			float fac = Mathf.Sqrt(-2.0f * Mathf.Log(S) / S);
//		return u * fac;
//	}
	
	
}
