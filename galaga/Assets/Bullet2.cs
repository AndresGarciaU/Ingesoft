using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public float Speed = 20f;
    public int Damage = 1;
    public Rigidbody2D Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb.velocity = transform.up * Speed;

    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Health player = hitInfo.GetComponent<Health>();
        if (player != null)
        {
            player.TakeDamage(Damage);

        }
        Destroy(gameObject);
    }


}