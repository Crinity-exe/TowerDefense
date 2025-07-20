using UnityEngine;

public class ShootingPlayerMovement : MonoBehaviour
{
    private float rotationY;
    [SerializeField] private float rotationSpeed;

    private void Start()
    {
        Cursor.visible = false;
        rotationY = 90f;
        transform.rotation = Quaternion.Euler(0, rotationY, 0);
    }
    private void Update()
    {
        if(Time.timeScale == 0f) {

            Cursor.visible = true;
        }
        else
        {
            rotationY += Input.GetAxis("Mouse X") * rotationSpeed;
            rotationY = Mathf.Clamp(rotationY, 0f, 180f);

            transform.rotation = Quaternion.Euler(0f, rotationY, 0f);

        }
        
    }
}
