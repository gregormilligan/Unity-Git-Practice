using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newTestRaycasting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitinfo;

        if (Physics.Raycast(ray, out hitinfo))
        {
            Debug.DrawLine(ray.origin, hitinfo.point, Color.red);
        }
        else
        {
            Debug.DrawLine(ray.origin, hitinfo.point * 100, Color.green);
        }
        


    }
}
