using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public float Speed = 20f;
    public int Damage = 1;
    public Rigidbody2D Rb;

    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        Rb.velocity = transform.up * Speed;

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,
            Camera.main.transform.position.z));

    }
    void Update()
    {
        if (transform.position.y < screenBounds.y)
        {
            Destroy(gameObject);
        }


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