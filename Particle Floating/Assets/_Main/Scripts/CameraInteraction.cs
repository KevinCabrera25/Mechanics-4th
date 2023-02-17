using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInteraction : MonoBehaviour
{
    // Variable to assign the camera
    [SerializeField] private Camera _mainCamera;
    // Variable to assign the GO 
    [SerializeField] private GameObject _earth;
    // Variable to assign the Main Parent of the Camera 
    [SerializeField] private GameObject _mainParent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If the left click on the mouse is pressed 
        if(Input.GetMouseButtonDown(0))
        {
            // The Main Camera becomes child of the GO _earth
            _mainCamera.transform.parent = _earth.transform;
        }

        // If the left click is not pressed
        if (Input.GetMouseButtonUp(0))
        {
            // The Main Camera becomes child of the GO _mainParent to unparent the Camera with the GO _earth
            _mainCamera.transform.parent = _mainParent.transform;
            // The Main Camera is set to the Vector3 position 
            _mainCamera.transform.position = new Vector3(129f, 1328f, -844f);
            // The Main Camera is set to the original rotation position
            _mainCamera.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }
}
