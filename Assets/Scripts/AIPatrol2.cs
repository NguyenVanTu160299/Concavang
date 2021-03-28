using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPatrol2 : MonoBehaviour
{

    public float walkSpeed;
    public float range, timeBTWShots, shootSpeed;
    private float distToPlayer;

    [HideInInspector]
    public bool mustPatrol;
    private bool mustTurn;
    private bool canShoot;

    public Rigidbody2D rb;
    public Transform groundCheckPos;
    public LayerMask groundLayer;
    public Collider2D bodyCollider;
    public Transform player, shootPos,shootPos1;
    public GameObject bullet;
    public AudioSource aus;
    public AudioClip shootingSoundEn;
    void Start()
    {
        mustPatrol = true;
        canShoot = true;
    }

    void Update()
    {
        if (mustPatrol || bodyCollider.IsTouchingLayers(groundLayer))
        {
            Patrol();
        }

        distToPlayer = Vector2.Distance(transform.position, player.position);

        if (distToPlayer <= range)
        {
            if (player.position.x > transform.position.x && transform.localScale.x < 0
                || player.position.x < transform.position.x && transform.localScale.x > 0)
            {
                Flip();
            }

            mustPatrol = false;
            rb.velocity = Vector2.zero;

            if (canShoot)
                StartCoroutine(Shoot1());
        }
        else
        {
            mustPatrol = true;
        }
    }
    private void FixedUpdate()
    {
        if (mustPatrol)
        {
            mustTurn = !Physics2D.OverlapCircle(groundCheckPos.position, 0.1f, groundLayer);
        }
    }
    void Patrol()
    {
        if (mustTurn || bodyCollider.IsTouchingLayers(groundLayer))
        {
            Flip();
        }

        rb.velocity = new Vector2(walkSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }

    void Flip()
    {
        mustPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        walkSpeed *= -1;
        mustPatrol = true;
    }

    IEnumerator Shoot1()
    {
        canShoot = false;

        yield return new WaitForSeconds(timeBTWShots);
        GameObject newBullet = Instantiate(bullet, shootPos.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(shootSpeed * walkSpeed * Time.fixedDeltaTime, 0f);
        GameObject newBullet1 = Instantiate(bullet, shootPos1.position, Quaternion.identity);
        newBullet1.GetComponent<Rigidbody2D>().velocity = new Vector2(shootSpeed * walkSpeed * Time.fixedDeltaTime, 0f);
        if (aus && shootingSoundEn)
        {
            aus.PlayOneShot(shootingSoundEn);
        }
        Debug.Log("Shoot");
        canShoot = true;

    }
}