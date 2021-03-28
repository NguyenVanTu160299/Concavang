using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public float lifetime = 8f;
    public GameObject impactEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
    
        Enemy enemy = collision.GetComponent<Enemy>();
        Enemy1 enemy1 = collision.GetComponent<Enemy1>();
        Enemy2 enemy2 = collision.GetComponent<Enemy2>();
        Enemyboss enemyboss = collision.GetComponent<Enemyboss>();
        if (enemy != null)
            {
              enemy.TakeDamage(20);
            
        }
             else if (enemy1 != null){
            enemy1.TakeDamage(20);
        }
            else if (enemy2 != null)
        {
            enemy2.TakeDamage(20);
        }
        else if(enemyboss != null)
        {
            enemyboss.TakeDamage(20);
        }
           GameObject destroyffect = Instantiate(impactEffect, transform.position, Quaternion.identity);
        Destroy(destroyffect, 0.2f);
          Destroy(gameObject);
     

    }
    //private void Update()
    //{
    //    //    lifetime -= Time.deltaTime;
    //    //    if (lifetime <= 0)
    //    //    {
    //    //        Destroy(gameObject);
    //    //    }
    //}
}
