using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public static PlayerInventory Instance { get; private set; }

    private readonly HashSet<string> collectedItems = new HashSet<string>();

    private void Awake()
    {
        Instance = this;
    }

    public bool AddItem(string itemId)
    {
        if (string.IsNullOrWhiteSpace(itemId))
        {
            return false;
        }

        if (!collectedItems.Add(itemId))
        {
            Debug.Log($"Przedmiot '{itemId}' jest już w ekwipunku.");
            return false;
        }

        Debug.Log($"Dodano przedmiot: {itemId}");
        return true;
    }

    public bool HasItem(string itemId)
    {
        return collectedItems.Contains(itemId);
    }
}
