using UnityEngine;

public class PortalToNextLevel : MonoBehaviour
{
    [SerializeField] private SceneChanger _sceneChanger;
    [SerializeField] private string _sceneName;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out Player player))
        {
            _sceneChanger.LoadScene(_sceneName);
        }
    }
}
