using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisBlock : MonoBehaviour
{
    public float rotationSpeed = 5f;
    private Rigidbody rb;
    private bool isRotating = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isRotating)
        {
            isRotating = true;
            StartCoroutine(RotateBlock());
        }
    }

    IEnumerator RotateBlock()
    {
        float angle = 0f;
        while (angle < 90f)
        {
            angle += rotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
            yield return null;
        }
        isRotating = false;
    }
}
