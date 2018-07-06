using UnityEngine;

public class SpawnerController : MonoBehaviour {

    public Spawner[] spawners = new Spawner[3];

    private float setRate = 1f;
    private float spawnRate = 1f;

    void Update () {

        spawnRate -= Time.deltaTime;

        if (spawnRate <= 0)
        {
            spawnRate = setRate;

            int select = Random.Range(0, 3);

            if (select == 0)
            {
                spawners[0].SpawnAstroid();
            }
            if (select == 1)
            {
                spawners[1].SpawnAstroid();
            }
            if (select >= 2)
            {
                spawners[2].SpawnAstroid();
            }
        }

	}
}
