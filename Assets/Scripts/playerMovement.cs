using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class playerMovement : MonoBehaviour
{
    private Rigidbody player;
    public float speed;
    public int score=0;
    private float vertical, horizontal;
    public AudioSource explosion;
    public AudioSource coinPickUp;
    private UnityEngine.Vector2 initPosition;
    private float directionX, directionY,horF,verF;

    public Joystick joystick;
    
    // private float target=7f,sensitivity=3f; 
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
        
    }

    private void Awake()
    {
        //audioClip = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                initPosition = touch.position;
            }
            if (touch.phase == TouchPhase.Moved)
            {
                directionX = touch.position.x - initPosition.x;
                directionY = touch.position.y - initPosition.y;
            }
            if (directionX > 0)
            {
                horizontal = Time.deltaTime * speed;
                //horizontal = speed;
            }
            else
            {
                horizontal = Time.deltaTime * -speed;

                //horizontal =  -speed;
            }
            if (directionY > 0)
            {
                vertical = Time.deltaTime*speed;
                //vertical =  speed;
            }
            else
            {
                vertical = Time.deltaTime * -speed;
                //vertical = -speed;

            }
            //horF = Mathf.MoveTowards(horF, target, sensitivity * Time.deltaTime);
            //verF = Mathf.MoveTowards(verF, target, sensitivity * Time.deltaTime);

            /*{
                horizontal = speed;
            }
            else if (touch.position.x <= 4.5f)
            {
                horizontal = -speed;
            }
            else
            {
                horizontal = 0;
            }
            if (touch.position.y > -2f)
            {
                vertical = speed;
            }
            else if (touch.position.y <= -2)
            {
                vertical = -speed;
            }
            else
            {
                vertical = 0;
            }
        }*/

        horizontal = joystick.Horizontal * speed;
        vertical = joystick.Vertical * speed;

        if (player.transform.position.y >= 2.5f)
        {
            player.transform.position = new Vector3(player.transform.position.x, 2.5f, player.position.z);
        }
        if (player.transform.position.y <= -6)
        {
            player.transform.position = new Vector3(player.transform.position.x, -6f, player.position.z);
        }
        if (player.transform.position.x <= -7f)
        {
            player.transform.position = new Vector3(-7f, player.transform.position.y, player.position.z);
        }
        if (player.transform.position.x >= 16f)
        {
            player.transform.position = new Vector3(16f, player.transform.position.y, player.position.z);
        }
        player.velocity = new Vector3(vertical, 0, horizontal);
        //player.transform.position = new Vector3(-7 , -6, -2);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "house1")
        {
            // trigger helicopter to explode when it collides with this
            explosion.Play();
            //Destroy(gameObject);
            
        }
        if (other.tag == "Respawn")
        {
            explosion.Play();
            //Destroy(gameObject);
            
        }

    }
    public void PickUp()
    {
        score += 1;
        coinPickUp.Play();
    }
}
