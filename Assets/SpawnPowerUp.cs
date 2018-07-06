using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerUp : MonoBehaviour
{

    public GameObject pow;

    private void Update()
    {
        if(Random.Range(0, 1000) <= 2)
        {
            Pu();
        }
    }

    public void Pu()
    {
        Instantiate(pow, transform.position, Quaternion.identity);
    }

}
