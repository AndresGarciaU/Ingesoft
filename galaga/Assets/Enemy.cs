using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Text Puntuacion;
    public int health = 1;
    public int count;
    public void Start()
    {
        count = 0;
        setCount();
    }

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
        Destroy(gameObject);
        count += 100;
        setCount();
    }
    void setCount()
    {
        Puntuacion.text = "Puntuacion: " + count.ToString();
    }
}
