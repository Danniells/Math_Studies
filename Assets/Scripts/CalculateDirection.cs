using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateDirection : MonoBehaviour
{
    [SerializeField] private Transform player;
    void Update()
    {
        //direction = destination - source (Phitagoras)
        Vector3 direction = player.position - transform.position;
        //normalize the direction for run 1 meter per second and not accelarate 
        direction.Normalize();
        Debug.Log($"Magnitude: {direction.magnitude}");
        Debug.DrawRay(transform.position, direction, Color.green);
        //simpleMove
        transform.Translate(direction * Time.deltaTime);
    }
}
