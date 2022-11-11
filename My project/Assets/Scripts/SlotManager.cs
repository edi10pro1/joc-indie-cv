using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManager : MonoBehaviour
{
    HolderSlot topSlot;
    HolderSlot bottomSlot;

    public GameObject model;

    private void Awake()
    {
        HolderSlot[] equipmentHolderSlots = GetComponentsInChildren<HolderSlot>();
        foreach (HolderSlot equipmentSlot in equipmentHolderSlots)
        {
            if (equipmentSlot.isTop)
            {
                topSlot = equipmentSlot;
            }
            else if (equipmentSlot.isBottom)
            {
                bottomSlot = equipmentSlot;
            }
        }
    }

    public void LoadEquipmentOnSlot(CustomizationItem item, bool isTop , bool isBottom)
    {
        if (isTop)
        {
            topSlot.LoadModel(item);
        }
        else if (isBottom)
        {
            bottomSlot.LoadModel(item);
        }
    }
}
