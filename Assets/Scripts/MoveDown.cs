using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 1f;

    private void FixedUpdate() 
    {
        transform.position -= (new Vector3(0, speed, 0) * Time.deltaTime);  
    }

    private void OnTriggerEnter(Collider other) 
    {
        speed = 0f;    
    }  
}
