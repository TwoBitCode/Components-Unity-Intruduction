using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The pivot point - the point from which the pendulum 'hangs'/'sways'")]
    public Transform pivot;

    [SerializeField]
    [Tooltip("The pendulum ball/bob")]
    public Transform bob;

    [SerializeField]
    [Tooltip("The length of the pendulum")]
    public float length = 2f;

    [SerializeField]
    [Tooltip("Gravitational constant, influences the moving speed of the pendulum")]
    public float gravity = 9.8f; // Gravitational constant, influences the moving speed of the pendulum

    [SerializeField]
    [Tooltip("Initial angle in degrees")]
    public float angle = 2f;

    [SerializeField]
    [Tooltip("Boolean value that indicated whether we include friction into the movement or not")]
    public bool WithDamping = false;

    private float angularVelocity = 0f; // The angular velocity of the moving pendulum
    private float angularAcceleration = 0f; // // The angular acceleration of the moving pendulum
    private float DAMPING = 0.997f; // The value we use to damp the velocity
    private LineRenderer lineRenderer; // The pendulum rod, we need to add this as a component to pivot

    void Start()
    {
        // Initialize LineRenderer
        lineRenderer = pivot.GetComponent<LineRenderer>();
        lineRenderer.positionCount = 2;
        // Convert the angle to radians and position the bob
        angle = angle * Mathf.Deg2Rad;
        // We use Trigonometry to calculate the starting position of the bob
        bob.position = pivot.position + new Vector3(Mathf.Sin(angle), -Mathf.Cos(angle), 0) * length;
    }

    void Update()
    {
        // Pendulum dynamics
        angularAcceleration = -gravity / length * Mathf.Sin(angle); // Torque equation
        angularVelocity += angularAcceleration * Time.deltaTime; // update velocity -> [time] * [acceleration] = velocity
        angle += angularVelocity * Time.deltaTime;

        // Apply damping (optional, for realism)
        if (WithDamping)
        {
            angularVelocity *= DAMPING;
        }

        // Update bob's position
        bob.position = pivot.position + new Vector3(Mathf.Sin(angle), -Mathf.Cos(angle), 0) * length;
        // Update the LineRenderer
        lineRenderer.SetPosition(0, pivot.position); // start the line at pivot
        lineRenderer.SetPosition(1, bob.position); // End the line at bob
    }
}