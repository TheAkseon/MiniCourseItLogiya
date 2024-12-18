using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        transform.Rotate(new Vector3(0, _rotationSpeed * Time.deltaTime, 0));
    }
}
