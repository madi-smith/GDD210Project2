using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewJump : MonoBehaviour
{
   
public Rigidbody2D rb;
    public float jumpAmount = 10;
    // Update is called once per frame
    void Update()
    {
       

    
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpAmount);
        }
    
}
}
