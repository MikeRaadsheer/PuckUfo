using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGOText : MonoBehaviour {

    int alpha = 225;
    float a = 0;

    public void FixedUpdate()
    {
        if (a < alpha)
        {
            a += 0.0001f;
            GetComponent<SpriteRenderer>().color += new Color(0, 0, 0, a);
        }
    }
}
