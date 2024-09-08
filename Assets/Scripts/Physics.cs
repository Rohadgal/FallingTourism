using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{
   public Vector3 move;
   public float angle;

   void RotateInZ()
   {
        Matrix4x4 matrix = new Matrix4x4{};
        matrix.m00 = Mathf.Cos(angle); matrix.m01 = -Mathf.Sin(angle); matrix.m02 = 0; matrix.m03 = 0;
        matrix.m10 = Mathf.Sin(angle); matrix.m11 = Mathf.Cos(angle); matrix.m12 = 0; matrix.m13 = 0;
        matrix.m20 = 0; matrix.m21 = 0; matrix.m22 = 1; matrix.m23 = 0;
        matrix.m30 = 0; matrix.m31 = 0; matrix.m32 = 0; matrix.m33 = 1;


        //Quaternion ddf = Quaternion.Euler(matrix * transform.position);

        transform.Rotate(matrix * transform.position);
   }

    
    void Moddd()
    {
        transform.position = Vector3.forward * 5;
    }

    // Update is called once per frame
    void Update()
    {
        RotateInZ();
    }
}
