using UnityEngine;

public class TestInteractable : MonoBehaviour, IInteractable
{
    public string InteractionPrompt => "Interakcja";

    public void Interact()
    {
        Debug.Log($"Interakcja z obiektem: {gameObject.name}");
    }
}
