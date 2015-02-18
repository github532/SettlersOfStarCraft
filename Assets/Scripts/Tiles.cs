using UnityEngine;
using System.Collections;

public class Tiles : MonoBehaviour
{
	public enum TerrainType {grass = 0, desert, dirt};
	public TerrainType terrain = TerrainType.desert;

    public enum ResourceType { none = 0, minerals, vespene, gold, silver, water, space};
    public ResourceType resource = ResourceType.none;

	public enum TileNumber {two = 0, three, four, five, six, eight, nine, ten, eleven, twelve, none};
	public TileNumber tileNumber;

	public int[] adjacentCoordIndex = new int[6];

	TileSprites tileSprite;
	public Sprite sprite;
	public SpriteRenderer spriteRenderer;

    //private Animator animator;
    public int animState = 0;

    //public float speed = 10f;
    //public Vector3 rotation;
    //public Vector2 maxVelocity = new Vector2(3, 5);
    //public bool standing;
    //public float speedMultiplier = .3f;	

    void Start()
    {
		spriteRenderer = GetComponent<SpriteRenderer> ();

    }

    // Update is called once per frame
    void Update()
    {

    }

	public void SetAdjacentCoords(int a, int b, int c, int d, int e, int f)
	{
		adjacentCoordIndex [0] = a;
		adjacentCoordIndex [1] = b;
		adjacentCoordIndex [2] = c;
		adjacentCoordIndex [3] = d;
		adjacentCoordIndex [4] = e;
		adjacentCoordIndex [5] = f;
	}

	public void AssignResource(int resourceType)
	{
		switch(resourceType)
		{
		case 0:
			resource = ResourceType.minerals;
			break;
		case 1:
			resource = ResourceType.vespene;
			break;
		case 2:
			resource = ResourceType.gold;
			break;
		case 3:
			resource = ResourceType.silver;
			break;
		case 4:
			resource = ResourceType.water;
			break;
		case 5:
			resource = ResourceType.space;
			break;
		default:
			resource = ResourceType.none;
			break;
		}
	}


	public void AssignTileNumber(int tileNum)
	{		//two = 0, three, four, five, six, eight, nine, ten, eleven, twelve
		switch(tileNum)
		{
		case 0:
			tileNumber = TileNumber.two;
			break;
		case 1:
			tileNumber = TileNumber.three;
			break;
		case 2:
			tileNumber = TileNumber.four;
			break;
		case 3:
			tileNumber = TileNumber.five;
			break;
		case 4:
			tileNumber = TileNumber.six;
			break;
		case 5:
			tileNumber = TileNumber.eight;
			break;
		case 6:
			tileNumber = TileNumber.nine;
			break;
		case 7:
			tileNumber = TileNumber.ten;
			break;
		case 8:
			tileNumber = TileNumber.eleven;
			break;
		case 9:
			tileNumber = TileNumber.twelve;
			break;
		case 999:
			tileNumber = TileNumber.none;
			break;
		default:
			tileNumber = TileNumber.none;
			break;
		}
	}

	public void SetSprite(Sprite sprite)
	{

	}
}
