using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if(Input.GetKey(KeyCode.W))
        { 
            transform.Translate(0, 0, 1 * moveSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1 * moveSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -1 * moveSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(1 * moveSpeed, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = moveSpeed * 2;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = moveSpeed / 2;
        }
    }
}
