using UnityEngine;

public class Button2 : MonoBehaviour, IButton {

    public void Press()
    {
        Debug.Log("pressed button2");
    }
}
