using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string Name;
    public float cost;
    public float weight;

    public float GetPricePerWeight()
    {
        return (cost / weight);
    }

    public override string ToString()
    {
        return "This is " + Name + ", it weighs " + weight + " kilograms and costs " + GetPricePerWeight() + " kr.";
    }

    public virtual void OnMouseEnter()
    {
        print(ToString());
    }
}
