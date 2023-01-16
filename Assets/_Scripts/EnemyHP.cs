using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    public float maxHealth = 100;
    float currentHealth;

    public GameObject healthBarUI;
    public Slider slider;
    public Text ScoreText;
    private int Score;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        slider.value = CalculateHealth();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
            
        }

        void Die()
        {
            
            this.gameObject.SetActive(false);
        }
    }
    void Update()
    {
        slider.value = CalculateHealth();
        if (currentHealth < maxHealth)
        {
            healthBarUI.SetActive(true);

        }

        
    }
    float CalculateHealth()
    {
        return currentHealth / maxHealth;
    }
    void addScore(){
        
        ScoreText.text = Score.ToString();
    }
}

