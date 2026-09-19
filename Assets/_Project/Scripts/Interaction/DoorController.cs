using UnityEngine;

public class DoorController : MonoBehaviour, IInteractable
{
    [SerializeField] private float openAngle = 90f;
    [SerializeField] private float rotationSpeed = 120f;

    private bool isOpen;

    private Quaternion closedRotation;
    private Quaternion openRotation;

    public string InteractionPrompt =>
        isOpen ? "Zamknij drzwi" : "Otwórz drzwi";

    private void Awake()
    {
        closedRotation = transform.localRotation;

        openRotation =
            closedRotation * Quaternion.Euler(0f, openAngle, 0f);
    }

    private void Update()
    {
        Quaternion targetRotation =
            isOpen ? openRotation : closedRotation;

        transform.localRotation = Quaternion.RotateTowards(
            transform.localRotation,
            targetRotation,
            rotationSpeed * Time.deltaTime
        );
    }

    public void Interact()
    {
        isOpen = !isOpen;
    }
}
