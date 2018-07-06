//using UnityEngine;

//public class RocketController : MonoBehaviour {

//    public float thrust = 80f;
//    private float distance = 1.5f;

//    private float cooldown = 0.2f;

//    private Obstacle obs;
//    private BackgroundTile backg;

//    public CameraController cam;
//    private BackgroundTile backTile;

//    void Start () {
//        cam = FindObjectOfType<CameraController>();
//        backg = FindObjectOfType<BackgroundTile>();
//        backTile = FindObjectOfType<BackgroundTile>();
//	}

//    void FixedUpdate()
//    {
//        //if (transform.position.y >= 212)
//        //{
//        //    Debug.Log(Time.timeScale);
//        //    if (Time.timeScale > 0.000f)
//        //    {
//        //        Time.timeScale = Time.timeScale - 0.01f;
//        //    }
//        //}

//        backTile.UpdatePlayerTransform(transform.position);

//        if (thrust < 80)
//        {
//            thrust += 0.15f;
//        }

//        float x = transform.position.x;

//        Vector2 velocity = new Vector2(0, (thrust / 10));

//        //Upward Movement
//        transform.Translate(velocity * Time.deltaTime);

//        //backg.Scroll(thrust / 10);

//        cooldown = cooldown -= Time.deltaTime;

//        //Controld for going Left & Right
//        if (cooldown <= 0)
//        {
//            //Checks position and input
//            if (Input.GetKeyDown(KeyCode.A) && x > -1)
//            {
//                //Moves Player
//                transform.Translate(new Vector2(-distance, 0));

//                //Corrects Camera So it will stay in it's position
//                cam.goLeft(distance);

//                //resets cooldown
//                cooldown = 0.2f;
//            }

//            //Checks position and input
//            if (Input.GetKeyDown(KeyCode.D) && x < 1)
//            {
//                //Moves Player
//                transform.Translate(new Vector2(distance, 0));

//                //Corrects Camera So it will stay in it's position
//                cam.goRight(-distance);

//                //resets cooldown
//                cooldown = 0.2f;
//            }

//        }

//    }

//    public void astroidHit(float speed)
//    {
//        thrust = thrust -= speed;
//    }

//}