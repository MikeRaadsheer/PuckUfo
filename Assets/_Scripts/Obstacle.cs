using UnityEngine;

public class Obstacle : MonoBehaviour
{

    private float velocity;

    private Manager manager;

    public ParticleSystem explosion;

    private float rand;

    public Material[] astroidMaterials = new Material[5];

    private void Start()
    {
        transform.Rotate(new Vector3(90f, 0f, 0f));

        manager = FindObjectOfType<Manager>();
        velocity = Random.Range(2f, 4f);

        MeshRenderer mesh = gameObject.GetComponent<MeshRenderer>();

        mesh.material = astroidMaterials[Random.Range(0, 6)];

        Shader shader = Shader.Find("Sprites/Default");

        mesh.material.shader = shader;
    }

    private void Update()
    {
        var dist = (transform.position.y - Camera.main.transform.position.y);

        var upLimitation = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, dist)).y;
        var downLimitation = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, dist)).y;

        transform.Rotate(Vector3.up * Time.deltaTime * 10);
        transform.position = new Vector3(transform.position.x, transform.position.y, 30);

        if (transform.position.y > upLimitation / 2)
        {
            transform.Translate(new Vector3(0f, 0f, Random.Range(1f, 1.3f) * Time.deltaTime));
        }

        if (transform.position.y < downLimitation / 2)
        {
            transform.Translate(new Vector3(0f, 0f, -(Random.Range(1f, 1.3f) * Time.deltaTime)));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Projectile")
        {
            Destroy(transform.parent.gameObject);
        }

        if (other.transform.tag == "Player")
        {
            manager.PlayerHit(1);
            Destroy(transform.parent.gameObject);
        }

        if (other.transform.tag == "MotherShip")
        {
            manager.ShipHit(1);
            Destroy(transform.parent.gameObject);
        }

    }

    private void OnDestroy()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
    }

}
