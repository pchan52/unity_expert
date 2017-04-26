using UnityEngine;

public class Button1 : MonoBehaviour, IButton {

    public void Press()
    {
        Debug.Log("pressed button1");
    }
}
