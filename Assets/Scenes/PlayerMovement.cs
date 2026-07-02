using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // 動くスピードを調整できる変数
    public float speed = 5.0f;

    void Update()
    {
        // 矢印キーやWASDキーの入力を受け取る
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // オブジェクトを移動させる
        transform.Translate(moveX * speed * Time.deltaTime, 0, moveZ * speed * Time.deltaTime);
    }
}