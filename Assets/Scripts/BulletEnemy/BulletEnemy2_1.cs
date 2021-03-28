using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy2_1 : MonoBehaviour
{
    public float lifetime = 2;
    public GameObject impactEffect;

    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.isTrigger == false)
        {
            if (col.CompareTag("Player"))
            {
                //col.SendMessageUpwards("Damage", 1);
            }

        }
          GameObject destroyeffect =  Instantiate(impactEffect, transform.position, Quaternion.identity);
          Destroy(destroyeffect, 0.3f);
        //GameObject destroyeffect1 = Instantiate(impactEffect, transform.position, Quaternion.identity);
        //Destroy(destroyeffect1, 0.3f);

        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        lifetime -= Time.deltaTime;
        if (lifetime <= 0)
            Destroy(gameObject);
    }
}