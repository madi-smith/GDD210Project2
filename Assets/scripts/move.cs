using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move : MonoBehaviour
{
    public GameObject train;
    public GameObject obstacle;
    public GameObject obstacleTwo;
    public GameObject obstacleThree;

    public List<GameObject> ObstacleList;
  

    private float Timer = 1;
    private float TimerTwo = 1;
    private float TimerThree = 1;
    private float TimerFour = 1;
   



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
            Instantiate(train, new Vector3(60f, -5f, 0f), Quaternion.identity);

            Timer = 2;
        }
        TimerTwo -= 1 * Time.deltaTime;

        if (TimerTwo <= 0)
        {
            Instantiate(obstacle, new Vector3(40f, 3f, 0f), Quaternion.identity);

            TimerTwo = 6;
        }
        TimerThree -= 1 * Time.deltaTime;

        if (TimerThree <= 0)
        {
            Instantiate(obstacleTwo, new Vector3(25f, 0f, 0f), Quaternion.identity);

            TimerThree = 1;
        }
        TimerFour -= 1 * Time.deltaTime;
        if (TimerFour <= 0)
        {
            Instantiate(obstacleThree, new Vector3(25f, 0f, 0f), Quaternion.identity);

            TimerFour = 1;
        }

        
    }
    


}

