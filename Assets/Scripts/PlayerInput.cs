using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInput : MonoBehaviour
{
    // move
    void Move()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire1 Click");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
