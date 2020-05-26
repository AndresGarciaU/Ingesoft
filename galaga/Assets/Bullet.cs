using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 1;
    public Rigidbody2D rb;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,
            Camera.main.transform.position.z));


    }
    void Update()
    {
        
        if (transform.position.y > screenBounds.y*-1)
        {
            Destroy(gameObject);
        }


    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        Health player = hitInfo.GetComponent<Health>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);
            
        }
        Destroy(gameObject);
    }
  

}
