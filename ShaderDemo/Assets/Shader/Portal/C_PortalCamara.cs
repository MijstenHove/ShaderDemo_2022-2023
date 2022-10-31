using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_PortalCamara : MonoBehaviour
{
    public Transform playerCamera;
	public Transform portal;
	public Transform otherPortal;
	
	// Update is called once per frame
	void Update () {
		portal.rotation = playerCamera.rotation;
        otherPortal.rotation = playerCamera.rotation;
        
        Vector3 playeroffset = playerCamera.position - portal.position ; 
        print(playeroffset);
        //portal.position = portal.position + playeroffset ; 
        
        //Vector3 playerOffsetFromPortal = playerCamera.position - otherPortal.position;
		//portal.position = portal.position + playerOffsetFromPortal;
    
		//float angularDifferenceBetweenPortalRotations = Quaternion.Angle(portal.rotation, otherPortal.rotation);

		//Quaternion portalRotationalDifference = Quaternion.AngleAxis(angularDifferenceBetweenPortalRotations, Vector3.up);
		//Vector3 newCameraDirection = portalRotationalDifference * playerCamera.forward;
		//portal.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);
        
    }
}
