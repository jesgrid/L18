using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmosVecrors : MonoBehaviour
{
    public int scriptMod = 0;
    public Vector3 v1;
    public Vector3 v2;
    public float multiplier;
    public GameObject obj;
    private void OnDrawGizmos()
    {
        if(scriptMod == 1)
        {
            Gizmos.color = Color.red;
            DrawVector(transform.position, v1);
            Gizmos.color = Color.blue;
            DrawVector(transform.position, v2);
            Gizmos.color = Color.green;
            DrawVector(transform.position, (v1 + v2));
        }
        else if(scriptMod == 2)
        {
            Vector3 startPoint = transform.position + v2;
            Gizmos.color = Color.red;
            DrawVector(transform.position, v1);
            Gizmos.color = Color.blue;
            DrawVector(transform.position, v2);
            Gizmos.color = Color.green;
            DrawVector(startPoint, v1 - v2);
        }
        else if (scriptMod == 3)
        {
            Vector3 startPoint = transform.position + v1;
            Gizmos.color = Color.red;
            DrawVector(transform.position, v1);
            Gizmos.color = Color.blue;
            DrawVector(transform.position, v2);
            Gizmos.color = Color.green;
            DrawVector(startPoint, v2 - v1);
        }
        else if (scriptMod == 4)
        {
            Gizmos.color = Color.red;
            DrawVector(transform.position, v1 * multiplier);
        }
        else if (scriptMod == 5)
        {
            Gizmos.color = Color.red;
            DrawVector(transform.position, obj.transform.position - transform.position);
            Vector3 toTargetVector = obj.transform.position - transform.position;
            Debug.Log("Расстояние между объектами равно: " + toTargetVector.magnitude);
        }
    }

    

    private void DrawVector(Vector3 startPoint, Vector3 vector)
    {
        Gizmos.DrawRay(startPoint, vector);
        Gizmos.DrawSphere(startPoint + vector, 0.15f);
    }
}
