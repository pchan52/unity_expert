using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(CanvasGroup))]
public class BlinkCanvasGroup : MonoBehaviour
{
    [SerializeField] float DurationSeconds;
    [SerializeField] Ease EaseType;

    private CanvasGroup canvasGroup;

    private void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.DOFade(0.0f, DurationSeconds).SetEase(EaseType).SetLoops(-1, LoopType.Yoyo);
    }
}