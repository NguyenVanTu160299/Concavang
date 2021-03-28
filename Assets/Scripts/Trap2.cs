using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap2 : MonoBehaviour
{
    public float freq = 0.5f;
    public float amp = 3f;
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();
    public Playermove player;
    // Start is called before the first frame update
    void Start()
    {
        posOffset = transform.position;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Playermove>();
    }
    // Update is called once per frame
    void Update()
    {
        tempPos = posOffset;
        transform.position = new Vector3(transform.position.x, tempPos.y +
            amp, transform.position.z);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            player.Damage(1);
            player.Knockback(100f, player.transform.position);
        }
    }
}