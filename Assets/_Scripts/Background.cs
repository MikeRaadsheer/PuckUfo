using UnityEngine;

public class Background : MonoBehaviour {

    private float scrollSpeed = 0.1f;

    private void Update()
    {
        float offset = scrollSpeed * Time.time;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offset, 0);
    }
}
