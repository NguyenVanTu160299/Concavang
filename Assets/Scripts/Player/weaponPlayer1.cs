using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponPlayer1 : MonoBehaviour
{
    public Transform firePoint1;
    public GameObject bulletPrefab1;
    public AudioSource aus;
    public AudioClip shootingSound;
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Fire2"))
        //{
        //    Shoot1();
        //}
    }
   public void Shoot1()
    {
        if (aus && shootingSound)
        {
            aus.PlayOneShot(shootingSound);
        }
        Instantiate(bulletPrefab1, firePoint1.position, firePoint1.rotation);
    }
}
