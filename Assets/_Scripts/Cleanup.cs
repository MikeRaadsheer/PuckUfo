using UnityEngine;

public class Cleanup : MonoBehaviour {

    private float time = 10f;

    void Update () {

        time = time - Time.deltaTime;

        if (time < 0)
        {
            Destroy(gameObject);
        }
    }
}
