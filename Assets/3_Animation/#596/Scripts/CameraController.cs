using UnityEngine;

namespace _3_Animation.Scripts
{
    public class CameraController : MonoBehaviour
    {

        [SerializeField] private GameObject _player;

        private void FixedUpdate()
        {
            if (_player.transform.position.x > transform.position.x - 4)
            {
//カメラの位置を取得
                Vector3 cameraPos = transform.position;
//ユニティちゃんの位置から右に4移動した位置を画面中央にする
                cameraPos.x = _player.transform.position.x + 4;
                transform.position = cameraPos;
            }
//カメラ表示領域の左下をワールド座標に変換
            Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
//カメラ表示領域の右上をワールド座標に変換
            Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
//ユニティちゃんのポジションを取得

        }
    }
}
