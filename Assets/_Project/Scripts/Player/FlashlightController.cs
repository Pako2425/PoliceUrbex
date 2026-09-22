using UnityEngine;
using UnityEngine.InputSystem;

public class FlashlightController : MonoBehaviour
{
    [SerializeField] private Light flashlight;

    private bool isOn = true;

    private void Awake()
    {
        if (flashlight != null)
        {
            flashlight.enabled = isOn;
        }
    }

    public void OnFlashlight(InputValue value)
    {
        if (!value.isPressed || flashlight == null)
        {
            return;
        }

        isOn = !isOn;
        flashlight.enabled = isOn;
    }
}
