using UnityEngine;
using UnityEngine.XR.ARFoundation; //引用的 AR API
using UnityEngine.XR.ARSubsystems; //引用的 AR API
using System.Collections.Generic; //引用的 集合 API 包含清單 List

public class DGM : MonoBehaviour
{
    [Header("點擊後生成的物件")]
    public GameObject goSpawn;
    [Header("AR射線管理器"),Tooltip("此管理器要放在攝影機 Origin 物件上")]
    public ARRaycastManager arRayManager;

    private Transform traSpawn;
    //清單欄位 = 新增 實體 清單物件
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    public bool inputMouseLeft { get => Input.GetKeyDown(KeyCode.Mouse0); }

    private void Update()
    {
        ClickAndDetechGround();
    }
    /// <summary>
    /// 點擊與檢測地板
    /// 1.偵測是否按鍵
    /// 2.將點擊座標紀錄
    /// 3.射線檢測
    /// 4.互動
    /// </summary>
    private void ClickAndDetechGround()
    {
        if (inputMouseLeft)
        {
            Vector2 positionMouse = Input.mousePosition;

            print("點擊座標" + positionMouse);
        }
    }
}
