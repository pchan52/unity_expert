using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMoverWithAnimator : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("isVertical", false);
            anim.SetBool("isHorizontal", true);
        }

        if (Input.GetMouseButtonDown(1))
        {
            anim.SetBool("isHorizontal", false);
            anim.SetBool("isVertical", true);
        }
    }
}
