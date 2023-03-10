using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    [SerializeField] private Transform _centerOfGravity;
    [SerializeField] private float _gravityForce = 9.81f;
    [SerializeField] private float _rotationSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Calculates the direction of the Gravity Force
        Vector3 gravityDirection = (_centerOfGravity.position - transform.position).normalized;

        // Applies the Force of the Gravity to the GO
        GetComponent<Rigidbody>().AddForce(gravityDirection * _gravityForce);

        // Rotates the GO around another Object
        transform.RotateAround(_centerOfGravity.position, Vector3.up, _rotationSpeed * Time.deltaTime);
    }
}
