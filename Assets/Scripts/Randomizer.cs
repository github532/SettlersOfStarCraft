using UnityEngine;
using System.Collections;


public class Randomizer : MonoBehaviour {

	//public enum ResourceType { minerals = 0, vespene, gold, silver, water, space };
	//public enum TileNumber {two = 0, three, four, five, six, eight, nine, ten, eleven, twelve};
	public enum DevelopmentCard {knight = 0, victoryPoint, monopoly, yearOfPlenty, roadBuilding};

	public int[] resources = new int[19];
	public int[] tileNumbers = new int[18];
	public DevelopmentCard[] devCardDeck = new DevelopmentCard[25];

	public int[] devCardQuantities;


	// Use this for initialization
	void Start ()
	{
		//InitializeRandomQuantities ();
		//InitializeResourceQuantities ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}


	//sets original values back to quantities of devcards, resources, and tileNumbers
	public int[] InitializeResourceQuantities (int[] resourceQty)
	{
		resourceQty[0] = 3;
		resourceQty[1] = 4;
		resourceQty[2] = 4;
		resourceQty[3] = 3;
		resourceQty[4] = 4;
		resourceQty[5] = 1;

		return resourceQty;
	}

	public int[] InitializeTileNumberQuantities (int[] tileNum)
	{
		tileNum[0] = 1;
		tileNum[1] = 2;
		tileNum[2] = 2;
		tileNum[3] = 2;
		tileNum[4] = 2;
		tileNum[5] = 2;
		tileNum[6] = 2;
		tileNum[7] = 2;
		tileNum[8] = 2;
		tileNum[9] = 1;
		
		return tileNum;
	}

	public int[] InitializeDevCardQuantities (int[] devCardQty)
	{
		devCardQty[0] = 14;
		devCardQty[1] = 5;
		devCardQty[2] = 2;
		devCardQty[3] = 2;
		devCardQty[4] = 2;
		
		return devCardQty;
	}


	public int[] RandomizeResources()
	{
		int[] resourceQuantities = new int[6];
		resourceQuantities = InitializeResourceQuantities(resourceQuantities);

		int newNum;
		bool done = false;
		int index = 0;

		while(!done)
		{
			newNum = (int)Random.Range(0, 6);	//call random 0-5 inclusively

			if(resourceQuantities != null)
			{
				if(resourceQuantities[newNum] != 0)	//check qty != 0
				{
					Debug.Log("Index " + index);
					//Debug.Log ("Resource Quantity: " + resourceQuantities[newNum]);
					resources[index] = newNum;	//assign value to current array position
					index++;
					resourceQuantities[newNum]--;	//subtract value from qty
				}
			}
			else
				Debug.Log ("resourceQuantities array is null");

			if (index == 19)
				done = true;
		}

		return resources;
	}


	public int[] RandomizeTileNumbers()
	{
		int[] tileNumberQuantities = new int[10];
		tileNumberQuantities = InitializeTileNumberQuantities (tileNumberQuantities);

		int newNum;
		bool done = false;
		int index = 0;

		while(!done)
		{
			newNum = Random.Range(0, 10);	//call random 0-9 inclusively

			if(tileNumberQuantities != null)
			{
				if(tileNumberQuantities[newNum] != 0)	//check qty != 0
				{
					//Debug.Log ("tileNumber Quantity: " + tileNumberQuantities[newNum]);
					tileNumbers[index] = newNum;	//assign value to current array position
					index++;
					tileNumberQuantities[newNum]--;	//subtract value from qty
				}
			}
			else
				Debug.Log ("tileNumberQuantities array is null");

			if (index == 18)
				done = true;
		}

		return tileNumbers;
	}

	public void ShuffleDevCards()
	{
		//assign card order in deck based off of a random 1-100 percent of total number of cards of each type vs deck total
		//check qty != 0
		//else "re-roll"
		//assign value to current array position
		//subtract value from qty
		
		//if all resources are used, set "done" bool to true and exit loop

		//knights 14/25*100 = 56% (or 14*4)
		//victoryPoint 5/25*100 = 20%
		//monopoly 2/25*100 = 8%
		//yearOfPlenty 2/25*100 =8%
		//roadBuilding 2/25*100 = 8%

		//1-14 = knight
		//15-22 = monopoly
		//23-36 = knight
		//37-44 = year'o'plenty
		//45-58 = knight
		//59-66 = roadbuilding
		//67-80 = knight
		//81-100 = victorypoint
	}

	public Tiles.TerrainType RandomizeTerrain()
	{
		Tiles.TerrainType newTerrain;

		int terrain = Random.Range (0, 3);

		if(terrain == 0)
			newTerrain = Tiles.TerrainType.grass;
		else if(terrain == 1)
			newTerrain = Tiles.TerrainType.desert;
		else
			newTerrain = Tiles.TerrainType.dirt;

		return newTerrain;
	}
}
