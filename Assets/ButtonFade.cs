using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFade : MonoBehaviour {

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
    
    public void loadScene()
    {
        SceneManager.LoadScene(0);
    }

}
