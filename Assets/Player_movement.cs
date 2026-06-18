using UnityEngine;

public class Player_movement : MonoBehaviour
{
    // プレイヤーの移動スピード（インスペクターから調整可能）
    public float moveSpeed = 5f;

    void Update()
    {
        // キーボードの左右（A/Dキー、または矢印キー）の入力を受け取る（-1から1の値）
        float moveInput = Input.GetAxisRaw("Horizontal");

        // 入力された方向に移動させる
        transform.Translate(new Vector3(moveInput * moveSpeed * Time.deltaTime, 0, 0));
    }
}