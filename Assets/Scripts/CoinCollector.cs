using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private GameCanvas _gameCanvas;

    private int _countMoney;

    private void Start()
    {
        _countMoney = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Coin coin))
        {
            Destroy(coin.gameObject);
            UpdateCountMoney();
        }
    }

    private void UpdateCountMoney()
    {
        _countMoney++;

        _gameCanvas.UpdateMoneyCountText(_countMoney);
    }
}
