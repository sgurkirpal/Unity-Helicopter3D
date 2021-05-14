using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBuilding : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] list;
    private float yComp;
    void Start()
    {
        //list = new GameObject[100];
        // = new GameObject[100];
        //list= (GameObject[])Resources.LoadAll("/Prefabs/Houses");
        // list = GameObject.FindGameObjectsWithTag("house1");
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator Spawn()
    {
        while (true)
        {

            // create a new skyscraper from prefab selection at right edge of screen
            Instantiate(list[Random.Range(0, list.Length)], new Vector3(30, Random.Range(-12, -9), -1),
                Quaternion.identity);

            // randomly increase the speed by 1
            

            // wait between 1-5 seconds for a new skyscraper to spawn
            yield return new WaitForSeconds(Random.Range(2, 4));
        }
    }
}
    
