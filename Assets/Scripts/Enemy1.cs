using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public int heath = 100;
    public GameObject deathEffect;
    public gamemaster1 gm;
    public AudioSource aus;
    public AudioClip shootingSoundDeath;
    // Start is called before the first frame update
    private void Start()
    {
      gm = GameObject.FindGameObjectWithTag("gamemaster1").GetComponent<gamemaster1>();
    }
    public void TakeDamage(int damage)
    {
        heath -= damage;
        if (heath <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        GameObject deatheffect = Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(deatheffect, 0.3f);

        gm.points += 1;
        Destroy(gameObject);
       
    }
    //private void OnTriggerEnter2D(Collider2D col)
    //{
    //if (col.CompareTag("Enemy1"))
    //{
    //    //Destroy(col.gameObject);
    //    gm.points += 1;
    //}
    //}
}
