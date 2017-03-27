using UnityEngine;
using System.Collections;
using System.Net.Mime;
using DG.Tweening;
using UnityEngine.UI;
public class TweenManager : MonoBehaviour
{

    [SerializeField] private Image image;
    private RectTransform rectTransform;

    private void Start () {
        rectTransform = image.GetComponent<RectTransform>();
        rectTransform.DOMove(new Vector3(Screen.width,0,0),5.0f);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rectTransform.DOMove(new Vector3(-1 * Screen.width,0,0),5.0f);
        }

        if (Input.GetMouseButtonDown(1))
        {
            rectTransform.DOMove(new Vector3(Screen.width,0,0),5.0f);
        }
    }
}