using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item : MonoBehaviour {
    [SerializeField] string itemName;
    [SerializeField] string description;

    [SerializeField] Icon icon;
    [SerializeField] ItemTypes itemType;

    //effects / buffs


    public string Name
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public Icon Thumbnail
    {
        get { return icon; }
        set { icon = value; }
    }

    public ItemTypes TypeOfItem
    {
        get { return itemType; }
    }
}
