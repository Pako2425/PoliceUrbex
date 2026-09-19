using UnityEngine;
using UnityEngine.InputSystem;

public class FlashlightController : MonoBehaviour
{
    [SerializeField] private Light flashlight;

    public void OnFlashlight(InputValue value)
    {
        if (!value.isPressed)
        {
            return;
        }

        flashlight.enabled = !flashlight.enabled;
    }
}
