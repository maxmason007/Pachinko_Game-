using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public bool readyToFire = true;
    private float spawnDelay = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && readyToFire)
        {
            Instantiate(ballPrefab, transform.position, transform.rotation);
            readyToFire = false;
            Invoke("delayFire", spawnDelay);
        }
    }

    private void delayFire()
    {
        readyToFire = true;
    }

}
