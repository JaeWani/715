using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_Animation : MonoBehaviour
{
    Animator ANIM;
    Rigidbody2D RB;
    SpriteRenderer SPR;

    void Start()
    {
        ANIM = GetComponent<Animator>();
        RB = GetComponent<Rigidbody2D>();
        SPR = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        _Animation(RB.velocity.x, RB.velocity.y);
    }
    void _Animation(float veloX, float veloY)
    {
        if (veloX > 0)
        {
            ANIM.SetBool("IsLeft", true);
            SPR.flipX = true;
        }
        else if (veloX < 0)
        {
            ANIM.SetBool("IsLeft", true);
            SPR.flipX = false;
        }
        else
        {
            ANIM.SetBool("IsLeft", false);
            ANIM.SetBool("IsDown", false);
            ANIM.SetBool("IsUp", false);
        }

        if (veloY > 0 && veloX == 0)
        {
            ANIM.SetBool("IsUp", true);
            SPR.flipX = false;
        }
        else if (veloY < 0 && veloX == 0)
        {
            ANIM.SetBool("IsDown", true);
            SPR.flipX = false;
        }
        else
        {
            ANIM.SetBool("IsDown", false);
            ANIM.SetBool("IsUp", false);
        }
    }
}
