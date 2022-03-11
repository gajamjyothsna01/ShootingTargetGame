using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    Score score;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2f); //DESTROY THE Game object after 2 seconds

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {

        Destroy(gameObject);
        score = GameObject.Find("ScoreManager").GetComponent<Score>();
        score.ScoreManager(1);

    }
}
