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
        // Ʈ���� �ݶ��̴��� ���� ��ֹ����� �浹�� ����


        if (other.tag == "Player")
        {
            
            
            
            gameObject.SetActive(false);


        }


    }
}
