using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private float SceneTimer = 2;

    private void SceneUpdate()
    {
        SceneTimer -= 1 * Time.deltaTime;
        if (SceneTimer == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
    void Update()
    {

    }
}
