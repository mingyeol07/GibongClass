using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.PlayerLoop;
// UserInfo�� stage�ε����� ������ �������������� �����ϴ� Ŭ����
public class StageManager : MonoBehaviour
{
    [SerializeField] private List<StageData> stageDatas = new List<StageData>(); // StageData
    [SerializeField] private SpawnManager spawnManager;
    private int stageIndex;

    private void Awake()
    {
        stageIndex = UserInfo.Instance.StageID; // UserInfo���� stageId�� �޾ƿ�
    }

    private void Start()
    {
        PoolManager.Instance.Initialization(GetPoolObjects());
        GameManager.instance.backGround.material = GetBackGroundMaterial();
        spawnManager.SetStage(stageDatas[stageIndex]);
    }

    private List<PoolObjectData> GetPoolObjects()
    {
        List<PoolObjectData> stageObstacles = new List<PoolObjectData>() ; 

        for (int i = 0; i < stageDatas[stageIndex].obstacles.Length; i++)
        {
            stageObstacles.Add(stageObstacles[i]);
        }

        return stageObstacles;
    }

    private Material GetBackGroundMaterial()
    {
        return stageDatas[stageIndex].backGround;
    }
}