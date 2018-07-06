using UnityEngine;

public class MotherShipController : MonoBehaviour
{

    private bool isDead = false;

    private int direction = 0;

    private int runs = 80;

    public GameObject deathParticles;

    private Vector3 circle;
    private Vector3 dying;

    private void FixedUpdate()
    {
        if (!isDead)
        {
            switch (direction)
            {
                case 0:
                    circle = Vector3.up;
                    break;
                case 1:
                    circle = Vector3.right;
                    break;
                case 2:
                    circle = Vector3.down;
                    break;
                case 3:
                    circle = Vector3.left;
                    break;
            }

            transform.Translate(circle / 200);

            runs--;

            if (runs <= 0)
            {
                direction++;
                runs = 100;
                if (direction == 4)
                {
                    direction = 0;
                }
            }
        }

        if (isDead)
        {
            if(transform.position.x <= -18)
            {
                Destroy(gameObject);
            }

            transform.Translate(Vector3.left / 150);
            transform.Translate(Vector3.down / 150);
            transform.Translate(Vector3.left / 150);
            transform.Translate(Vector3.up / 150);
            transform.Translate(Vector3.left / 150);
            transform.Translate(Vector3.down / 150);
            transform.Translate(Vector3.right / 150);
            transform.Translate(Vector3.down / 150);
            transform.Translate(Vector3.left / 150);
            transform.Translate(Vector3.down / 150);
        }

    }

    public void Die()
    {
        isDead = true;
    }

    private void OnDestroy()
    {
        deathParticles.SetActive(true);
    }

}
