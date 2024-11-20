using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Speed of the rotation")]
    public float rotationSpeed = 100.0f; // defines how fast the rotation would be
    [SerializeField]
    [Tooltip("1 - if we want to include x axis rotation, 0 otherwise")]
    public float x_axis_rotation = 0f; // 1 - if we want to include x axis rotation, 0 otherwise
    [SerializeField]
    [Tooltip("1 - if we want to include y axis rotation, 0 otherwise")]
    public float y_axis_rotation = 1f; // 1 - if we want to include y axis rotation, 0 otherwise
    [SerializeField]
    [Tooltip("1 - if we want to include z axis rotation, 0 otherwise")]
    public float z_axis_rotation = 0f; // 1 - if we want to include z axis rotation, 0 otherwise


    private void Update()
    {
        // By default we only change the y exis since the movement of rotation we want is around the y exis.
        Vector3 x_vector = new Vector3(1, 0, 0);
        Vector3 y_vector = new Vector3(0, 1, 0);
        Vector3 z_vector = new Vector3(0, 0, 1);

        // Creating change vector 
        Vector3 change_vector = (x_vector * x_axis_rotation) + (y_vector * y_axis_rotation) + (z_vector * z_axis_rotation);
        // Addition to the axes we choose to rotation
        transform.Rotate(change_vector * rotationSpeed * Time.deltaTime);
    }
}
