using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class platform : MonoBehaviour
{
    public bool down = false;
    // Start is called before the first frame update
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            //if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            //  if (collider.CompareTag("down"))
            if (down == true)
           
            gameObject.GetComponent<Collider2D>().enabled = false;
         
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Invoke("Restore", 0.9f);
        }
    }

    void Restore()
    {
        gameObject.GetComponent<Collider2D>().enabled = true;
    }

 public void Down(bool Down)
    {
        down = Down;

    }
}