using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testtttt : MonoBehaviour
{
    public float rotationSpeed = 50.0f; // ȸ�� �ӵ�
    public float radius = 5.0f; // ���� ������

    private float angle = 0f; // ���� ����
    [SerializeField] private Transform position;

    void Update()
    {
        // �ð��� ���� ������ ������ŵ�ϴ�.
        angle += rotationSpeed * Time.deltaTime;

        // ������ �������� ��ȯ�մϴ�.
        float radian = angle * Mathf.Deg2Rad;

        // �� ��ġ�� ����մϴ�. z ��ġ�� �������� �ʽ��ϴ�.
        Vector3 newPosition = new Vector3(Mathf.Cos(radian) * radius, Mathf.Sin(radian) * radius, 0);

        // ��ü�� �� ��ġ�� �̵���ŵ�ϴ�.
        transform.position = position.position + newPosition;
    }
}
