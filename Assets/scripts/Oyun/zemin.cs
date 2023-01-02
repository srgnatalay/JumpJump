using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class zemin : MonoBehaviour
{
    public float zýplamakuvveti;
    public bool zeminetemasedildi;
    int zýplatanzeminihtimali;
     Animator anim;
    AudioSource audiosource;

    private void Start()
    {
        anim = GetComponent<Animator>();
        zýplatanzeminihtimali = Random.Range(1, 11);
        audiosource = GetComponent<AudioSource>();

        if (zýplatanzeminihtimali == 1)
        {
            anim.SetBool("ZýplatanZemin", true);
            zýplamakuvveti = 25f;
            

        }
        else
        {
            zýplamakuvveti = 19f;
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                
                Vector2 zýpalamavelocity = rb.velocity;
                zýpalamavelocity.y = zýplamakuvveti;
                rb.velocity = zýpalamavelocity;

                if(zeminetemasedildi == false)
                {
                   
                    Yönetici.scoresayýsý++;
                    zeminetemasedildi = true;
                    
                }
                
            }
            anim.SetBool("TemasEdildi", true);
            audiosource.Play();
            Destroy(gameObject,1.5f);
        }

    }
   
}
