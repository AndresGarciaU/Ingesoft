using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public Healthbar healthbar;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.setMaxHealth(maxHealth);
    }
    
    public void TakeDamage(int Damage)
    {
        if (currentHealth == 0)
        {
            SceneManager.LoadScene("Main menu");
            Destroy(gameObject);
        }
        currentHealth -= Damage;

        healthbar.SetHealth(currentHealth);
    }
  
       
    }
