using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{   
    public float dieTime, damage;
    public GameObject dieEffect;
void Start()
    {
        StartCoroutine(CountDownTimer());
        //Destroy(gameObject);

    }
    void OnCollisionEnter2D(Collision2D col)
    {
       
    }
    IEnumerator CountDownTimer()
    {
        yield return new WaitForSeconds(dieTime);
    
    }
  
}

