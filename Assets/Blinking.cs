using UnityEngine;

public class Blinking : MonoBehaviour
{
    public GameObject flame;

    void Start()
    {
        InvokeRepeating("Blink", 0.1f, 0.1f);
    }

    void Blink()
    {
        flame.SetActive(!flame.activeSelf);
    }
}
