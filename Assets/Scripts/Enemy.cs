using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int heath = 100;
    public GameObject deathEffect;
    public gamemaster gm;
    public AudioSource aus;
    public AudioClip shootingSoundDeath;
    //public GameObject gameWin;
    // Start is called before the first frame update
    private void Start()
    {
      gm = GameObject.FindGameObjectWithTag("gamemaster").GetComponent<gamemaster>();
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
        GameObject deatheffect =  Instantiate(deathEffect, transform.position, Quaternion.identity);
      Destroy(deatheffect, 0.3f);
      if(aus && shootingSoundDeath)
        {
            aus.PlayOneShot(shootingSoundDeath);
        }
        Destroy(gameObject);
        gm.points += 1;
        //gameWin.SetActive(true);
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
