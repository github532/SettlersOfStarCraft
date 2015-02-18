using UnityEngine;
using System.Collections;

public class TileSprites : MonoBehaviour {

	public Sprite grassMinerals;
	public Sprite grassVespene;
	public Sprite grassGold;
	public Sprite grassSilver;
	public Sprite grassWater;
	public Sprite grassSpace;
	public Sprite grassPlane;
	public Sprite grassMetal;

	public Sprite desertMinerals;
	public Sprite desertVespene;
	public Sprite desertGold;
	public Sprite desertSilver;
	public Sprite desertWater;
	public Sprite desertSpace;
	public Sprite desertPlane;
	public Sprite desertMetal;

	public Sprite dirtMinerals;
	public Sprite dirtVespene;
	public Sprite dirtGold;
	public Sprite dirtSilver;
	public Sprite dirtWater;
	public Sprite dirtSpace;
	public Sprite dirtPlane;
	public Sprite dirtMetal;
	
	public static Sprite[] grassSprites;
	public static Sprite[] desertSprites;
	public static Sprite[] dirtSprites;

	// Use this for initialization
	void Start () {
		InitializeGrassSprites ();
		InitializeDesertSprites ();
		InitializeDirtSprites ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void InitializeGrassSprites()
	{
		grassSprites = new Sprite[8]; 
		grassSprites[0] = grassMinerals;
		grassSprites[1] = grassVespene;
		grassSprites[2] = grassGold;
		grassSprites[3] = grassSilver;
		grassSprites[4] = grassWater;
		grassSprites[5] = grassSpace;
		grassSprites[6] = grassPlane;
		grassSprites[7] = grassMetal;
	}

	void InitializeDesertSprites()
	{
		desertSprites = new Sprite[8]; 
		desertSprites [0] = desertMinerals;
		desertSprites [1] = desertVespene;
		desertSprites [2] = desertGold;
		desertSprites [3] = desertSilver;
		desertSprites [4] = desertWater;
		desertSprites [5] = desertSpace;
		desertSprites [6] = desertPlane;
		desertSprites [7] = desertMetal;
	}

	void InitializeDirtSprites()
	{
		dirtSprites = new Sprite[8]; 
		dirtSprites [0] = dirtMinerals;
		dirtSprites [1] = dirtVespene;
		dirtSprites [2] = dirtGold;
		dirtSprites [3] = dirtSilver;
		dirtSprites [4] = dirtWater;
		dirtSprites [5] = dirtSpace;
		dirtSprites [6] = dirtPlane;
		dirtSprites [7] = dirtMetal;
	}
}
