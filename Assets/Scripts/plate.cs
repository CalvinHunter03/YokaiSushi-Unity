using UnityEngine;
using UnityEngine.InputSystem;

public class plate : MonoBehaviour
{
    Camera mainCamera;
    public LayerMask plateLayer; // Assign your desired layer in the Inspector

    public static bool cardOverPlate;

    public float fullness;
    public float statisfaction;
    

    void Awake()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        CheckMousePosition();
    }

    void CheckMousePosition()
    {
        // Convert mouse screen position to a ray in the world
        Ray ray = mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
        RaycastHit hit;

        // Perform the raycast
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, plateLayer))
        {
            // Check if the collider hit is the specific one you care about
            if (hit.collider.gameObject == this.gameObject)
            {

                if (CardHandManager.dragging)
                {
                    Debug.Log("I am holding a ccard and over the plate");
                    cardOverPlate = true;
                }
                // Add your logic here (e.g., highlight object, show tooltip)
            }
        }
        else
        {
            // Mouse is not over any object on the interaction layer, or the specific object
            cardOverPlate = false;
        }
    }
}
