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
    }
}