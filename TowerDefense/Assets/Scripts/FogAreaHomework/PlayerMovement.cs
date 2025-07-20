using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /* Skripta stavljena na Playera, woho!
     * Stavljen rigidbody na playera
    */
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rb;

    [SerializeField] private FogArea fogArea;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Metoda za Movement koja mijenja brzinu ovisno jesmo li usli u FogArea ili izasli te vratili speed na pocetnu vrijednost
    private void Movement(Vector3 direction)
    {
        if (fogArea.isTriggered == false)
        {
            rb.linearVelocity = direction * speed;
            Debug.Log(rb.linearVelocity); 
        }
        else 
        {
            rb.linearVelocity = direction * (speed * 0.8f);
            Debug.Log(rb.linearVelocity);
        }
    }

    private void Update()
    {
        rb.linearVelocity = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            Movement(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Movement(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Movement(Vector3.right);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Movement(Vector3.back);
        }
    }
}
