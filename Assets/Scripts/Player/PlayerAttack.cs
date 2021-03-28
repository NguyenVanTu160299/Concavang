using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attackdelay = 0.3f;
    public bool attacking = false;

    public Animator anim;

    public Collider2D trigger;

    private void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
        trigger.enabled = false;
    }


    // Update is called once per frame
    void Update()
    {
        Attacking();
        Attacking1();
        Attacking2();
        //if (Input.GetKeyDown(KeyCode.Z) && !attacking)
        //{
        //    attacking = true;
        //    trigger.enabled = true;
        //    attackdelay = 0.3f;
        //}

        //if (attacking)
        //{
        //    if (attackdelay > 0)
        //    {
        //        attackdelay -= Time.deltaTime;

        //    }
        //    else
        //    {
        //        attacking = false;
        //        trigger.enabled = false;
        //    }
        //}

        //anim.SetBool("Attacking", attacking);

    }
    void Attacking()
    {
        if (Input.GetKeyDown(KeyCode.R) && !attacking)
        {
            attacking = true;
            trigger.enabled = true;
            attackdelay = 0.3f;
        }

        if (attacking)
        {
            if (attackdelay > 0)
            {
                attackdelay -= Time.deltaTime;

            }
            else
            {
                attacking = false;
                trigger.enabled = false;
            }
        }

        anim.SetBool("Attacking", attacking);

    }
    void Attacking1()
    {
        if (Input.GetKeyDown(KeyCode.W) && !attacking)
        {
            attacking = true;
            trigger.enabled = true;
            attackdelay = 0.3f;
        }

        if (attacking)
        {
            if (attackdelay > 0)
            {
                attackdelay -= Time.deltaTime;

            }
            else
            {
                attacking = false;
                trigger.enabled = false;
            }
        }

        anim.SetBool("Attacking1", attacking);

    }
    void Attacking2()
    {
        if (Input.GetKeyDown(KeyCode.E) && !attacking)
        {
            attacking = true;
            trigger.enabled = true;
            attackdelay = 0.3f;
        }

        if (attacking)
        {
            if (attackdelay > 0)
            {
                attackdelay -= Time.deltaTime;

            }
            else
            {
                attacking = false;
                trigger.enabled = false;
            }
        }

        anim.SetBool("Attacking2", attacking);

    }
}
