using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitTrigger : MonoBehaviour
{
    public int scoreToAdd;
    private GameManager gameManagerLink;
    //we need a score variable for each pit
    // We need to figure out how to pass the score to the gameManager
    // Start is called before the first frame update
    void Start()
    {
        //optional : automate the finding of the gameManager
        gameManagerLink = GameObject.Find("GameManager").GetComponent<GameManager>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        gameManagerLink.score += scoreToAdd;
    }
}
