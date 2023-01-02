using UnityEngine;

public class Ground : MonoBehaviour
{
    public float jumpForce;
    public bool isGrounded;
    int doubleJumpChance;
    private Animator _animator;
    private AudioSource _audiosource;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _audiosource = GetComponent<AudioSource>();
        doubleJumpChance = Random.Range(1, 11);

        if (doubleJumpChance == 1)
        {
            _animator.SetBool("ZiplatanZemin", true);
            jumpForce = 25f;
        }
        else
        {
            jumpForce = 22f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                
                Vector2 jumpVelocity = rb.velocity;
                jumpVelocity.y = jumpForce;
                rb.velocity = jumpVelocity;

                if(isGrounded == false)
                {
                    isGrounded = true;
                    UIManager.instance.AddScore();
                }
                
            }
            _animator.SetBool("TemasEdildi", true);
            _audiosource.Play();
            Destroy(gameObject,1.5f);
        }

    }
   
}
