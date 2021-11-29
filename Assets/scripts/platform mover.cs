using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformmover : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    float ct = 0;
   
    
    // Update is called once per frame
    void Update()
    {
        int randIndex = Random.Range(0, 4);
        float randY = Random.Range(-2f, 2f);

        if (ct > 2f)
        {
            GameObject newObj = Instantiate(obstaclePrefabs[randIndex]);
            newObj.transform.position = new Vector2(4, randY);
            ct = 0;
        }
        ct += Time.deltaTime;
    }
}
