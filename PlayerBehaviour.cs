using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{ 
    private Rigidbody playerRb;
    public bool runOnce = false;
    public float minSpeed = 20;
    public float maxSpeed = 30;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !runOnce)
        {
            playerRb.AddForce(Vector3.forward * Random.Range(minSpeed, maxSpeed), ForceMode.Impulse);
            runOnce = true;
        }
    }
}
