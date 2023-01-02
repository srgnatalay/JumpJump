using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class zemin : MonoBehaviour
{
    public float zıplamakuvveti;
    public bool zeminetemasedildi;
    int zıplatanzeminihtimali;
     Animator anim;
    AudioSource audiosource;

    private void Start()
    {
        anim = GetComponent<Animator>();
        zıplatanzeminihtimali = Random.Range(1, 11);
        audiosource = GetComponent<AudioSource>();

        if (zıplatanzeminihtimali == 1)
        {
            anim.SetBool("ZıplatanZemin", true);
            zıplamakuvveti = 25f;
            

        }
        else
        {
            zıplamakuvveti = 19f;
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                
                Vector2 zıpalamavelocity = rb.velocity;
                zıpalamavelocity.y = zıplamakuvveti;
                rb.velocity = zıpalamavelocity;

                if(zeminetemasedildi == false)
                {
                   
                    Yönetici.scoresayısı++;
                    zeminetemasedildi = true;
                    
                }
                
            }
            anim.SetBool("TemasEdildi", true);
            audiosource.Play();
            Destroy(gameObject,1.5f);
        }

    }
   
}
