using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovQuill : MonoBehaviour
{
    public float signingDuration = 2.0f; // Duración de la firma
    public AnimationCurve signingCurve; // Curva de animación para el efecto de firma

    private bool isLevitating = false;
    private Vector3 originalPosition;
    private Vector3 targetPosition;
    private float signingStartTime;
    

 
      [SerializeField]
    [Range(0, 10)]
    float period = 1;

    [SerializeField]
    [Range(0, 10)]
    private float amplitude = 0.2f;
    public int numero = 0;
    public int numero2 = 1;
    void Update()
    {
        if (numero == 0)
        {
            return;
        }
        // Simple harmonic movement on x component
        float factor = Time.time / period;
        float x = amplitude * Mathf.Sin(factor);
        x = x * 0.0001f;
        // Update the position
        if(numero2==0)
        {
            return;
        }
        transform.position = new Vector3(transform.position.x+x*3f, transform.position.y, transform.position.z + x);
        //transform.position.Draw(Color.yellow);
    }

    private void OnMouseDown()
    {
        numero = 1;
    }
   
        void OnCollisionEnter(Collision collision)
    
        {
        Debug.Log("aaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
        numero2 = 0;
        }
    }
