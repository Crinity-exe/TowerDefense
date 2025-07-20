using UnityEngine;
using TMPro;

public class Gun : MonoBehaviour
{
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private Bullets bulletPrefab;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {       
            Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);        
        }

       
    }
}
