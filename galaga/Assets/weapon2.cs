using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon2 : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletprafab;
    private void Start()
    {
        StartCoroutine(shootTime());

    }
    void Shoot()
    {
        Instantiate(bulletprafab, FirePoint.position, FirePoint.rotation);
    }
    IEnumerator shootTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.0f, 10.0f));
            Shoot();
        }
    }
}
