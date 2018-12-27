using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnStart : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Start_text;
    void Start()
    {

        gameObject.GetComponent<Wall_Movement>().enabled = false;
        gameObject.GetComponent<Movement>().enabled = false;

        gameObject.GetComponent<Score>().enabled = false;
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Wall_Movement>().enabled = true;
            gameObject.GetComponent<Movement>().enabled = true;
            gameObject.GetComponent<Score>().enabled = true;
            gameObject.GetComponent<Rigidbody2D>().gravityScale = 2.5f;
            gameObject.GetComponent<OnStart>().enabled = false;
            Start_text.GetComponent<Text>().text = "";
        }
    }
}
