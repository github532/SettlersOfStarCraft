using UnityEngine;
using System.Collections;

public class TileManager : MonoBehaviour
{

    //public int animState = 0;
    //private Animator animator;
	
    //int nextTile = 0;
	
    public Tiles[] standardTiles = new Tiles[19];	//3-4 player standard tile number

    // Use this for initialization	
    void Start()
    {
//        foreach (Tiles tile[] in standardTiles)
//		//for(int i = 0; i < MAX_TILES; i++)
//        {
//            //TileName = nextTile;
//			tile = GameObject.FindGameObjectWithTag("Tile");
//			tile[nextTile].name = TileNames[nextTile];
//			SetResource(tile[nextTile]);
//			nextTile++;
//            if (nextTile > 2)
//                nextTile = 0;
//            //random resource assignment script
//            //int i = 0;
//            //tile.name = gameBoard.GetComponentInChildren <Tiles> ().name;
//
//        }

        //animator = GetComponent<Animator>();
        //standardTiles = GetComponent <Tiles>();
    }

    // Update is called once per frame
    void Update()
    {

        /*if (gameBoard == null)
            Debug.Log ("gameboard not found");
        else
            Debug.Log ("Gameboard found");
			
        animator.SetInteger ("AnimState", (int)animState);*/
    }

	void SetResource(GameObject tile)
	{
		//tile.resource = tile.ResourceType.Minerals;
	}
}

///////////Sample code to access game objects of a certain type//////////

//		foreach (var gameObj in FindObjectsOfType(typeof(GameObject)) as GameObject[])
//		{
//			if(gameObj.name == "bar")
//			{
//				//Do something...
//			}
//		}