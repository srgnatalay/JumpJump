using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerInput _playerInput;
    public float harekterhizi;
    private float yatayhiz;
    
    [SerializeField] Rigidbody2D rb;
    void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float yatayhiz = _playerInput.actions["Move"].ReadValue<Vector2>().x;
        print(yatayhiz * harekterhizi * Time.deltaTime);
        rb.velocity = new Vector2(yatayhiz * harekterhizi * Time.deltaTime, rb.velocity.y);

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Asit")
            GameManager.instance.GameOver();
    }

}
