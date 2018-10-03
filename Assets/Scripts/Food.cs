using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Consumable
{
    public float Saturation;

    public bool IsYummy;

    public override string UseText()
    {
        if (Uses != MaxUses)
            return "You ate a piece of the " + Name + ", There is now " + (MaxUses - Uses) + " pieces left. Your saturation increased by " + Saturation + ". " + YummyText();
        else
        {
            string returntext = "You ate up the " + Name + ". ";
            if (MaxUses > 1)
                returntext += "There is now no pieces left. ";
            returntext += "Your saturation increased by " + Saturation + ". " + YummyText();

            return returntext;
        }
    }

    public override string ToString()
    {
        string returntext = "This is " + Name + ", it weighs " + weight + " kilograms and costs " + GetPricePerWeight() + " kr. ";

        if (MaxUses > 1)
            returntext += Uses + " out of " + MaxUses + " pieces have been eaten. ";

        returntext += "It has " + Saturation + " saturation and";

        if (IsYummy)
            returntext += " it is yummy.";
        else
            returntext += " it isn't yummy.";

        return returntext;
    }

    public override string NoUsesRemainingText()
    {
        return "You cannot eat this anymore, there's nothing left!";
    }

    public string YummyText()
    {
        if (IsYummy)
            return "It was yummy! Oh yeah!";
        else
            return "It wasn't yummy, yuck!";
    }
}


