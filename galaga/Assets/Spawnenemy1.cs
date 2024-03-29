﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnenemy1 : MonoBehaviour
{
    public GameObject enemy;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,
           Camera.main.transform.position.z));
        StartCoroutine(enemyWave());
    }
  
    private void spawnEnemy()
    {
        GameObject a = Instantiate(enemy) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x)
            ,  (screenBounds.y *-2)- 8f);
    }
       IEnumerator enemyWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
   
}
