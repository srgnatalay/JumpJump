using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Playerhareket : MonoBehaviour
{
    

    [SerializeField] private Joystick joy;
    public float harekterh�z�;
    private float yatayh�z;
    
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {
        float yatayh�z = joy.Horizontal;
        rb.velocity = new Vector2(yatayh�z * harekterh�z� * Time.deltaTime, rb.velocity.y);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Asit")
        {
            SceneManager.LoadScene(2);
           
        }
    }

}
