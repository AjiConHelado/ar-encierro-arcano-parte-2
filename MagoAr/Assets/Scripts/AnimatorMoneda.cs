using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorMoneda : MonoBehaviour
{
    // Start is called before the first frame update
    Animator m_Animator;
    public GameObject mago;
    private void Start()
    {
        m_Animator = mago.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        m_Animator.SetTrigger("bailecitoMagico");
    }

   
}
