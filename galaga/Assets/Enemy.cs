using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Text Puntuacion;
    public int health = 1;
    

    public void TakeDamage (int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        puntuacion.scoreValue += 10;
        Destroy(gameObject);
    }
    
}
