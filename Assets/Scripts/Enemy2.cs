using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public int heath = 100;
    public GameObject deathEffect;
    public gamemaster2 gm;
    //public GameObject gamewin;
    // Start is called before the first frame update
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("gamemaster2").GetComponent<gamemaster2>();
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
        Destroy(gameObject);
        //gamewin.SetActive(true);
        gm.points += 1;
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
