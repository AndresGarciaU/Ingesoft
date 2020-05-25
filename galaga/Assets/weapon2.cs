using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon2 : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletprafab;
    
   

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0.0f,10.0f) <= 0.3)
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(bulletprafab, FirePoint.position, FirePoint.rotation);
    }
}
