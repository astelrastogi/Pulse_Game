using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public Vector3 offset;
    private void LateUpdate()
    {
        Vector3 newPos = target.position + offset;
        newPos.z = transform.position.z;
        transform.position = newPos; 
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
