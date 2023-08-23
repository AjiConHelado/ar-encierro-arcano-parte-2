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
    public GameObject[] quills ;
    private void Start()
    {
        originalPosition = transform.position;
        targetPosition = originalPosition + Vector3.up * levitationHeight;
    }

    private void Update()
    {
      
    }
    public void OnMouseDown()
    {
        foreach ( GameObject quill in quills)
        {
            quill.GetComponent<candle>().numero = 1;
        }
      
      
    }
    
}