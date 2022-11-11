using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Outfit
{
    [Header("Outfit Name")]
    public string outiftName;

    [Header("Clothes")]
    public TopItem topItem;
    public BottomItem bottomItem;
}
