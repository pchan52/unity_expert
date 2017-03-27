using UnityEngine;
using DG.Tweening;

public class BoundText : MonoBehaviour
{
    private void Update () {
        if (!Input.GetMouseButtonDown(0)) return;
        // 跳ねるっぽく
        transform.DOLocalMoveY(-30f, 2f).SetEase(Ease.OutBounce);
        transform.DOLocalMoveX(30f, 2f);
    }
}