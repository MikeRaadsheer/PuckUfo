using UnityEngine;

public class Heart : MonoBehaviour {

    public int ID;

    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void cleanUp()
    {
        Destroy(gameObject);
    }

    public void setInt(int healthMotherShip)
    {
        if(healthMotherShip <= ID)
            anim.SetTrigger("lostLife");
    }
}
