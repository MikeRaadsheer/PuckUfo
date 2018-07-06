using UnityEngine;

public class BackgroundBigStars : MonoBehaviour
{

    private float scrollSpeed = 0.03f;

    private void Update()
    {
        float offset = scrollSpeed * Time.time;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offset, 0);
    }
}
