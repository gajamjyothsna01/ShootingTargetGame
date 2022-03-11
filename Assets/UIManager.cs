using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    int score;
    public Text textScore;

    // Update is called once per frame
    private void Update()
    {
        textScore.text = score.ToString();
    }
    public void ScoreManager(int scoreValue)
    {
        score = scoreValue + score;
        Debug.Log(score);
    }
}
