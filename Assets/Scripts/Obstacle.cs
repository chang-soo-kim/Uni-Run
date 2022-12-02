using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 5f;
    int dir = 0;
    float time = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float input_mx = -speed * Time.deltaTime;
        float input_x = speed * Time.deltaTime;


        if (transform.localPosition.x > 4f)
        {
            dir = 0;
        }

        if (transform.localPosition.x < -4f)
        {
            dir = 1;
        }


        switch (dir)
        {
            case 0 : 
                transform.Translate(new Vector2(input_mx, 0)); 
                break;
            case 1: 
                transform.Translate(new Vector2(input_x, 0)); 
                break;
        }
    }
}
