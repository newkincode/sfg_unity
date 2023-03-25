using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class PlayerInput : MonoBehaviour
{
    public Vector3 pos;

    // move
    void Move()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += 0.01f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= 0.01f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.y += 0.01f * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.y -= 0.01f * Time.deltaTime;
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
        transform.position = pos;
    }
}
