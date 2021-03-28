using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPlayer : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public AudioSource aus;
    public AudioClip shootingSound;
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    Shoot();
        //}
    }
  public void Shoot()
    {
        if(aus && shootingSound)
        {
            aus.PlayOneShot(shootingSound);
        }
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
