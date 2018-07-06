using UnityEngine;

public class Manager : MonoBehaviour
{

    private int healthMotherShip = 10;
    private int healthPlayer = 3;
    private float spawnRate = 3f;

    public Heart[] hearts = new Heart[10];

    private bool isDead = false;
    private bool pause = false;

    public GameObject playerPrefab;
    public GameObject motherShip;
    public GameObject respawn;

    public MotherShipController ship;

    public Animator anim;

    //public SpawnPowerUp pow = FindObjectOfType<SpawnPowerUp>();

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            PlayerHit(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ShipHit(1);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pause)
            {
                Time.timeScale = 0;
                pause = true;
            } else
            {
                Time.timeScale = 1;
                pause = false;
            }
        }
    }

    // 1 = Astroid
    // 2 = Enemy Ship
    // 3 = Enemy Laser
    public void PlayerHit(int tag)
    {

        switch (tag)
        {
            case 1:
                healthPlayer -= 1;
                break;
            case 2:
                healthPlayer -= 2;
                break;
            case 3:
                healthPlayer -= 2;
                break;
        }

        if (healthPlayer <= 0 && !isDead)
        {
            isDead = true;
            FindObjectOfType<PlayerController>().Die();
            Invoke("Respawn", spawnRate);
        }

    }


    // 1 = Astroid
    // 2 = Enemy Ship
    // 3 = Enemy Laser
    public void ShipHit(int tag)
    {

        switch (tag)
        {
            case 1:
                healthMotherShip -= 1;
                break;
            case 2:
                healthMotherShip -= 2;
                break;
            case 3:
                healthMotherShip -= 1;
                break;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (hearts[i] != null)
                hearts[i].setInt(healthMotherShip);
        }

        if (healthMotherShip <= 5)
            anim.SetTrigger("halfHP");

        if (healthMotherShip <= 0)
        {
            GameOver();
        }

    }

    public void Respawn()
    {
        isDead = false;
        healthPlayer = 3;
        GameObject player = Instantiate(playerPrefab, respawn.transform.position, Quaternion.identity);
        player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 30f);
    }

    public void GameOver()
    {
        FindObjectOfType<PlayerController>().Die();
        ship.Die();
    }

}
