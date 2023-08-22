using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    // Start is called before the first frame update
    Animator m_Animator;

    private void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        m_Animator.SetTrigger("Mirada");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
