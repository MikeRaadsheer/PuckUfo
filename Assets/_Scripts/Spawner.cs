using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject astroid;

    public void SpawnAstroid () {

        GameObject obstacle = Instantiate(astroid, transform.position, Quaternion.identity);

    }

}
