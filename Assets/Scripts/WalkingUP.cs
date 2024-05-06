using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingUP : MonoBehaviour
{
    public Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            anim.SetBool("IsWalkingUp", true);
    }
}
