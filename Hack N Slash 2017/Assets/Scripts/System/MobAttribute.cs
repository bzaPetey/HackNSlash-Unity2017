using UnityEngine;

public class MobAttribute {
    [SerializeField] string AttributeName;
    [SerializeField] int currentValue;
    [SerializeField] int baseValue;

    [SerializeField] Icon icon;
    [SerializeField] AttributeTypes attribute;


    public string Name
    {
        get { return AttributeName; }
        set { AttributeName = value; }
    }

    public int BaseValue
    {
        get { return baseValue; }
        set { baseValue = value; }
    }

    public void AddToBaseValue(int amt)
    {
        baseValue += amt;
    }

    public int CurrentAttributeValue
    {
        get { return currentValue; }
        set { currentValue = value; }
    }

    public void AddToCurrentValue (int amt)
    {
        currentValue += amt;
    }
}
