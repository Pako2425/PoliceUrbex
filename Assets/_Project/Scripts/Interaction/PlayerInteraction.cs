using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float interactionDistance = 3f;
    [SerializeField] private TMP_Text interactionPromptText;

    private IInteractable currentInteractable;
    private IInteractable previousInteractable;

    private void Awake()
    {
        if (interactionPromptText != null)
        {
            interactionPromptText.gameObject.SetActive(false);
        }
    }

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

        UpdatePrompt();

        Debug.DrawRay(
            ray.origin,
            ray.direction * interactionDistance,
            Color.red
        );
    }

    private void UpdatePrompt()
	{
		if (interactionPromptText == null)
		{
			return;
		}

		if (currentInteractable == previousInteractable)
		{
			return;
		}

		previousInteractable = currentInteractable;

		if (currentInteractable != null)
		{
			interactionPromptText.text =
				$"[E] {currentInteractable.InteractionPrompt}";

			interactionPromptText.gameObject.SetActive(true);
		}
		else
		{
			interactionPromptText.gameObject.SetActive(false);
		}
	}

    public void OnInteract(InputValue value)
	{
		if (!value.isPressed)
		{
			return;
		}

		if (currentInteractable == null)
		{
			return;
		}

		currentInteractable.Interact();

		previousInteractable = null;
		UpdatePrompt();
	}
}
