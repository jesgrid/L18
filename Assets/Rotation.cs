using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Vector3 vector = Vector3.zero;
    void Update()
    {
        transform.Rotate(vector * Time.deltaTime);
    }
}
