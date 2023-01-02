using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class zemin : MonoBehaviour
{
    public float z�plamakuvveti;
    public bool zeminetemasedildi;
    int z�platanzeminihtimali;
     Animator anim;
    AudioSource audiosource;

    private void Start()
    {
        anim = GetComponent<Animator>();
        z�platanzeminihtimali = Random.Range(1, 11);
        audiosource = GetComponent<AudioSource>();

        if (z�platanzeminihtimali == 1)
        {
            anim.SetBool("Z�platanZemin", true);
            z�plamakuvveti = 25f;
            

        }
        else
        {
            z�plamakuvveti = 19f;
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                
                Vector2 z�palamavelocity = rb.velocity;
                z�palamavelocity.y = z�plamakuvveti;
                rb.velocity = z�palamavelocity;

                if(zeminetemasedildi == false)
                {
                   
                    Y�netici.scoresay�s�++;
                    zeminetemasedildi = true;
                    
                }
                
            }
            anim.SetBool("TemasEdildi", true);
            audiosource.Play();
            Destroy(gameObject,1.5f);
        }

    }
   
}
