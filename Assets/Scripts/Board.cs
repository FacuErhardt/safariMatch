using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public int height, width;
    public GameObject tileObject;

    // Start is called before the first frame update
    void Start()
    {
        SetupBoard();
        PositionCamera();

    }
    private void PositionCamera()
    {
        float newPosX = (float)width / 2f;
        float newPosY = (float)height / 2f;

        Camera.main.transform.position = new Vector3(newPosX -.5f, newPosY-.5f, -10f);
    }

    private void SetupBoard()
    {
        for(int x=0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                var o = Instantiate(
                    tileObject, new Vector3(x, y, -5), Quaternion.identity);
                o.transform.parent = transform;
            }
        }

            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
