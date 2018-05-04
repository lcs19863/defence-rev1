using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {

    public int score = 3000;
    public GameObject scoreDisplay;

	// Use this for initialization
	void Start () {
        scoreDisplay.GetComponent<Text>().text = "Score:" + score;

    }
	
	// Update is called once per frame
	void Update () {
        scoreDisplay.GetComponent<Text>().text = "Score:" + score;

    }

    public void changeScore(int i)
    {
        score = score + i;
    }
}
