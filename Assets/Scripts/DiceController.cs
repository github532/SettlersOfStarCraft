using UnityEngine;
using System.Collections;

public class DiceController : MonoBehaviour {

	public int dice1;
	public int dice2;

	// Use this for initialization
	void Start () {
		dice1 = new int ();
		dice2 = new int ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public int RollDice()
	{
		dice1 = Random.Range (0, 6) + 1;
		dice2 = Random.Range (0, 6) + 1;

		//Debug.Log (dice1 + dice2);
		return (dice1 + dice2);
	}
}
