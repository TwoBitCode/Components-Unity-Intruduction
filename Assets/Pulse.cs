using UnityEngine;

public class PulseEffect : MonoBehaviour
{
    // Minimum and maximum scale for the pulsing effect
    [SerializeField]
    [Tooltip("How much the object contracts in precentage")]
    public float contractionPrecentage = 40f;
    [SerializeField]
    [Tooltip("How much the object expands in precentage")]
    public float expansionPrecentage = 20f;

    // How fast the object will pulse
    [SerializeField]
    [Tooltip("Pulsing speed")]
    public float pulseSpeed = 3.0f;

    // Time variable to control the pulsing effect
    private float timer = 0.0f;

    private Vector3 InitialScale; // Initial object scale
    private Vector3 minScale; // The minimum scale the object can reach
    private Vector3 maxScale; // The maximum scale the object can reach

    private void Start()
    {
        // save initial scale
        InitialScale = transform.localScale;
    }

    void Update()
    {
        minScale = InitialScale * (-contractionPrecentage / 100); // calculating min scale 
        maxScale = InitialScale * (expansionPrecentage / 100); // calculating max scale 

        // Increment the timer based on time and speed
        timer += Time.deltaTime * pulseSpeed;

        // Calculate the scale factor using a sine wave
        float scale = (Mathf.Sin(timer) + 1.0f) / 2.0f; // Normalized to 0..1

        // Interpolate between the minScale and maxScale (compared to InitialScale)
        transform.localScale = Vector3.Lerp(minScale + InitialScale, maxScale + InitialScale, scale);
    }
}
