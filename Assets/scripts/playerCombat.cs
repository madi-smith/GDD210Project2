using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCombat : MonoBehaviour
{
    private float health = 10;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            health -= health;
        }
    }
}
