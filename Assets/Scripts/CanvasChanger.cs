using UnityEngine;
using UnityEngine.UI;

public class CanvasChanger : MonoBehaviour
{
    [SerializeField] private Canvas _canvasOn;
    [SerializeField] private Canvas _canvasOff;

    [SerializeField] private Button _button;

    private void Start()
    {
        _button.onClick.AddListener(ChangeCanvas);
    }

    private void ChangeCanvas()
    {
        _canvasOff.gameObject.SetActive(false);
        _canvasOn.gameObject.SetActive(true);
    }
}
