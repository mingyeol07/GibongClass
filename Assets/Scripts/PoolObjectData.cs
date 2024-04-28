using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObstacleKeyType { Nomal, Move, Split, Fast, Slow, Transparent }

public class PoolObjectData
{
    public const int INITIAL_COUNT = 10; // �ʱ� ���� ũ��
    public const int MAX_COUNT = 50; // �ִ� ���� ũ��

    public ObstacleKeyType KeyType = ObstacleKeyType.Nomal;
    public GameObject prefab;

    public int initialCount = INITIAL_COUNT;
    public int maxCount = MAX_COUNT;
}
