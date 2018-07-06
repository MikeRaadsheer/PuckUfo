using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Lower is faster
    private float speedX = 10f;
    private float speedY = 8f;

    //public AudioSource sound;

    public ParticleSystem sparks;

    void FixedUpdate()
    {


        var dist = (transform.position.y - Camera.main.transform.position.y);

        var leftLimitation = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).x;
        var rightLimitation = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, dist)).x;

        var upLimitation = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, dist)).y;
        var downLimitation = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, dist)).y;

        //Make Sure Plane's "Z = 0" at all times

        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, 0);


        //MOVEMENT--------------------------------

            //UP (Y)
        if (Input.GetKey(KeyCode.W) && transform.position.y < upLimitation - transform.lossyScale.y)
        {
            transform.Translate(Vector3.forward / speedY);
        }

            //Down (Y)
        if (Input.GetKey(KeyCode.S) && transform.position.y > downLimitation + transform.lossyScale.y)
        {
            transform.Translate(Vector3.back / speedY);
        }

            //LEFT (X)
        if (Input.GetKey(KeyCode.A) && transform.position.x > leftLimitation + (transform.lossyScale.y + (transform.lossyScale.y / 2)))
        {
            transform.Translate(Vector3.left / speedX);
        }

        //RIGHT (X)
        if (Input.GetKey(KeyCode.D) && transform.position.x < rightLimitation - (transform.lossyScale.y + (transform.lossyScale.y / 2)))
        {
            transform.Translate(Vector3.right / speedX);
        }

    //    if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
    //    {
    //        sound.Play();
    //}

}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Obstacle")
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnDestroy()
    {
        Instantiate(sparks, new Vector3(transform.position.x, transform.position.y, 30), Quaternion.identity);
    }

}
