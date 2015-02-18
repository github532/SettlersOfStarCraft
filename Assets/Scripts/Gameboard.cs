using UnityEngine;
using System.Collections;

public class Gameboard : MonoBehaviour {

	public Tiles[] tile = new Tiles[19];

	public Coordinates[] coordinate = new Coordinates[54];
	private int x = 999;	//adjacent index place holder, indicating null
	//private int diceResults;

	Randomizer randomizer;
	DiceController dice;

	// Use this for initialization
	void Start () {
		randomizer = new Randomizer ();	

		InitializeTileValues ();
		InitializeCoordinateValues ();

		AssignTerrain (randomizer.RandomizeTerrain());		//Tiles.TerrainType.grass

		AssignDefaultResources ();
		//AssignRandomResources();

		AssignDefaultTileNumbers ();
		//AssignRandomTileNumbers ();

		AssignTileSprite ();

//		GetDiceResults ();
//		GetDiceResults ();
//		GetDiceResults ();
//		GetDiceResults ();
//		GetDiceResults ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void InitializeTileValues()
	{
		tile [0].SetAdjacentCoords (39,40,41,47,48,49);
		tile [1].SetAdjacentCoords (41,42,43,49,50,51);
		tile [2].SetAdjacentCoords (43,44,45,51,52,53);
		tile [3].SetAdjacentCoords (34,35,36,44,45,46);
		tile [4].SetAdjacentCoords (24,25,26,35,36,37);
		tile [5].SetAdjacentCoords (13,14,15,23,24,25);
		tile [6].SetAdjacentCoords (4,5,6,12,13,14);
		tile [7].SetAdjacentCoords (2,3,4,10,11,12);
		tile [8].SetAdjacentCoords (0,1,2,8,9,10);
		tile [9].SetAdjacentCoords (7,8,9,17,18,19);
		tile [10].SetAdjacentCoords (16,17,18,27,28,29);
		tile [11].SetAdjacentCoords (28,29,30,38,39,40);
		tile [12].SetAdjacentCoords (30,31,32,40,41,42);
		tile [13].SetAdjacentCoords (32,33,34,42,43,44);
		tile [14].SetAdjacentCoords (22,23,24,33,34,35);
		tile [15].SetAdjacentCoords (11,12,13,21,22,23);
		tile [16].SetAdjacentCoords (9,10,11,19,20,21);
		tile [17].SetAdjacentCoords (18,19,20,29,30,31);
		tile [18].SetAdjacentCoords (20,21,22,31,32,33);
	}

	void InitializeCoordinateValues()
	{
		coordinate[0].coordValues = new Vector3(-4.5f, 5.25f, 0f);
		coordinate[1].coordValues = new Vector3(-3f, 6f, 0f);
		coordinate[2].coordValues = new Vector3(-1.5f, 5.25f, 0f);
		coordinate[3].coordValues = new Vector3(0f, 6f, 0f);
		coordinate[4].coordValues = new Vector3(1.5f, 5.25f, 0f);
		coordinate[5].coordValues = new Vector3(3f, 6f, 0f);
		coordinate[6].coordValues = new Vector3(4.5f, 5.25f, 0f);
		coordinate[7].coordValues = new Vector3(-6f, 3f, 0f);
		coordinate[8].coordValues = new Vector3(-4.5f, 3.75f, 0f);
		coordinate[9].coordValues = new Vector3(-3f, 3f, 0f);
		coordinate[10].coordValues = new Vector3(-1.5f, 3.75f, 0f);
		coordinate[11].coordValues = new Vector3(0f, 3f, 0f);
		coordinate[12].coordValues = new Vector3(1.5f, 3.75f, 0f);
		coordinate[13].coordValues = new Vector3(3f, 3f, 0f);
		coordinate[14].coordValues = new Vector3(4.5f, 3.75f, 0f);
		coordinate[15].coordValues = new Vector3(6f, 3f, 0f);
		coordinate[16].coordValues = new Vector3(-7.5f, .75f, 0f);
		coordinate[17].coordValues = new Vector3(-6f, 1.5f, 0f);
		coordinate[18].coordValues = new Vector3(-4.5f, .75f, 0f);
		coordinate[19].coordValues = new Vector3(-3f, 1.5f, 0f);
		coordinate[20].coordValues = new Vector3(-1.5f, .75f, 0f);
		coordinate[21].coordValues = new Vector3(0f, 1.5f, 0f);
		coordinate[22].coordValues = new Vector3(1.5f, .75f, 0f);
		coordinate[23].coordValues = new Vector3(3f, 1.5f, 0f);
		coordinate[24].coordValues = new Vector3(4.5f, .75f, 0f);
		coordinate[25].coordValues = new Vector3(6f, 1.5f, 0f);
		coordinate[26].coordValues = new Vector3(7.5f, .75f, 0f);
		coordinate[27].coordValues = new Vector3(-7.5f, -.75f, 0f);
		coordinate[28].coordValues = new Vector3(-6f, -1.5f, 0f);
		coordinate[29].coordValues = new Vector3(-4.5f, -.75f, 0f);
		coordinate[30].coordValues = new Vector3(-3f, -1.5f, 0f);
		coordinate[31].coordValues = new Vector3(-1.5f, -.75f, 0f);
		coordinate[32].coordValues = new Vector3(0f, -1.5f, 0f);
		coordinate[33].coordValues = new Vector3(1.5f, -.75f, 0f);
		coordinate[34].coordValues = new Vector3(3f, -1.5f, 0f);
		coordinate[35].coordValues = new Vector3(4.5f, -.75f, 0f);
		coordinate[36].coordValues = new Vector3(6f, -1.5f, 0f);
		coordinate[37].coordValues = new Vector3(7.5f, -.75f, 0f);
		coordinate[38].coordValues = new Vector3(-6f, -3f, 0f);
		coordinate[39].coordValues = new Vector3(-4.5f, -3.75f, 0f);
		coordinate[40].coordValues = new Vector3(-3f, -3f, 0f);
		coordinate[41].coordValues = new Vector3(-1.5f, -3.75f, 0f);
		coordinate[42].coordValues = new Vector3(0f, -3f, 0f);
		coordinate[43].coordValues = new Vector3(1.5f, -3.75f, 0f);
		coordinate[44].coordValues = new Vector3(3f, -3f, 0f);
		coordinate[45].coordValues = new Vector3(4.5f, -3.75f, 0f);
		coordinate[46].coordValues = new Vector3(6f, -3f, 0f);
		coordinate[47].coordValues = new Vector3(-4.5f, -5.25f, 0f);
		coordinate[48].coordValues = new Vector3(-3f, -6f, 0f);
		coordinate[49].coordValues = new Vector3(-1.5f, -5.25f, 0f);
		coordinate[50].coordValues = new Vector3(0f, -6f, 0f);
		coordinate[51].coordValues = new Vector3(1.5f, -5.25f, 0f);
		coordinate[52].coordValues = new Vector3(3f, -6f, 0f);
		coordinate[53].coordValues = new Vector3(4.5f, -5.25f, 0f);


		//Set point adjacency index for finding coordinates within a range of one space to selected point
		coordinate [0].adjacentIndex [0] = 1;
		coordinate [0].adjacentIndex [1] = 8;
		coordinate [0].adjacentIndex [2] = x;

		coordinate [1].adjacentIndex [0] = 0;
		coordinate [1].adjacentIndex [1] = 2;
		coordinate [1].adjacentIndex [2] = x;

		coordinate [2].adjacentIndex [0] = 1;
		coordinate [2].adjacentIndex [1] = 3;
		coordinate [2].adjacentIndex [2] = 10;

		coordinate [3].adjacentIndex [0] = 2;
		coordinate [3].adjacentIndex [1] = 4;
		coordinate [3].adjacentIndex [2] = x;

		coordinate [4].adjacentIndex [0] = 3;
		coordinate [4].adjacentIndex [1] = 5;
		coordinate [4].adjacentIndex [2] = 12;

		coordinate [5].adjacentIndex [0] = 4;
		coordinate [5].adjacentIndex [1] = 6;
		coordinate [5].adjacentIndex [2] = x;

		coordinate [6].adjacentIndex [0] = 5;
		coordinate [6].adjacentIndex [1] = 14;
		coordinate [6].adjacentIndex [2] = x;

		coordinate [7].adjacentIndex [0] = 8;
		coordinate [7].adjacentIndex [1] = 17;
		coordinate [7].adjacentIndex [2] = x;

		coordinate [8].adjacentIndex [0] = 0;
		coordinate [8].adjacentIndex [1] = 7;
		coordinate [8].adjacentIndex [2] = 9;

		coordinate [9].adjacentIndex [0] = 8;
		coordinate [9].adjacentIndex [1] = 10;
		coordinate [9].adjacentIndex [2] = 19;

		coordinate [10].adjacentIndex [0] = 2;
		coordinate [10].adjacentIndex [1] = 9;
		coordinate [10].adjacentIndex [2] = 11;
		
		coordinate [11].adjacentIndex [0] = 10;
		coordinate [11].adjacentIndex [1] = 12;
		coordinate [11].adjacentIndex [2] = 21;
		
		coordinate [12].adjacentIndex [0] = 4;
		coordinate [12].adjacentIndex [1] = 11;
		coordinate [12].adjacentIndex [2] = 13;
		
		coordinate [13].adjacentIndex [0] = 12;
		coordinate [13].adjacentIndex [1] = 14;
		coordinate [13].adjacentIndex [2] = 23;
		
		coordinate [14].adjacentIndex [0] = 6;
		coordinate [14].adjacentIndex [1] = 13;
		coordinate [14].adjacentIndex [2] = 15;
		
		coordinate [15].adjacentIndex [0] = 14;
		coordinate [15].adjacentIndex [1] = 25;
		coordinate [15].adjacentIndex [2] = x;
		
		coordinate [16].adjacentIndex [0] = 17;
		coordinate [16].adjacentIndex [1] = 27;
		coordinate [16].adjacentIndex [2] = x;
		
		coordinate [17].adjacentIndex [0] = 7;
		coordinate [17].adjacentIndex [1] = 16;
		coordinate [17].adjacentIndex [2] = 18;
		
		coordinate [18].adjacentIndex [0] = 17;
		coordinate [18].adjacentIndex [1] = 19;
		coordinate [18].adjacentIndex [2] = 29;
		
		coordinate [19].adjacentIndex [0] = 9;
		coordinate [19].adjacentIndex [1] = 18;
		coordinate [19].adjacentIndex [2] = 20;

		coordinate [20].adjacentIndex [0] = 19;
		coordinate [20].adjacentIndex [1] = 21;
		coordinate [20].adjacentIndex [2] = 31;
		
		coordinate [21].adjacentIndex [0] = 11;
		coordinate [21].adjacentIndex [1] = 20;
		coordinate [21].adjacentIndex [2] = 22;
		
		coordinate [22].adjacentIndex [0] = 21;
		coordinate [22].adjacentIndex [1] = 23;
		coordinate [22].adjacentIndex [2] = 33;
		
		coordinate [23].adjacentIndex [0] = 13;
		coordinate [23].adjacentIndex [1] = 22;
		coordinate [23].adjacentIndex [2] = 24;
		
		coordinate [24].adjacentIndex [0] = 23;
		coordinate [24].adjacentIndex [1] = 25;
		coordinate [24].adjacentIndex [2] = 35;
		
		coordinate [25].adjacentIndex [0] = 15;
		coordinate [25].adjacentIndex [1] = 24;
		coordinate [25].adjacentIndex [2] = 26;
		
		coordinate [26].adjacentIndex [0] = 25;
		coordinate [26].adjacentIndex [1] = 37;
		coordinate [26].adjacentIndex [2] = x;
		
		coordinate [27].adjacentIndex [0] = 16;
		coordinate [27].adjacentIndex [1] = 28;
		coordinate [27].adjacentIndex [2] = x;
		
		coordinate [28].adjacentIndex [0] = 27;
		coordinate [28].adjacentIndex [1] = 29;
		coordinate [28].adjacentIndex [2] = 38;
		
		coordinate [29].adjacentIndex [0] = 27;
		coordinate [29].adjacentIndex [1] = 29;
		coordinate [29].adjacentIndex [2] = 38;

		coordinate [30].adjacentIndex [0] = 29;
		coordinate [30].adjacentIndex [1] = 31;
		coordinate [30].adjacentIndex [2] = 40;
		
		coordinate [31].adjacentIndex [0] = 20;
		coordinate [31].adjacentIndex [1] = 30;
		coordinate [31].adjacentIndex [2] = 32;
		
		coordinate [32].adjacentIndex [0] = 31;
		coordinate [32].adjacentIndex [1] = 33;
		coordinate [32].adjacentIndex [2] = 42;
		
		coordinate [33].adjacentIndex [0] = 22;
		coordinate [33].adjacentIndex [1] = 32;
		coordinate [33].adjacentIndex [2] = 34;
		
		coordinate [34].adjacentIndex [0] = 33;
		coordinate [34].adjacentIndex [1] = 35;
		coordinate [34].adjacentIndex [2] = 44;
		
		coordinate [35].adjacentIndex [0] = 24;
		coordinate [35].adjacentIndex [1] = 34;
		coordinate [35].adjacentIndex [2] = 36;
		
		coordinate [36].adjacentIndex [0] = 35;
		coordinate [36].adjacentIndex [1] = 37;
		coordinate [36].adjacentIndex [2] = 46;
		
		coordinate [37].adjacentIndex [0] = 26;
		coordinate [37].adjacentIndex [1] = 36;
		coordinate [37].adjacentIndex [2] = x;
		
		coordinate [38].adjacentIndex [0] = 28;
		coordinate [38].adjacentIndex [1] = 39;
		coordinate [38].adjacentIndex [2] = x;
		
		coordinate [39].adjacentIndex [0] = 38;
		coordinate [39].adjacentIndex [1] = 40;
		coordinate [39].adjacentIndex [2] = 47;

		coordinate [40].adjacentIndex [0] = 30;
		coordinate [40].adjacentIndex [1] = 39;
		coordinate [40].adjacentIndex [2] = 41;
		
		coordinate [41].adjacentIndex [0] = 40;
		coordinate [41].adjacentIndex [1] = 42;
		coordinate [41].adjacentIndex [2] = 49;
		
		coordinate [42].adjacentIndex [0] = 32;
		coordinate [42].adjacentIndex [1] = 41;
		coordinate [42].adjacentIndex [2] = 43;
		
		coordinate [43].adjacentIndex [0] = 42;
		coordinate [43].adjacentIndex [1] = 44;
		coordinate [43].adjacentIndex [2] = 51;
		
		coordinate [44].adjacentIndex [0] = 34;
		coordinate [44].adjacentIndex [1] = 43;
		coordinate [44].adjacentIndex [2] = 45;
		
		coordinate [45].adjacentIndex [0] = 44;
		coordinate [45].adjacentIndex [1] = 46;
		coordinate [45].adjacentIndex [2] = 53;
		
		coordinate [46].adjacentIndex [0] = 36;
		coordinate [46].adjacentIndex [1] = 45;
		coordinate [46].adjacentIndex [2] = x;
		
		coordinate [47].adjacentIndex [0] = 39;
		coordinate [47].adjacentIndex [1] = 48;
		coordinate [47].adjacentIndex [2] = x;
		
		coordinate [48].adjacentIndex [0] = 47;
		coordinate [48].adjacentIndex [1] = 49;
		coordinate [48].adjacentIndex [2] = x;
		
		coordinate [49].adjacentIndex [0] = 41;
		coordinate [49].adjacentIndex [1] = 48;
		coordinate [49].adjacentIndex [2] = 50;

		coordinate [50].adjacentIndex [0] = 49;
		coordinate [50].adjacentIndex [1] = 51;
		coordinate [50].adjacentIndex [2] = x;
		
		coordinate [51].adjacentIndex [0] = 43;
		coordinate [51].adjacentIndex [1] = 50;
		coordinate [51].adjacentIndex [2] = 52;
		
		coordinate [52].adjacentIndex [0] = 51;
		coordinate [52].adjacentIndex [1] = 53;
		coordinate [52].adjacentIndex [2] = x;
		
		coordinate [53].adjacentIndex [0] = 45;
		coordinate [53].adjacentIndex [1] = 52;
		coordinate [53].adjacentIndex [2] = x;
	}


	void AssignTerrain(Tiles.TerrainType newTerrain)
	{
		for(int i = 0; i < 19; i++)
		{
			tile[i].terrain = newTerrain;
		}

		//Randomize the terrain on each tile
//		int rand = new int();
//		
//		for(int i = 0; i < 19; i++)
//		{
//			rand = Random.Range (0,3);
//
//			if(rand == 0)
//				tile[i].terrain = Tiles.TerrainType.grass;
//			else if(rand == 1)
//				tile[i].terrain = Tiles.TerrainType.desert;
//			else
//				tile[i].terrain = Tiles.TerrainType.dirt;
//		}
	}


	void AssignTileSprite()
	{
		Tiles.TerrainType terrain;

		for(int i = 0; i < 19; i++)
		{
			terrain = tile [i].terrain;
			switch(tile[i].resource)
			{
			case Tiles.ResourceType.minerals:
				if(terrain == Tiles.TerrainType.grass)
				{
					tile[i].spriteRenderer.sprite = TileSprites.grassSprites[0];
				}
				else if(terrain == Tiles.TerrainType.desert)
				{
					tile[i].spriteRenderer.sprite = TileSprites.desertSprites[0];
				}
				else
				{
					tile[i].spriteRenderer.sprite = TileSprites.dirtSprites[0];
				}
				break;
			case Tiles.ResourceType.vespene:
				if(terrain == Tiles.TerrainType.grass)
				{
					tile[i].spriteRenderer.sprite = TileSprites.grassSprites[1];
				}
				else if(terrain == Tiles.TerrainType.desert)
				{
					tile[i].spriteRenderer.sprite = TileSprites.desertSprites[1];
				}
				else
				{
					tile[i].spriteRenderer.sprite = TileSprites.dirtSprites[1];
				}
				break;
			case Tiles.ResourceType.gold:
				if(terrain == Tiles.TerrainType.grass)
				{
					tile[i].spriteRenderer.sprite = TileSprites.grassSprites[2];
				}
				else if(terrain == Tiles.TerrainType.desert)
				{
					tile[i].spriteRenderer.sprite = TileSprites.desertSprites[2];
				}
				else
				{
					tile[i].spriteRenderer.sprite = TileSprites.dirtSprites[2];
				}
				break;
			case Tiles.ResourceType.silver:
				if(terrain == Tiles.TerrainType.grass)
				{
					tile[i].spriteRenderer.sprite = TileSprites.grassSprites[3];
				}
				else if(terrain == Tiles.TerrainType.desert)
				{
					tile[i].spriteRenderer.sprite = TileSprites.desertSprites[3];
				}
				else
				{
					tile[i].spriteRenderer.sprite = TileSprites.dirtSprites[3];
				}
				break;
			case Tiles.ResourceType.water:
				if(terrain == Tiles.TerrainType.grass)
				{
					tile[i].spriteRenderer.sprite = TileSprites.grassSprites[4];
				}
				else if(terrain == Tiles.TerrainType.desert)
				{
					tile[i].spriteRenderer.sprite = TileSprites.desertSprites[4];
				}
				else
				{
					tile[i].spriteRenderer.sprite = TileSprites.dirtSprites[4];
				}
				break;
			case Tiles.ResourceType.space:
				if(terrain == Tiles.TerrainType.grass)
				{
					tile[i].spriteRenderer.sprite = TileSprites.grassSprites[5];
				}
				else if(terrain == Tiles.TerrainType.desert)
				{
					tile[i].spriteRenderer.sprite = TileSprites.desertSprites[5];
				}
				else
				{
					tile[i].spriteRenderer.sprite = TileSprites.dirtSprites[5];
				}
				break;
			default:
				if(terrain == Tiles.TerrainType.grass)
				{
					tile[i].spriteRenderer.sprite = TileSprites.grassSprites[6];
				}
				else if(terrain == Tiles.TerrainType.desert)
				{
					tile[i].spriteRenderer.sprite = TileSprites.desertSprites[6];
				}
				else
				{
					tile[i].spriteRenderer.sprite = TileSprites.dirtSprites[6];
				}
				break;
			}

		}
	}


	void AssignDefaultResources()
	{
		tile [0].AssignResource (3);	
		tile [1].AssignResource (2);
		tile [2].AssignResource (1);
		tile [3].AssignResource (3);
		tile [4].AssignResource (2);
		tile [5].AssignResource (4);
		tile [6].AssignResource (2);
		tile [7].AssignResource (4);
		tile [8].AssignResource (1);
		tile [9].AssignResource (0);
		tile [10].AssignResource (5);
		tile [11].AssignResource (0);
		tile [12].AssignResource (4);
		tile [13].AssignResource (4);
		tile [14].AssignResource (1);
		tile [15].AssignResource (0);
		tile [16].AssignResource (3);
		tile [17].AssignResource (1);
		tile [18].AssignResource (2);
	}

	void AssignRandomResources()		//Broken (ResourceNullException)??
	{
		int[] resourceArray = new int[19];
		resourceArray = randomizer.RandomizeResources ();

		for(int i = 0; i < 19; i++)
		{
			tile[i].AssignResource(resourceArray[i]);
		}
	}

	void AssignDefaultTileNumbers()
	{	//two = 0, three=1, four=2, five=3, six=4, eight=5, nine=6, ten=7, eleven=8, twelve=9
		tile [0].AssignTileNumber (3);// = 5;
		tile[1].AssignTileNumber (0);// = 2;
		tile[2].AssignTileNumber (4);// = 6;
		tile[3].AssignTileNumber (1);// = 3;
		tile[4].AssignTileNumber (5);// = 8;
		tile[5].AssignTileNumber (7);// = 10;
		tile[6].AssignTileNumber (6);// = 9;
		tile[7].AssignTileNumber (9);// = 12;
		tile[8].AssignTileNumber (8);// = 11;
		tile[9].AssignTileNumber (2);// = 4;
		tile[10].AssignTileNumber (999);// = 0;
		tile[11].AssignTileNumber (5);// = 8;
		tile[12].AssignTileNumber (7);// = 10;
		tile[13].AssignTileNumber (6);// = 9;
		tile[14].AssignTileNumber (2);// = 4;
		tile[15].AssignTileNumber (3);// = 5;
		tile[16].AssignTileNumber (4);// = 6;
		tile[17].AssignTileNumber (1);// = 3;
		tile[18].AssignTileNumber (8);// = 11;
	}

	void AssignRandomTileNumbers()
	{
		int[] tileNumArray = new int[18];
		tileNumArray = randomizer.RandomizeTileNumbers ();
		int tileIndex = 0;
		//add check against desert tile and skip that tile for assigning a numeric value or set it to 999

		for(int i = 0; i < 18; i++)
		{
			if(tile[tileIndex].resource == Tiles.ResourceType.space)		//check if any tile is the space tile
			{
				tile[tileIndex].AssignTileNumber(999);
				tileIndex++;
			}

			tile[tileIndex].AssignTileNumber(tileNumArray[i]);
			tileIndex++;
		}
	}

//	public int GetDiceResults()
//	{
//		DiceController dice;// = GetComponent<DiceController> ();
//		int diceResults;
//		diceResults = dice.RollDice ();
//
//		return diceResults;
//	}
}
