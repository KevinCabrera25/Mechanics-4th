using UnityEngine;

public class GravitationalConstant : MonoBehaviour
{
    // The other GO
    [SerializeField] Transform otherObject;
    // Gravitational Constant
    [SerializeField] float _gravityConstant = 6.67408e-11f;
    // Mass of the Object
    [SerializeField] float _objectMass = 1;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Calculates the difference of the position between the two GO, and this distant is absolute
        Vector3 direction = (otherObject.position - transform.position).normalized;

        //
        float _distance = Vector3.Distance(otherObject.position, otherObject.position);
        /*
        float _massObjectTwo = otherObject.GetComponent<Gravity>().
        */
    }
}
