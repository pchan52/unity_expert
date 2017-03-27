﻿/*********************************
 * フロートメニューっていうかあれの展開（笑）
 * with DOTween
*********************************/
using System;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

using DG.Tweening;

[RequireComponent(typeof(Image))]
public class ExpandButton : MonoBehaviour
{

    /// <summary>
    /// 展開時の画像（optional）
    /// </summary>
    [SerializeField] private Sprite expandedImage;
    /// <summary>
    /// 小ボタンの設定
    /// </summary>
    [SerializeField] private Setting[] settings;

    private RectTransform rectTransform;
    private Image image;
    private List<GameObject> children;
    private bool isExpanded = false;
    private Sprite sourceImage;

    /// <summary>
    /// 子ボタンの設定
    /// </summary>
    /// <value>The settings.</value>
    public Setting[] Settings {
        get { return this.settings; }
        set {
            this.settings = value;
            BuildChildren();
        }
    }
    /// <summary>
    /// メニュー展開済みか
    /// </summary>
    /// <value><c>true</c> if this instance is expanded; otherwise, <c>false</c>.</value>
    public bool IsExpanded {
        get { return this.isExpanded; }
    }

    private void Awake()
    {
        this.rectTransform = this.gameObject.GetComponent<RectTransform>();
        this.image = this.gameObject.GetComponent<Image>();
        this.children = new List<GameObject>();
    }

    private void Start()
    {
        this.sourceImage = this.image.sprite;
        BuildChildren();
    }

    /// <summary>
    /// タップ時にトグルさせる
    /// </summary>
    public void OnTap()
    {
        if (!this.isExpanded) {
            Expand();
        } else {
            Collapse();
        }

    }

    /// <summary>
    /// 子ボタン展開
    /// </summary>
    public void Expand()
    {
        if (this.isExpanded) {
            return;
        }
        this.isExpanded = true;

        for (int i = 0; i < this.children.Count; i++) {
            this.children[i].SetActive(true);
            var seq = DOTween.Sequence();
            seq.Append(
                this.children[i].GetComponent<RectTransform>()
                    .DOLocalMoveY(this.rectTransform.rect.height * (i + 1), 0.3f)
                    .SetEase(Ease.OutCirc)
            );
            var img = this.children[i].GetComponent<Image>();
            seq.Join(
                DOTween.To(
                    () => img.color,
                    c => img.color = c,
                    new Color(1, 1, 1, 1),
                    0.2f
                ).SetEase(Ease.OutCirc)
            );
        }

        // 展開時の画像が設定されていたら差し替える
        if (this.expandedImage != null) {
            this.image.sprite = this.expandedImage;
        }
    }

    /// <summary>
    /// 子ボタン閉じる
    /// </summary>
    public void Collapse()
    {
        if (!this.isExpanded) {
            return;
        }
        this.isExpanded = false;

        for (int i = this.children.Count - 1; i >= 0; i--) {
            var child = this.children[i];
            var seq = DOTween.Sequence();
            seq.Append(
                child.GetComponent<RectTransform>()
                    .DOLocalMoveY(0, 0.2f)
                    .SetEase(Ease.OutCirc)
                    .OnComplete(()=>{
                        child.SetActive(false);
                    })
            );
            var img = this.children[i].GetComponent<Image>();
            seq.Join(
                DOTween.To(
                    () => img.color,
                    c => img.color = c,
                    new Color(1, 1, 1, 0),
                    0.15f
                ).SetEase(Ease.OutCirc)
            );
        }

        // 展開時の画像が設定されていたら差し替えられているので戻す
        if (this.expandedImage) {
            this.image.sprite = this.sourceImage;
        }
    }

    /// <summary>
    /// 子ボタンを指定された設定にしたがって構築
    /// </summary>
    private void BuildChildren()
    {

        ClearAll();

        // 先に設定されたものを全面にしたいので
        // 逆（後ろ）から作っていく
        for (int i = this.settings.Length - 1; i >= 0; i--) {
            var setting = this.settings[i];
            var gameObject = new GameObject("Child Button");
            // サイズ
            var rectTransform = gameObject.AddComponent<RectTransform>();
            rectTransform.position = this.rectTransform.position;
            rectTransform.sizeDelta = new Vector2(
                this.rectTransform.rect.width * setting.Scale,
                this.rectTransform.rect.height * setting.Scale
            );
            // 画像
            var image = gameObject.AddComponent<Image>();
            image.sprite = setting.Image;
            image.color = new Color(1, 1, 1, 0);
            // タップイベント
            var button = gameObject.AddComponent<Button>();
            button.targetGraphic = image;
            button.onClick.AddListener(delegate {
                OnTapChild(setting);
            });

            gameObject.transform.SetParent(this.gameObject.transform);
            gameObject.SetActive(false);
            this.children.Add(gameObject);
        }
        this.children.Reverse();
    }

    /// <summary>
    /// 子ボタンを全クリ
    /// </summary>
    private void ClearAll()
    {
        foreach (var gameObject in this.children) {
            Destroy(gameObject);
        }
        this.children.Clear();
    }

    /// <summary>
    /// 子ボタンタップ時のハンドリング
    /// </summary>
    /// <param name="setting">Setting.</param>
    private void OnTapChild(Setting setting)
    {
        if (setting.OnTap != null) {
            setting.OnTap.Invoke();
        }
        Collapse();
    }

}

[Serializable]
public class Setting
{
    public Sprite Image;
    public float Scale = 1.0f;
    public UnityEvent OnTap;
}