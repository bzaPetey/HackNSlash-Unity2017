using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class Mob : MonoBehaviour {
    [SerializeField] string mobName;
    [SerializeField] int curHealth;
    [SerializeField] int maxHealth;
    [SerializeField] int level;

    [SerializeField] Icon icon;
    [SerializeField] List<Buff> buffs;


    public string Name
    {
        get { return mobName; }
        set { mobName = value; }
    }


    public int CurrentHealth
    {
        get { return curHealth; }
        set {
            if (value < 0)
                curHealth = 0;
            else if (value > maxHealth)
                curHealth = maxHealth;
            else
                curHealth = value;
            }
    }

    public int MaxHealth
    {
        get { return maxHealth; }
        set
        {
            if (value < 1)
                maxHealth = 1;
            else
                maxHealth = value;
        }
    }


    public int Level
    {
        get { return level; }
        set
        {
            if (value < 0)
                level = 0;
            else
                level = value;
        }
    }


    public void LevelUp()
    {
        level++;
    }


    public Icon ThumbNail
    {
        get { return icon; }
        set { icon = value; }
    }


    public List<Buff> Buffs
    {
        get { return buffs; }
        set { buffs = value; }
    }


    public void AddBuff(Buff b)
    {
        buffs.Add(b);
    }


    //remove buff/buffs
}
