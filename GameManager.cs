using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI textLink;

    // Start is called before the first frame update
    void Start()
    {
        textLink.text = "Score: 0"; 
    }

    // Update is called once per frame
    void Update()
    {
        textLink.text = "Score : " + score;
    }
}
