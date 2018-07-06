using UnityEngine;

public class ObstacleShell : MonoBehaviour {


    private float velocity;

    // Use this for initialization
    void Start () {

        velocity = Random.Range(2f, 4f);
        transform.position = transform.position + new Vector3(0f, 0f, 30f);
}

    // Update is called once per frame
    void Update()
    {
        transform.Translate((Vector3.left * velocity) * Time.deltaTime);

        if (transform.position.x <= -25)
        {
            Destroy(gameObject);
        }
    }



}
