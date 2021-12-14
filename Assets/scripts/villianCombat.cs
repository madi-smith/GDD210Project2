using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class villianCombat : MonoBehaviour
{
    private float health = 0;

    // Update is called once per frame
    void Update()
    {
        while(health <=10) {
            if (Input.GetKey(KeyCode.Space))
            {
                health += health;
            }
        }
        if (health == 10f)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(10f, 0));
        }
    }
}
