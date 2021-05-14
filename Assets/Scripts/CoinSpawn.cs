using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject[] coin;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(Spawn());
        //coin = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            float yComp = Random.Range(0f, 2f);
            Instantiate(coin[0], new Vector3(30, yComp, -2), Quaternion.identity);
            Instantiate(coin[0], new Vector3(30, yComp - 3f, -2), Quaternion.identity);
            Instantiate(coin[0], new Vector3(30, yComp - 6f, -2), Quaternion.identity);

            yield return new WaitForSeconds(1.5f);
        }
    }
}
