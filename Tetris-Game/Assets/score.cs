using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour

{
    public static int scoreval = 0;
    Text scoreboard;
    // Start is called before the first frame update
    void Start()
    {
        scoreboard = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        scoreboard.text = "Score : " + scoreval;
    }
}
