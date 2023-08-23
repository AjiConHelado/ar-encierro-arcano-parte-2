using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevitationController : MonoBehaviour
{
    public float levitationHeight = 1.0f; 
    public float levitationSpeed = 2.0f; // Velocidad de levitación

    private bool isLevitating = false;
    private Vector3 originalPosition;
    private Vector3 targetPosition;

    private void Start()
    {
        originalPosition = transform.position;
        targetPosition = originalPosition + Vector3.up * levitationHeight;
    }

    private void Update()
    {
        if (isLevitating)
        {
           
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * levitationSpeed);
        }
        else
        {
           
            transform.position = Vector3.Lerp(transform.position, originalPosition, Time.deltaTime * levitationSpeed);
        }
    }
    public void OnMouseDown()
    {

        isLevitating = true;

    }
    
}