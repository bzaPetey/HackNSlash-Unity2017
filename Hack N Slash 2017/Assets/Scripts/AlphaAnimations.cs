using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]
public class AlphaAnimations : MonoBehaviour {
    Animator anim;


    private void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        anim.SetFloat("speed", Input.GetAxis("Vertical"));
    }
}
