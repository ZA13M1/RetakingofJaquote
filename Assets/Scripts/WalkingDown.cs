using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingDown : MonoBehaviour
{
    public Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.S))
            anim.SetBool("IsWalkingDown", true);
    }
}
