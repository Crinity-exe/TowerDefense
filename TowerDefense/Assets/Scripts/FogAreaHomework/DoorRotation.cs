using UnityEngine;

public class DoorRotation : MonoBehaviour
{
    [SerializeField] private Door door;

    // Ako Player NIJE u kontaktu s vratima, vratima se rotiraju po y osi za 0.8
    private void Update()
    {
        /*
            if (!door.isInContact)
        {
            transform.Rotate(0, 0.8f, 0);
        }
        */
    }
}
