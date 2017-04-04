﻿using UnityEngine;

public class SRPModify : MonoBehaviour {

    private void Update()
    {
        if (!Input.GetMouseButtonDown(0))
        {
            return;
        }

        RaycastHit hit;
        if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        {
            return;
        }

        var button = hit.collider.GetComponent<IButton>();
        if (button != null)
        {
            button.Press();
        }
    }

}
