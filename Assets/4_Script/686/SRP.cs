using UnityEngine;

public class SRP : MonoBehaviour {

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

        switch (hit.collider.gameObject.name)
        {
            case "Button1":
                Debug.Log("ボタン1が押されました。");
                break;
            case "Button2":
                Debug.Log("ボタン2が押されました。");
                break;
            case "Button3":
                Debug.Log("ボタン3が押されました。");
                break;
        }
    }
}
