using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _forwardSpeed;
    [SerializeField] private float _horizontalSpeed;
    [SerializeField] private float _horizontalLimit;
    [SerializeField] private PlayerAnimation _playerAnimation;

    private bool _isPlayerMoveForward = false;

    private void Start()
    {
        _playerAnimation.Idle(true);
    }

    private void Update()
    {
        if (_isPlayerMoveForward)
        {
            _playerAnimation.Idle(false);
            _playerAnimation.Run(true);
            MoveForward();
            HandleHorizontalMovement();
        }
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * _forwardSpeed * Time.deltaTime);
    }

    private void HandleHorizontalMovement()
    {
        if (Input.GetMouseButton(0))
        {
            float horizontalInput = Input.GetAxis("Mouse X");
            float newXPosition = transform.position.x + horizontalInput * _horizontalSpeed * Time.deltaTime;

            newXPosition = Mathf.Clamp(newXPosition, -_horizontalLimit, _horizontalLimit);

            transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);
        }
    }

    public void ChangeMoveForward(bool newValueMoveForward)
    {
        _isPlayerMoveForward = newValueMoveForward;
    }
}
