using UnityEngine;

public class FootstepSystem : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip[] footstepClips;

    [SerializeField] private float walkInterval = 0.5f;
    [SerializeField] private float sprintInterval = 0.35f;

    private float stepTimer;

    private void Update()
    {
        if (characterController == null)
        {
            return;
        }

        bool isMoving =
            characterController.isGrounded &&
            new Vector2(
                characterController.velocity.x,
                characterController.velocity.z
            ).magnitude > 0.2f;

        if (!isMoving)
        {
            stepTimer = 0f;
            return;
        }

        bool isSprinting =
            new Vector2(
                characterController.velocity.x,
                characterController.velocity.z
            ).magnitude > 5f;

        float interval =
            isSprinting ? sprintInterval : walkInterval;

        stepTimer += Time.deltaTime;

        if (stepTimer >= interval)
        {
            PlayFootstep();
            stepTimer = 0f;
        }
    }

    private void PlayFootstep()
    {
        if (footstepClips == null || footstepClips.Length == 0)
        {
            return;
        }

        AudioClip clip =
            footstepClips[Random.Range(0, footstepClips.Length)];

        audioSource.pitch = Random.Range(0.95f, 1.05f);
        audioSource.PlayOneShot(clip);
    }
}
