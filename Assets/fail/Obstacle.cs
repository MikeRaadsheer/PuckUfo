//using UnityEngine;

//public class Obstacle : MonoBehaviour {

//    RocketController player;

//    private MeshRenderer mesh;

//    public ParticleSystem explosion;

//    public Material[] astroidMaterials = new Material[5];

//    public void Start()
//    {
//        player = FindObjectOfType<RocketController>();
//        MeshRenderer mesh = gameObject.GetComponent<MeshRenderer>();

//        Shader shader = Shader.Find("Sprites/Default");

//        mesh.material = astroidMaterials[Random.Range(0,4)];

//        mesh.material.shader = shader;
//    }

//    private void OnTriggerEnter(Collider col)
//    {
//        if (col.gameObject.tag == "Player")
//        {
//            float rnd = Random.Range(15f, 30f);
//            Instantiate(explosion, transform.position, Quaternion.identity);
//            player.astroidHit(rnd);
//            Destroy(gameObject);
//        }
//    }

//}
