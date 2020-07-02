using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathingScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step =  50.0f * Time.deltaTime; 
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(750, 200, 0), step);
    }
}
