using UnityEngine;

public class FogArea : MonoBehaviour
{
    public bool isTriggered;

    // OnTriggerEnter provjerava prvi kontakt Player-a sa ForArea 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out PlayerMovement player))
        {
            isTriggered = true;
        }
    }
    // OnTriggerExit provjerava kad Player prestaje biti u kontaktu sa FogArea
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.TryGetComponent(out PlayerMovement player))
        {
            isTriggered = false;
        }
    }
}
