namespace Title
{
    using DG.Tweening;
    using UnityEngine;

    public class MainStartLever : MonoBehaviour
    {
        [SerializeField] private Transform lever_rotation;

        private Vector2 startFingerPos;
        private float fingerDistance;
        private bool isFingerDown;

        private const float maxFingerDistance = 500;
        private const float returnRotationX = -266;

        private void OnMouseDown()
        {
            isFingerDown = true;
            startFingerPos = Input.mousePosition;
        }

        private void OnMouseDrag()
        {
            if (isFingerDown)
            {
                if (fingerDistance >= maxFingerDistance)
                {
                    isFingerDown = false;
                    TitleManager.Instance.OnGameStartLeverUp();
                }
                else
                {
                    // Ŭ���� ������ �̵��� ������ �Ÿ� / �ִ�Ÿ��� �� startLever�� rotation.x�� ����
                    fingerDistance = Mathf.Clamp(Mathf.Abs(startFingerPos.y - Input.mousePosition.y), 0, maxFingerDistance);
                    lever_rotation.localRotation = Quaternion.Euler(((fingerDistance / maxFingerDistance) * 180) + returnRotationX, 0, 0);
                }
            }
        }

        private void OnMouseUp()
        {
            isFingerDown = false;
            fingerDistance = 0;
            lever_rotation.transform.DOLocalRotate(new Vector3(returnRotationX, 0, 0), 0.5f);
        }
    }
}