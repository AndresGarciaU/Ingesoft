using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntuacion : MonoBehaviour
{
    public static int scoreValue = 0;
    public Text Puntuacion;
    // Start is called before the first frame update
    void Start()
    {
        Puntuacion = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        Puntuacion.text = "Puntuacion:" + scoreValue; 
    }
}
