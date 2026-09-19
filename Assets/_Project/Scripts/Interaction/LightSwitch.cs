using UnityEngine;

public class LightSwitch : MonoBehaviour, IInteractable
{
    [SerializeField] private Light controlledLight;

    public string InteractionPrompt =>
        controlledLight != null && controlledLight.enabled
            ? "Wyłącz światło"
            : "Włącz światło";

    public void Interact()
    {
        if (controlledLight == null)
        {
            return;
        }

        controlledLight.enabled = !controlledLight.enabled;
    }
}
