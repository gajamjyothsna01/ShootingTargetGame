using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject targetPrefab;
  
    // Start is called before the first frame update
    void Start()
    {
        //Randomly generating the cross hair
        //SpawnMethod();
        InvokeRepeating("SpawnMethod",1,5); //Which method you want to repeat and start at which time and repeat rate time(duration).

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void SpawnMethod()
    {
        float randomX = UnityEngine.Random.Range(-4.09f , 4.09f);
        float randomY = UnityEngine.Random.Range(-2.15f, 2.15f);
        Instantiate(targetPrefab, new Vector3(randomX, randomY, 0), Quaternion.identity);

       
    }
}
