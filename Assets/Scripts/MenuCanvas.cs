using UnityEngine;
using UnityEngine.UI;

public class MenuCanvas : MonoBehaviour
{
    [SerializeField] private Button _playButton;
    [SerializeField] private PlayerMover _playerMover;

    private void Start()
    {
        _playButton.onClick.AddListener(StartGame);
    }

    private void StartGame()
    {
        _playerMover.ChangeMoveForward(true);
        gameObject.SetActive(false);
    }
}
