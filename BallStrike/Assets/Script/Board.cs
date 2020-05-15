using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public int width;
    public int height;
    public GameObject tilePrefab;
    public GameObject Collectables;
   

    void Awake()
    {
        SetUp();      
    }

    private void SetUp()
    {
            for ( int i = -2; i < width -2 ; i++)
            {
                for ( int j = -1; j < height ; j++)
                {

                    Vector2 tempPosition = new Vector2(i, j);
                    GameObject backgroundTile = Instantiate(tilePrefab, tempPosition, Quaternion.identity);
                    Tile tile = backgroundTile.GetComponent<Tile>();
                    tile.Xpos = i;
                    tile.Ypos = j;
                    tile.isSpawned = false;
                    backgroundTile.transform.parent = this.transform;
                    backgroundTile.name = "(" + i + "," + j + ")";                   
                }
            }        
    }

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        bool flag = true;
        int count = 0;
        while(flag)
        {
            int index = Random.Range(0, this.transform.childCount);
            Tile tile = this.transform.GetChild(index).GetComponent<Tile>();
            int xpos = tile.Xpos;
            int ypos = tile.Ypos;
            if(!tile.isSpawned)
            {
                GameObject bgs = Instantiate(Collectables, new Vector3(xpos, ypos, 0), Quaternion.identity);
                bgs.name = "(" + xpos + "," + ypos + ")";
                count++;
                tile.isSpawned = true;
            }
            
            yield return new WaitForSeconds(2.0f);
            if (count >= this.transform.childCount)
                flag = false;

        }
    }   
}
