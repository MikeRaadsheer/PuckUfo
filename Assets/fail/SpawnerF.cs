//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Spawner : MonoBehaviour {

//    private int level;
//    private int random_min;
//    private int random_max;

//    public GameObject astroid;


//    void Start () {

//        float Y = transform.position.y;

//        random_min = 0;

//        //Defines danger level depending on height
//        if (Y < 15)
//        {
//            level = 0;
//            random_max = 0;
//        }
//        else if (Y >= 15 && Y < 50)
//        {
//            level = 1;
//            random_max = 5;
//        }
//        else if (Y >= 50 && Y < 80)
//        {
//            level = 2;
//            random_max = 3;
//        }
//        else if (Y >= 80)
//        {
//            level = 3;
//            random_max = 1;
//        }

//        int rnd = Random.Range(random_min, random_max);

//        Spawn(rnd);

//    }

//    private void Spawn(int random)
//    {
//        double astroidX = transform.position.x;
//        double astroidY = transform.position.y;

//        float rndPos = Mathf.Floor(Random.Range(0, 5) / 2);

//        if ((int) rndPos == 0)
//        {
//            astroidX = astroidX -= 1.5f;
//        }
//        else if ((int)rndPos == 2)
//        {
//            astroidX = astroidX += 1.5f;
//        }

//        if (level == 0)
//        {
//            return;
//        }
//        else if (level == 1 || level == 2 || level == 3)
//        {
//            if (random == 0)
//            {
//                GameObject obstacle = Instantiate(astroid, new Vector2((float) astroidX, (float) astroidY), Quaternion.identity);
//                obstacle.transform.Rotate(new Vector3(-90, 0, 0));
//                Debug.Log("astroid spawned at X :" + astroidX + " Y : " + astroidY);
//            }
//        }
//    }

//}
