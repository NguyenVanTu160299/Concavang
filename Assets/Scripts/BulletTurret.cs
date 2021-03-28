using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTurret : MonoBehaviour
{
    public float lifetime = 2;
    public GameObject impactEffect;
    //public AudioSource aus;
    //public AudioClip shootingSoundEn;

    void Start()
    {

    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.isTrigger == false)
        {
            if (col.CompareTag("Player"))
            {
                //if(aus && shootingSoundEn)
                //{
                //    aus.PlayOneShot(shootingSoundEn);
                //}
                col.SendMessageUpwards("Damage", 1);
            }
        }
        GameObject destroyEffect = Instantiate(impactEffect, transform.position, Quaternion.identity);
        Destroy(destroyEffect, 0.3f);
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