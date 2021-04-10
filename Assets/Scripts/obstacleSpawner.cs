using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacle;
    // Start is called before the first frame update
    void Start()
    {
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
            //obstacle[0].transform.rotation = new Vector3(0, -90, 0);
            float yComp = Random.Range(-2f, 3.5f);
            GameObject g=GameObject.Instantiate(obstacle[0], new Vector3(21, yComp, -2),Quaternion.identity) as GameObject;
            g.transform.Rotate(0f, 270f, 0f);
            yield return new WaitForSeconds(Random.Range(2f,4f));
        }
    }
}
