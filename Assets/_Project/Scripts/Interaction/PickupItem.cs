using UnityEngine;

public class PickupItem : MonoBehaviour, IInteractable
{
    [SerializeField] private string itemId = "test_item";
    [SerializeField] private string itemName = "Przedmiot";

    public string InteractionPrompt => $"Podnieś {itemName}";

    public void Interact()
    {
        if (PlayerInventory.Instance == null)
        {
            Debug.LogWarning("Nie znaleziono PlayerInventory.");
            return;
        }

        bool added = PlayerInventory.Instance.AddItem(itemId);

        if (!added)
        {
            return;
        }

        Destroy(gameObject);
    }
}
