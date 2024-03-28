using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    public float initialSpeed = 10f; // �ʱ� ���ּ� �ӵ�
    public float launchAngle = 45f; // �߻� ����
    private Vector3 velocity; // ���ּ��� �ӵ� ����

    void Start()
    {
        // �ʱ� �ӵ��� �߻� ������ ���� ����
        float launchAngleRad = launchAngle * Mathf.Deg2Rad;
        float vx = initialSpeed * Mathf.Cos(launchAngleRad);
        float vy = initialSpeed * Mathf.Sin(launchAngleRad);
        velocity = new Vector3(vx, vy, 0f);
    }

    void Update()
    {
        // � ����
        transform.position += velocity * Time.deltaTime;

        // ���ּ��� ���� ������ ������ �������� ����
        transform.forward = velocity.normalized;

        // �߷¿� ���� �ӵ� ��ȭ ���� (�߷��� ������� ����)
    }
}

