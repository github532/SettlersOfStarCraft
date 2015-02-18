using UnityEngine;
using System.Collections;

public class Coordinates : MonoBehaviour {
	
	public Vector3 coordValues;// = new Vector3();
	public int[] adjacentIndex;
	public bool available = true;
	public bool hasRoad = false;

	// Use this for initialization
	void Start () 
	{
		Vector3 coordValues = new Vector3();
		int[] adjacentIndex = new int[3];
		bool available = true;
	}

	// Update is called once per frame
	void Update () 
	{
	
	}
}