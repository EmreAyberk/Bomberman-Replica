using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float countdown = 2f;
    private MapDestroyer _mapDestroyer;

    private void Start()
    {
        _mapDestroyer = FindObjectOfType<MapDestroyer>();
    }

    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f)
        {
            _mapDestroyer.Explode(transform.position);
            Destroy(gameObject);
        }
    }
}
