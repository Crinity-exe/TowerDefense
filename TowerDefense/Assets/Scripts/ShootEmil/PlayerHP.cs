using UnityEngine;
using TMPro;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] private GameObject GAMEOVERPanel;
    [SerializeField] private TMP_Text hpText;
    [SerializeField] private float currentHealth;
    [SerializeField] private float maxHP = 150;

    private void Start()
    {
        GAMEOVERPanel.SetActive(false);
        currentHealth = maxHP;
        hpText.text = $"{currentHealth / maxHP * 100} %";
    }

    public void Damage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0) 
        {
            currentHealth = 0;
            Time.timeScale = 0f;
            GAMEOVERPanel.SetActive(true);
        }
        hpText.text = $"{currentHealth / maxHP * 100} %";
    }
}
