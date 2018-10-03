using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : Item
{
    public float Uses;
    public float MaxUses;

    public void OnMouseUpAsButton()
    {
        if (Uses != MaxUses)
        {
            Use();
            print(UseText());
        }
        else
            print(NoUsesRemainingText());
    }

    public virtual void Use()
    {
        Uses++;
    }

    public virtual string UseText()
    {
        return "You used the " + Name + ", It has now been used " + Uses + "/" + MaxUses + " times.";
    }

    public virtual string NoUsesRemainingText()
    {
        return "You cannot use this item anymore! It has been used " + MaxUses + "/" + MaxUses + " times.";
    }

    public override string ToString()
    {
        return base.ToString() + " It has been used " + Uses + " out of " + MaxUses + " times.";
    }
}
