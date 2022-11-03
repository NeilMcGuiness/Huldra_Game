using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFacingDIrection : MonoBehaviour
{
    public Transform lookAtTarget;
    public Transform followTarget;
    public Vector3 offset; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 playerOffset = followTarget.forward * offset.x + followTarget.up * offset.y;
        Vector3 diff = followTarget.position - lookAtTarget.position;
        transform.position = followTarget.position + diff * offset.z + playerOffset;
    }
}
