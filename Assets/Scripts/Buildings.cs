using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildings : MonoBehaviour
{
    public Rigidbody build;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        build = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-speed, 0, 0);
        if (transform.position.x <= -14f)
        {
            Destroy(gameObject);
        }
    }
    
}
