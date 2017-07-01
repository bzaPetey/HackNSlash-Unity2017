using UnityEngine;

[System.Serializable]
public class Buff {
    [SerializeField] string buffName;
    [SerializeField] int duration;
    [SerializeField] int curDuration;
    [SerializeField] bool permanent = false;

    [SerializeField] Icon icon;

    //effects
    //how to tell if it is a buff or a debuff
}
