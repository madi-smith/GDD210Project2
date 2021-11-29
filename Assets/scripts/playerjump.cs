using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerjump : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 2f));
        }
    }
}
