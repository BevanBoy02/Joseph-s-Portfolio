using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Text scoreText;
    public float scoreAmount;
    public float pointIncreasedPerSecond;

    void Start()
    {
        scoreAmount = 0f;
        pointIncreasedPerSecond = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)scoreAmount + " time";
        scoreAmount += pointIncreasedPerSecond * Time.deltaTime;
    }
}
