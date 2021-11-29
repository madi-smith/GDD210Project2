using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject train;
    
    public List<GameObject> ObstacleList;
  

    private float Timer = 1;
    private float TimerTwo = 1;
    private float TimerThree = 1;
    private float TImerFour = 1;



    private void Start()
    {
        ObstacleList = new List<GameObject>();
        Timer = 1;
       


    }
    private void Update()
    {
        Timer -= 1 * Time.deltaTime;
        
        if (Timer <= 0)
        {
            Instantiate(train, new Vector3(20f, -4f, 0f), Quaternion.identity);

            Timer = 1;
        }

        
    }


}

