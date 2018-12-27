using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public GameObject Wall;
 
    public float jumpPower = 1000;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        CreateWall();
    }

    void CreateWall()
    {
        time += Time.deltaTime;
        if (time > 1)
        {
            GameObject Wall2 = Instantiate(Wall);
            Wall2.GetComponent
            time = 0;
        }
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpPower);
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
