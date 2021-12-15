using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private float SceneTimer = 20;

   
    void Update()
    {
        SceneTimer -= 1 * Time.deltaTime;
        if (SceneTimer == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
