using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isInDoorZone = false;
    private NoFogPlayerMovement playerReferance;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out NoFogPlayerMovement player))
        {
            if (player.HasKey() == true)
            {
                isInDoorZone = true;
                player.KeyText();
                playerReferance = player;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.TryGetComponent(out NoFogPlayerMovement player))
        {
            isInDoorZone = false;
            player.NoKeyText();
        }
    }
    public void DestroyTheDoor()
    {
        gameObject.SetActive(false);
        playerReferance.NoKeyText();
    }
}
