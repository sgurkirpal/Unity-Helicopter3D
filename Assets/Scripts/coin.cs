using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class coin : MonoBehaviour
{

    
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        //audioClip = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,5f, 0,Space.World);
        transform.Translate(-speed, 0, 0,Space.World);
        if (transform.position.x <= -14f)
        {
            Destroy(gameObject);
            
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            other.GetComponent<playerMovement>().PickUp();
            Destroy(gameObject);
        }

    }


}
