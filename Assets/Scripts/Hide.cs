using UnityEngine;
using UnityEngine.InputSystem;

public class HideObject : MonoBehaviour
{
    // Tracks the visibility state of the object
    private bool isObjectShown = true;
    private Vector3 camera_position; // The camera position
    private Vector3 original_position; // Object original position
    [SerializeField]
    [Tooltip("The input action to hide/show the object")]
    InputAction Hide = new InputAction(type: InputActionType.Button);

    private void OnEnable()
    {
        Hide.Enable();
    }

    private void OnDisable()
    {
        Hide.Disable();
    }

    private void Start()
    {
        // save the camera position and original position
        camera_position = Camera.main.transform.position;
        original_position = transform.position;
    }


    // Update is called once per frame
    private void Update()
    {
        if (Hide.WasPressedThisFrame())
        {
            // if object is shown -> we'll put inline with camera to hide
            if (isObjectShown)
            {
                Vector3 new_position = original_position + new Vector3(0, 0, camera_position.z);
                transform.position += new_position;
            }
            // if object is hidden -> we'll return to original position
            else
            {
                transform.position = original_position;
            }
            isObjectShown = !isObjectShown; // after each click reverse
        }
    }
}
