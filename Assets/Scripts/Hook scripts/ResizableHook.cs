using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizableHook : MonoBehaviour
{
    //public Transform fishingLine;
    //public Transform fishingHook;
    
    
    private float speed = 0.02f;    
    private float maxScale = 1.42f;        
    private Vector3 scalingVector;

    // Start is called before the first frame update
    void Start()
    {        
        transform.localScale = new Vector3(1, 0.16f, 1);
        scalingVector = new Vector3(0, speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
              

        // Обновление размера объекта (3), если необходимо
    }

    private void FixedUpdate()
    {
        ChangeLine();

    }

    void ChangeLine()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (transform.localScale.y + scalingVector.y < maxScale) // Если не достиг критического размера.
                transform.localScale += scalingVector; // Увеличить размер (Опустить крючок)
        }
        else
        {
            if (transform.localScale.y + scalingVector.y > 0.16f + speed) // Пока не достигло                                                         
            {
                transform.localScale -= scalingVector;
            }
        }
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    if (transform.localScale.y + scalingVector.y > 0.16f + speed) // Пока не достигло
        //        transform.localScale -= scalingVector;
        //}

    }

}
