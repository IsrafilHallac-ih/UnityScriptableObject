using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public Items currentItem;
    void Start()
    {
        Debug.Log("Esyanýn adý" + currentItem.itemName);
    }

    
}
