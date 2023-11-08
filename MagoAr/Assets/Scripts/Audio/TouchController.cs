using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    Touch touch;
    NarrationPlayer narrationPlayer;

    private void Start()
    {
        try
        {
            narrationPlayer = (NarrationPlayer)FindObjectOfType<NarrationPlayer>();
        }
        catch
        {
            Debug.LogWarning("In this scene there is no NarrationPlayer");
        }
    }

    private void Update()
    {
        if(Input.touchCount > 0 && narrationPlayer != null)
        {
            touch = Input.GetTouch(0);
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.tag == "AudioHit")
                    narrationPlayer.PlayAudioInOrder();
            }
        }
    }
}
