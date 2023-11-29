using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    Animator ani;
    Movement playerMove;
    float movespeed;
    private void Start()
    {
        ani = GetComponent<Animator>();
        playerMove = GetComponent<Movement>();
        movespeed = playerMove.speed;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            ani.SetBool("walk", true);
        }
        else
        {
            ani.SetBool("walk", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ani.SetBool("jump", true);
        }
        else
        {
            ani.SetBool("jump", false);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            ani.SetBool("slide", true);
            playerMove.speed = movespeed + 5;
        }
        else
        {
            ani.SetBool("slide", false);
            playerMove.speed = movespeed;

            if (Input.GetMouseButton(0))
            {
                ani.SetBool("attack", true);
            }
            else
            {
                ani.SetBool("attack", false);
            }
        }
    }
}
