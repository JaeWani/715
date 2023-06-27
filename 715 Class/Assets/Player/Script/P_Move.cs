using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_Move : MonoBehaviour
{
    Rigidbody2D RB;

    [SerializeField] float Speed;
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        Move();
    }
    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        RB.velocity = (new Vector2(x , y)).normalized * Speed;
    }   
}
