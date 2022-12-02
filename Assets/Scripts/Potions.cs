using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potions : MonoBehaviour
{


    private void Awake()
    {
    

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // 트리거 콜라이더를 가진 장애물과의 충돌을 감지


        if (other.tag == "Player")
        {
            
            
            
            gameObject.SetActive(false);


        }


    }
}
