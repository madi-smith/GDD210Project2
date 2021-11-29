using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class code : MonoBehaviour
{
    public int FlySpeed;

    private void Update()
    {
        transform.position += new Vector3(-FlySpeed * Time.deltaTime, 0, 0);

       
    }
}
