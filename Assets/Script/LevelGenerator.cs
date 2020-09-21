using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    private Vector3 rotateAngle;
    private int rows = 15;
    private int cols = 14;
    private float tileSize = 1;
    int[,] levelMap = { { 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 7 }, { 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 4 }, { 2, 5, 3, 4, 4, 3, 5, 3, 4, 4, 4, 3, 5, 4 }, { 2, 6, 4, 0, 0, 4, 5, 4, 0, 0, 0, 4, 5, 4 }, { 2, 5, 3, 4, 4, 3, 5, 3, 4, 4, 4, 3, 5, 3 }, { 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, { 2, 5, 3, 4, 4, 3, 5, 3, 3, 5, 3, 4, 4, 4 }, { 2, 5, 3, 4, 4, 3, 5, 4, 4, 5, 3, 4, 4, 3 }, { 2, 5, 5, 5, 5, 5, 5, 4, 4, 5, 5, 5, 5, 4 }, { 1, 2, 2, 2, 2, 1, 5, 4, 3, 4, 4, 3, 0, 4 }, { 0, 0, 0, 0, 0, 2, 5, 4, 3, 4, 4, 3, 0, 3 }, { 0, 0, 0, 0, 0, 2, 5, 4, 4, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 2, 5, 4, 4, 0, 3, 4, 4, 0 }, { 2, 2, 2, 2, 2, 1, 5, 3, 3, 0, 4, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 5, 0, 0, 0, 4, 0, 0, 0 }, };
    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
        rotateAngle = new Vector2(90.0f, 90.0f);

    }

    private void GenerateGrid()
    {
        GameObject refTile = (GameObject)Instantiate(Resources.Load("OutsideLine_2"));
        GameObject refTile1 = (GameObject)Instantiate(Resources.Load("OutsideLine_2"));
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (levelMap[i, j] == 2)
                {

                    GameObject tile = (GameObject)Instantiate(refTile, transform);
                    float posx = j * tileSize;
                    float posy = i * -tileSize;
                    tile.transform.position = new Vector2(posx, posy);

                }
                else
                {
                    GameObject tile = (GameObject)Instantiate(refTile1, transform);
                    float posx = j * tileSize;
                    float posy = i * -tileSize;
                    tile.transform.position = new Vector2(posx, posy);
                }
            }
        }
        Destroy(refTile);

        float gridW = cols * tileSize;
        float gridH = rows * tileSize;
        transform.position = new Vector2(-gridW / 2 + tileSize / 2, gridH / 2 - tileSize / 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
