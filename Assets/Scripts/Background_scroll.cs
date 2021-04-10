using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Background_scroll : MonoBehaviour
{
    public float speed;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float offset = speed * Time.time;
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
