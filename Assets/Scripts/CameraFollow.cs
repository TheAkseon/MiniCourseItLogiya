using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _followSpeed;
    [SerializeField] private Vector3 _offset;

    private void Start()
    {
        Vector3 lookDirection = _player.transform.position - _offset;
        Quaternion targetRotation = Quaternion.LookRotation(lookDirection);
        transform.rotation = targetRotation;
    }

    private void LateUpdate()
    {
        Follow();
    }

    private void Follow()
    {
        if (_player != null)
        {
            Vector3 targetPosition = _player.transform.position + _offset;
            transform.position = Vector3.Lerp(transform.position, targetPosition, _followSpeed * Time.deltaTime);
        }
    }
}
