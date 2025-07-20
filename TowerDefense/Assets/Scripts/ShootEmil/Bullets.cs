using UnityEngine;

public class Bullets : MonoBehaviour
{
    [SerializeField] private float speed = 60f;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        rb.linearVelocity = transform.forward * speed;
        Destroy(gameObject, 5f);
    }
}
