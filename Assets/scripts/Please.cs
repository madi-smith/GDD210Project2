using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Please : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jump = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { }
        rb.AddForce(new Vector2(0f, 10f) * jump);
        //rb.velocity = new Vector2(0f, 10f) * jump);
    }
}
