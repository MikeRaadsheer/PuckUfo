using UnityEngine;

public class Laser : MonoBehaviour
{

    private float velocity = 25f;

    private Obstacle obs;

    private void Start()
    {
        obs = FindObjectOfType<Obstacle>();

        transform.Rotate(new Vector3(0f, 0f, -90f));
    }

    void Update()
    {
        transform.Translate((Vector3.up * velocity) * Time.deltaTime);

        var dist = (transform.position.y - Camera.main.transform.position.y);
        var rightLimitation = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, dist)).x;

        if (transform.position.x > rightLimitation + 1)
            Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Obstacle")
        {
            Destroy(gameObject);
        }
        if (col.transform.tag == "pow")
        {
            ShootSync SS = FindObjectOfType<ShootSync>();
            SS.BShot();
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
