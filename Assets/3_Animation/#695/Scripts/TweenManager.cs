using UnityEngine;
using System.Collections;
using System.Net.Mime;
using DG.Tweening;
using UnityEngine.UI;
public class TweenManager : MonoBehaviour
{

    [SerializeField] private Image image;
    private RectTransform rectTransform;
    [SerializeField] private Text text;

    private void Start () {
        rectTransform = image.GetComponent<RectTransform>();
        rectTransform.DOMove(new Vector3(Screen.width,0,0),5.0f);
        text.enabled = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rectTransform.DOMove(new Vector3(-1 * Screen.width,0,0),5.0f);
            text.enabled = true;
        }

        if (Input.GetMouseButtonDown(1))
        {
            rectTransform.DOMove(new Vector3(Screen.width,0,0),5.0f);
        }
    }
}