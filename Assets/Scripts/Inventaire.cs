using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventaire : MonoBehaviour
{
    private List<GameObject> items = new List<GameObject>();
    private Inventaire inventaire;
    public Image InventaireUI;

    public void AddItems(GameObject item)
    {
        items.Add(item);
        item.SetActive(false);
    }

    public void RemoveItem(GameObject item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            Destroy(item);
        }
    }

    public bool HasItem(GameObject item)
    {
        return items.Contains(item);
    }
}
