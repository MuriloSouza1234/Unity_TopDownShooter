using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOut : MonoBehaviour
{
    private float upperOffScreen = 50;
    private float lowerOffScreen = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.z > upperOffScreen)
        {
           Destroy(gameObject);
        } 
        else if (transform.position.z < lowerOffScreen)
        {
            Debug.Log("GAME OVER!");
            Destroy(gameObject);
        }
    }
}
