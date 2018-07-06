using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject laser;

    public void leftShot()
    {
        GameObject projectile1 = Instantiate(laser, transform.position + new Vector3(0f, 0.3f, 0.5f), Quaternion.identity);
    }

    public void rightShot()
    {
        GameObject projectile1 = Instantiate(laser, transform.position + new Vector3(0f, -0.35f, 0.5f), Quaternion.identity);
    }

}
