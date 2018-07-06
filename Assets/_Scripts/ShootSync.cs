using UnityEngine;

public class ShootSync : MonoBehaviour {


    private Shoot shoot;


    private Animator anim;

    private float coolDown = 0f;
    private float setCoolDown = 0.55f;

    void Start()
    {
        anim = GetComponent<Animator>();
        shoot = FindObjectOfType<Shoot>();
    }

    void Update()
    {

        coolDown = coolDown - Time.deltaTime;
        if (anim != null)
        {
            if (Input.GetKey(KeyCode.Space) && coolDown <= 0)
            {
                anim.SetBool("Shooting", true);
                coolDown = setCoolDown;
            }

            if (coolDown <= 0)
            {
                anim.SetBool("Shooting", false);
            }
        }
    }

    public void LShot()
    {
        shoot.leftShot();
    }

    public void RShot()
    {
        shoot.rightShot();
    }

    public void BShot()
    {
        shoot.leftShot();
        shoot.rightShot();
    }

}
