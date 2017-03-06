using UnityEngine;

namespace _3_Animation.Scripts
{
    public class LifeController : MonoBehaviour {
        private RectTransform _rt;

        private void Start ()
        {
            _rt = GetComponent<RectTransform>();
        }

        public void LifeDown (int ap){
            //RectTransformのサイズを取得し、マイナスする
            _rt.sizeDelta -= new Vector2 (0,ap);
        }

        public void LifeUp (int hp)
        {
            //RectTransformのサイズを取得し、プラスする
            _rt.sizeDelta += new Vector2 (0,hp);
            //最大値を超えたら、最大値で上書きする
            if (_rt.sizeDelta.y > 240f) {
                _rt.sizeDelta = new Vector2 (51f, 240f);
            }
        }
    }
}