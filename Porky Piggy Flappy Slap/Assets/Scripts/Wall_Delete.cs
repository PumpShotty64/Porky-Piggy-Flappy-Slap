using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Delete : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Delete();
    }

    void Delete() {
        if (gameObject.transform.position.x < -15) {
            Destroy(gameObject);
        }
    }
}
