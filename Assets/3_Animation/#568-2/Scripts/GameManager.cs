using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text _text;
    private int _num;

    //  Numがカスタムプロパティ
    [SerializeField] private int Num {
        set {
            _num = value;
            // Numに値が代入されると画面上の文字が更新される
            _text.text = _num.ToString ();
        }
        get {
            return _num;
        }
    }

    void Start ()
    {
        DOTween.To (() => Num, (n) => Num = n, 100, 2f).SetEase (Ease.Linear);
    }
}