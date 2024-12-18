using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameCanvas : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _moneyCountText;
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private Button _restartButton;
    [SerializeField] private SceneChanger _sceneChanger;

    private void Start()
    {
        _restartButton.onClick.AddListener(_sceneChanger.ReloadScene);
        _gameOverPanel.SetActive(false);
    }

    public void UpdateMoneyCountText(int newMoneyCount)
    {
        _moneyCountText.text = newMoneyCount.ToString();
    }

    public void OpenGameOverPanel()
    {
        _gameOverPanel.SetActive(true);
    }
}
