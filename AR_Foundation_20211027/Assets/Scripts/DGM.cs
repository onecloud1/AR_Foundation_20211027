using UnityEngine;
using UnityEngine.XR.ARFoundation; //�ޥΪ� AR API
using UnityEngine.XR.ARSubsystems; //�ޥΪ� AR API
using System.Collections.Generic; //�ޥΪ� ���X API �]�t�M�� List

public class DGM : MonoBehaviour
{
    [Header("�I����ͦ�������")]
    public GameObject goSpawn;
    [Header("AR�g�u�޲z��"),Tooltip("���޲z���n��b��v�� Origin ����W")]
    public ARRaycastManager arRayManager;

    private Transform traSpawn;
    //�M����� = �s�W ���� �M�檫��
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    public bool inputMouseLeft { get => Input.GetKeyDown(KeyCode.Mouse0); }

    private void Update()
    {
        ClickAndDetechGround();
    }
    /// <summary>
    /// �I���P�˴��a�O
    /// 1.�����O�_����
    /// 2.�N�I���y�Ь���
    /// 3.�g�u�˴�
    /// 4.����
    /// </summary>
    private void ClickAndDetechGround()
    {
        if (inputMouseLeft)
        {
            Vector2 positionMouse = Input.mousePosition;

            print("�I���y��" + positionMouse);
        }
    }
}
