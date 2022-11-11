using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCharacterPreview : MonoBehaviour
{
    public GameObject characterPreview;

    public float rotationAmount = 1;
    public float rotationSpeed = 5;

    public Vector3 currentRotation;
    public Vector3 targetRotation;

    public void Start()
    {
        currentRotation = characterPreview.transform.eulerAngles;
        targetRotation = characterPreview.transform.eulerAngles;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            targetRotation.y = targetRotation.y + rotationAmount; 
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            targetRotation.y = targetRotation.y - rotationAmount;
        }

        currentRotation = Vector3.Lerp(currentRotation, targetRotation, rotationSpeed * Time.deltaTime);
        characterPreview.transform.eulerAngles = currentRotation;
    }
}
