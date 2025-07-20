using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 40;
    [SerializeField] private Image health;

    public Transform target;
    private Rigidbody rb;

    private float currentHealth;
    private float maxHealth = 100;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        currentHealth = maxHealth;
        health.fillAmount = currentHealth / maxHealth;
    }

    public void Damage(float damage)
    {
        
        currentHealth -= damage;
        health.fillAmount = currentHealth / maxHealth;
        if (currentHealth <= 0)
        {
            SaveSystem.instance.IncreaseScore();
            Destroy(gameObject);
        }
    }




    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Bullets bullet))
        {
            Damage(50);
           
            Destroy(bullet.gameObject);
        }

        if (collision.gameObject.TryGetComponent(out PlayerHP player))
        {     
            player.Damage(50);
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position, target.position, speed * Time.deltaTime);
        transform.LookAt(transform);
    }
}
