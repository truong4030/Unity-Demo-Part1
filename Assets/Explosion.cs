using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float lifeTime = 0.3f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}
