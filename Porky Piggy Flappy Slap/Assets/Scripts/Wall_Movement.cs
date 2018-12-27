using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Movement : MonoBehaviour
{

    public GameObject Wall;
    private float time;
    public float wallX;

    // Update is called once per frame
    void Update()
    {
        CreateWall();
    }

    void CreateWall()
    {
        time += Time.deltaTime;
        if (time > 1)
        {
            GameObject wallBottom = Instantiate(Wall);
            GameObject wallTop = Instantiate(Wall);
            wallBottom.transform.position = new Vector2(15, Random.Range(-7, -1));
            wallBottom.GetComponent<Rigidbody2D>().velocity = new Vector2(wallX, 0);
            wallTop.transform.position = new Vector2(15, wallBottom.transform.position.y + 10);
            wallTop.GetComponent<Rigidbody2D>().velocity = new Vector2(wallX, 0);
            time = 0;
        }
        
    }
}
