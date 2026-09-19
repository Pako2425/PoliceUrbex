using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float interactionDistance = 3f;

    private IInteractable currentInteractable;

    private void Update()
    {
        DetectInteractable();
    }

    private void DetectInteractable()
    {
        currentInteractable = null;

        Ray ray = new Ray(
            playerCamera.transform.position,
            playerCamera.transform.forward
        );

        if (Physics.Raycast(ray, out RaycastHit hit, interactionDistance))
        {
            currentInteractable =
                hit.collider.GetComponentInParent<IInteractable>();
        }

        Debug.DrawRay(
            ray.origin,
            ray.direction * interactionDistance,
            Color.red
        );
    }

    public void OnInteract(InputValue value)
    {
        if (!value.isPressed)
        {
            return;
        }

        currentInteractable?.Interact();
    }
}
