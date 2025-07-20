using UnityEngine;
using TMPro;

public class NoFogPlayerMovement : MonoBehaviour
{
    [SerializeField] private TMP_Text notificationText;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rb;
    public Door door;

    private bool hasKey = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void KeyText()
    {
        notificationText.text = $"Press E to open the door, and save Emil :o ";
    }
    public void NoKeyText()
    {
        notificationText.text = null;
    }

    public bool HasKey()
    {
        return hasKey;
    }
    public void CollectingKey()
    {
        hasKey = true;
    }
    private void PlayerMovement(Vector3 direction)
    {
        rb.linearVelocity = direction * speed;
    }

    private void Update()
    {
        rb.linearVelocity = Vector3.zero;
        if(Input.GetKey(KeyCode.W))
        {
            PlayerMovement(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            PlayerMovement(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            PlayerMovement(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            PlayerMovement(Vector3.right);
        }
        if (Input.GetKey(KeyCode.E) && hasKey && door.isInDoorZone)
        {
            door.DestroyTheDoor();
        }
    }
}
