using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public Vector2 inputVec;
    public float speed;

    Rigidbody2D rigid;

    // x, y ���� ����
    float minX, maxX, minY, maxY;

    void Start()
    {
        // Stpe 1. �̵� ���� ���� ����
        minY = -9;
        maxY = 9;
        minX = -29.5f;
        maxX = 9.5f;
    }

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        Vector2 nextVec = inputVec * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position+nextVec);
    }

    void LimitToMove()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX),Mathf.Clamp(transform.position.y, minY, maxY));
    }

    void LateUpdate()
    {
        // Step 3. �̵� ����
        LimitToMove();
    }
}
