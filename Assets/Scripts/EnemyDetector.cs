using UnityEngine;

public class EnemyDetector : MonoBehaviour
{
    [SerializeField] private PlayerMover _playerMover;
    [SerializeField] private GameCanvas _gameCanvas;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            Destroy(enemy.gameObject);
            _playerMover.ChangeMoveForward(false);
            _gameCanvas.OpenGameOverPanel();
        }
    }
}
