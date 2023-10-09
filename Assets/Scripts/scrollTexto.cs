using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollTexto : MonoBehaviour
{
    public float scrollSpeed = 40;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;;
        Vector3 localVectorUp = transform.TransformDirection(0, 1, 0);
        pos += localVectorUp * scrollSpeed * Time.deltaTime;
        transform.position = pos;
    }
}
