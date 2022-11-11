using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolderSlot : MonoBehaviour
{
    public Transform parentOverride;
    public bool isTop;
    public bool isBottom;

    public GameObject currentModel;

    public void UnloadModel()
    {
        if(currentModel != null)
        {
            currentModel.SetActive(false);
        }
    }

    public void UnloadWeaponAndDestroy()
    {
        if(currentModel != null)
        {
            Destroy(currentModel);
        }
    }

    public void LoadModel(CustomizationItem item)
    {
        UnloadWeaponAndDestroy();

        if(item == null)
        {
            UnloadModel();
            return;
        }

        GameObject model = Instantiate(item.modelPrefab) as GameObject;

        if(model != null)
        {
            if(parentOverride != null)
            {
                model.transform.parent = parentOverride;
            }
            else
            {
                model.transform.parent = transform;
            }

            model.transform.localPosition = Vector3.zero;
            model.transform.localRotation = Quaternion.identity;
            model.transform.localScale = Vector3.one;
        }

        currentModel = model;
    }
}
