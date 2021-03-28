using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playermove : MonoBehaviour
{
    public float speed = 50f, maxspeed = 3, maxjump = 4, jumpPow = 220f;
    public bool grounded = true, faceright = true, doublejump = false;

    public int ourHealth;
    public int maxhealth;

    public Rigidbody2D r2;
    public Animator anim;
    public gamemaster gm;
    public GameObject gameover;
    public platform platforms;
    public bool down;
    public float h = 0;
    public bool jump = false;
    //public bool pause = false;
    //public Transform player;
    //public GameObject death_anim;
    // Use this for initialization
    void Start()
    {
        r2 = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        //gm = GameObject.FindGameObjectWithTag("gamemaster").GetComponent<gamemaster>();
        ourHealth = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Grounded", grounded);
        anim.SetFloat("Speed", Mathf.Abs(r2.velocity.x));

        if (jump == true)
        {
            if (grounded)
            {
                grounded = false;
                doublejump = true;
                r2.AddForce(Vector2.up * jumpPow);

            }

            else
            {
                StartCoroutine(Djump());
            }

        }
    }

    public IEnumerator Djump()
    {
        yield return new WaitForSeconds(0.5f);
        if (doublejump && jump == true)
        {
            doublejump = false;
            r2.velocity = new Vector2(r2.velocity.x, 0);
            r2.AddForce(Vector2.up * jumpPow * 0.7f);

        }

    }
    public void Jumping(bool Bjump)
    {
        jump = Bjump;

    }

    public void Downs()
    {
        platforms.Down(down);
    }
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        r2.AddForce((Vector2.right) * speed * h);

        if (r2.velocity.x > maxspeed)
            r2.velocity = new Vector2(maxspeed, r2.velocity.y);
        if (r2.velocity.x < -maxspeed)
            r2.velocity = new Vector2(-maxspeed, r2.velocity.y);

        if (r2.velocity.y > maxjump)
            r2.velocity = new Vector2(r2.velocity.x, maxjump);
        if (r2.velocity.y < -maxjump)
            r2.velocity = new Vector2(r2.velocity.x, -maxjump);

        if (h > 0 && !faceright)
        {
            Flip();
        }

        if (h < 0 && faceright)
        {
            Flip();
        }
        if (grounded)
        {
            r2.velocity = new Vector2(r2.velocity.x * 0.7f, r2.velocity.y);
        }

        if (ourHealth <= 0)
        {
            Death();

        }
    }
    //public void Down(bool Down)
    //{
    //    down = Down;

    //}
    public void Flip()
    {
        faceright = !faceright;
        transform.Rotate(0f, 180f, 0f);
    }
    public void Death()
    {
        gameover.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        //if (gameover)
        //{
        //    pause = !pause;

        //}

        //if (pause)
        //{
        //    gameover.SetActive(true);
        //Time.timeScale = 0;
        //}

        //if (pause == false)
        //{
        //    gameover.SetActive(false);
        //    Time.timeScale = 1;
        //}

        // GameObject deatheffect =  Instantiate(death_anim, transform.position, Quaternion.identity);
        //Destroy(deatheffect, 0.1f);
        //Destroy(gameObject);


    }
    public void Damage(int damage)
    {
        //if (ourHealth != 0)
        //{
            ourHealth -= damage;
            gameObject.GetComponent<Animation>().Play("redflash");
        //}
        //else
        //{ 
        //    ourHealth += damage;
        //}
    }
    public void AddHealth(int health)
    {
        if (ourHealth < 10)
        {
            ourHealth += health;
        }
    }
    public void Knockback(float Knockpow, Vector2 Knockdir)
    {
       r2.velocity = new Vector2(0, 0);
        r2.AddForce(new Vector2(Knockdir.x * -100, Knockdir.y + Knockpow));
    }
   //public void Buttonright()
   // {

   // }
   // public void Buttonleft()
   // {

   // }
    //public void Buttonjump()
    //{
    //    anim.SetBool("Grounded", grounded);
    //    anim.SetFloat("Speed", Mathf.Abs(r2.velocity.x));
    //    {
    //        if (grounded)
    //        {
    //            grounded = false;
    //            doublejump = true;
    //            r2.AddForce(Vector2.up * jumpPow);

    //        }
    //        else
    //        {
    //            if (doublejump)
    //            {
    //                doublejump = false;
    //                r2.velocity = new Vector2(r2.velocity.x, 0);
    //                r2.AddForce(Vector2.up * jumpPow * 0.7f);
    //            }
    //        }
    //    }
    //}
}
