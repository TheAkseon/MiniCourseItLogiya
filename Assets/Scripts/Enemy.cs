using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            Destroy(enemy.gameObject);
        }
    }
}
