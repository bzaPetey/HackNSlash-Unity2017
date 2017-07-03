using UnityEngine;

[System.Serializable]
public class Buff {
    [SerializeField] string buffName;
    [SerializeField] int duration;
    [SerializeField] int curDuration;
    [SerializeField] bool permanent = false;
    [SerializeField] bool isBuff;               //if not a buff, then a debuff

    [SerializeField] Icon icon;

    //effects
        //stat - amount
    //description
    //buff level
}
