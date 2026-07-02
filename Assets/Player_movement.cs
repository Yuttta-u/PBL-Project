using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public float forwardSpeed = 5f;   // 上に進むスピード
    public float laneDistance = 2f;   // 左右への移動幅
    public float shiftSpeed = 10f;    // 横移動の滑らかさ

    private int currentLane = 0;      // -1: 左レーン, 1: 右レーン

    void Update()
    {
        // 自動で「上（Y軸のプラス方向）」に進み続ける
        transform.Translate(Vector3.up * forwardSpeed * Time.deltaTime);

        // 左右キーの入力チェック
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            currentLane = -1; // 左へ
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            currentLane = 1;  // 右へ
        }

        // 横移動の処理（Y軸はそのまま、X軸だけを動かす）
        float targetX = currentLane * laneDistance;
        Vector3 targetPosition = new Vector3(targetX, transform.position.y, transform.position.z);

        // スムーズに横にスライドさせる
        transform.position = Vector3.Lerp(transform.position, targetPosition, shiftSpeed * Time.deltaTime);
    }
}