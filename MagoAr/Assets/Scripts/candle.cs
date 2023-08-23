using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candle : MonoBehaviour
{
    [SerializeField]
    [Range(0, 10)]
    float period = 1;

    [SerializeField]
    [Range(0, 10)]
    private float amplitude = 0.2f;
    public int numero=0;
    void Update()
    {
        if (numero == 0)
        {
            return;
        }
        // Simple harmonic movement on x component
        float factor = Time.time / period;
        float x = amplitude * Mathf.Sin( factor);
        x = x * 0.0001f;
        // Update the position
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z+x);
        //transform.position.Draw(Color.yellow);
    }
}
