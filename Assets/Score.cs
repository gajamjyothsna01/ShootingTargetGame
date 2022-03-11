using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int score;
    public Text textScore;
    public SpriteRenderer sprite;
    public bool isGameWin = false;
    // Start is called before the first frame update
    void Start()
    {
        sprite.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = score.ToString();
    }
    public void ScoreManager(int scoreValue)
    {
        score = score + scoreValue;
        Debug.Log(score);
        if(score>20)
        {
            sprite.enabled = true;
            isGameWin = true;
        }
    }
}
