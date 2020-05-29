using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    void restart()
    {
        SceneManager.LoadScene("Main menu");
    }
}
