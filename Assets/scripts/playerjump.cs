using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerjump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jump = 10f;
    private void Update()
    {
        //Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //rb.AddForce(new Vector2(0, 2f) * jump);
            rb.velocity = new Vector2(0, 2f) * jump;
            Debug.Log("this works");
        }

    }

}
