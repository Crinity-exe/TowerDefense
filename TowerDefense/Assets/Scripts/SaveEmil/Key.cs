using UnityEngine;

public class Key : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out NoFogPlayerMovement player))
        {
            player.CollectingKey();
            Destroy(gameObject);
        }
    }
}
