using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;

    private float targetX;

    void Start()
    {
        targetX = transform.position.x;
    }

    void Update()
    {
        // 左クリック
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            // マウス座標取得
            Vector2 mousePos = Mouse.current.position.ReadValue();

            // ワールド座標へ変換
            Vector3 worldPos =
                Camera.main.ScreenToWorldPoint(mousePos);

            // X座標だけ保存
            targetX = worldPos.x;
        }

        // 現在位置
        Vector3 currentPos = transform.position;

        // 横だけ移動
        currentPos.x = Mathf.MoveTowards(
            currentPos.x,
            targetX,
            moveSpeed * Time.deltaTime
        );

        // 位置更新
        transform.position = currentPos;
    }
}