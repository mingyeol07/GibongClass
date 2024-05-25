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

    [SerializeField] private int stageIndex;

    private void Awake()
    {
        //stageIndex = UserInfo.Instance.StageID; // UserInfo���� stageId�� �޾ƿ�
    }

    private void Start()
    {
        GameManager.instance.SetBackGround(stageDatas[stageIndex].CylinderMaterial, stageDatas[stageIndex].CylinderInsideMaterial,
            stageDatas[stageIndex].backGround);

        PoolManager.Instance.Initialization(GetPoolObjects());
        
        spawnManager.SetStage(stageDatas[stageIndex]);
    }

    private List<PoolObjectData> GetPoolObjects()
    {
        List<PoolObjectData> stageObstacles = new List<PoolObjectData>() ; 

        for (int i = 0; i < stageDatas[stageIndex].obstacles.Length; i++)
        {
            stageObstacles.Add(stageDatas[stageIndex].obstacles[i]);
        }

        return stageObstacles;
    }
}