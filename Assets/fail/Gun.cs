//using UnityEngine;

//public class Gun : MonoBehaviour {

//    private float cooldown = 1f;
//    private float velocity = 10f;

//    public GameObject laser;

//    private void Update()
//    {
//        cooldown -= Time.deltaTime;

//        if (Input.GetKeyDown(KeyCode.Space) && cooldown <= 0)
//        {
//            cooldown = 1f;

//            GameObject projectile = Instantiate(laser, transform.position + new Vector3(0f,0f,1f), Quaternion.identity);
//            projectile.transform.rotation = Quaternion.Euler(new Vector3(90f, 90f, 0f));
//        }
//    }

//}
