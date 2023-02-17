using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthMovement : MonoBehaviour
{
    [SerializeField] private float _speedTraslation = 0;
    [SerializeField] private Vector3 _vector = Vector3.forward;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      // transform.Translate(_speedTraslation, 0f, 0f);
    }
    private void FixedUpdate()
    {
        transform.Translate(_vector * _speedTraslation * Time.fixedDeltaTime);
    }
}
