using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customization : MonoBehaviour
{
    [Header("Tabs")]
    public GameObject outfitTab;
    public GameObject colorsTab;
    public GameObject topsTab;
    public GameObject bottomsTab;
    public GameObject customizeTab;

    [Header("References")]
    public SlotManager slotManager;
    [NonReorderable] public Outfit[] outfits;

    #region Tabs
    public void CloseAllTabs()
    {
        outfitTab.SetActive(false);
        colorsTab.SetActive(false);
        topsTab.SetActive(false);
        bottomsTab.SetActive(false);
        customizeTab.SetActive(false);
    }

    public void OutfitTab()
    {
        CloseAllTabs();
        outfitTab.SetActive(true);
    }

    public void ColorsTab()
    {
        CloseAllTabs();
        colorsTab.SetActive(true);
    }

    public void TopsTab()
    {
        CloseAllTabs();
        topsTab.SetActive(true);
    }

    public void BottomsTab()
    {
        CloseAllTabs();
        bottomsTab.SetActive(true);
    }

    public void CustomizeTab()
    {
        CloseAllTabs();
        customizeTab.SetActive(true);
    }
    #endregion

    #region Outfits Tab

    #endregion

    #region Colors Tab

    #endregion

    #region Tops Tab

    public void AssignTop(int index)
    {
        slotManager.LoadEquipmentOnSlot(outfits[index].topItem,true,false);
    }

    #endregion

    #region Bottoms Tab

    public void AssignBottom(int index)
    {
        slotManager.LoadEquipmentOnSlot(outfits[index].bottomItem, false, true);
    }

    #endregion
}
