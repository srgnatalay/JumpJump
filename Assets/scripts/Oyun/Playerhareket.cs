using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Playerhareket : MonoBehaviour
{
    

    [SerializeField] private Joystick joy;
    public float harekterhýzý;
    private float yatayhýz;
    
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {
        float yatayhýz = joy.Horizontal;
        rb.velocity = new Vector2(yatayhýz * harekterhýzý * Time.deltaTime, rb.velocity.y);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Asit")
        {
            SceneManager.LoadScene(2);
           
        }
    }

}
