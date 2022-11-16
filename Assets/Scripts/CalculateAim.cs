using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateAim : MonoBehaviour
{
    //reference to the enemy
    [SerializeField] private Transform enemy;
    void Update()
    {
        //calculate direction = destination - source
        Vector3 direction = enemy.position - transform.position;
        Debug.DrawRay(transform.position, direction, Color.green);

        //calculate the angle usign the Tangent Method (in mye case, Inverse Tangent Method); ATAN2 support negative values, better than ATAN
        //using just ATAN2 it`ll return a radius value, so i need to turn radius to degrees
        //- 90 because unity`s angle works diferent from base angles
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
        Debug.Log($"Angle: {angle}");

        /*
        //define the rotation along a specific axis usign the angle
        Quaternion angleAxis = Quaternion.AngleAxis(angle, Vector3.forward);

        //slerp from our current rotation to the new specific rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, angleAxis, Time.deltaTime * 50);
        */

        //or
        //take our current euler angles, and we just add our new angle to it
        transform.eulerAngles = Vector3.forward * angle;
        
    }
}
