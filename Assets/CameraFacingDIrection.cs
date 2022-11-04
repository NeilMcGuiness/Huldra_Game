using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFacingDIrection : MonoBehaviour
{
    public Transform lookAtTarget;
    public Transform followTarget;
    public Vector3 posOffset; 
    // public Vector3 rotationOffset; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 playerposOffset = followTarget.forward * posOffset.x + followTarget.up * posOffset.y;
        Vector3 diff = followTarget.position - lookAtTarget.position;
        transform.position = followTarget.position + diff * posOffset.z + playerposOffset;
        // transform.Rotate(rotationOffset);
    }
}
