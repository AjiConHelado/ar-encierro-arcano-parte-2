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

    private void Start()
    {
        originalPosition = transform.position;
        targetPosition = originalPosition + Vector3.up * 0.5f; // Cambia la altura a tu preferencia
    }

    private void Update()
    {
        if (isLevitating)
        {
            float timeSinceSigningStart = Time.time - signingStartTime;
            float t = Mathf.Clamp01(timeSinceSigningStart / signingDuration);

            // Usa la curva de animación para calcular la posición
            Vector3 newPos = Vector3.Lerp(originalPosition, targetPosition, signingCurve.Evaluate(t));
            transform.position = newPos;

            if (t >= 1.0f)
            {
                isLevitating = false;
            }
        }
        else
        {
            // Regresar a la posición inicial
            transform.position = Vector3.Lerp(transform.position, originalPosition, Time.deltaTime);
        }
    }

    private void OnMouseDown()
    {
        isLevitating = true;
        signingStartTime = Time.time;
    }
}
