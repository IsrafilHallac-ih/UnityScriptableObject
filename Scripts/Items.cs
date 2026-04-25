using UnityEngine;
[CreateAssetMenu(fileName ="NewItem",menuName ="Item")]
public class Items : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    public int value;
}
