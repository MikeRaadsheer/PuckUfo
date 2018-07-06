using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSmallStars : MonoBehaviour {

    private float scrollSpeed = 0.01f;

    private void Update()
    {
        float offset = scrollSpeed * Time.time;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offset, 0);
    }
}
