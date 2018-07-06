using UnityEngine;

public class PlayerController : MonoBehaviour {

    public void Die()
    {
        Destroy(gameObject, 0.01f);
    }
}
