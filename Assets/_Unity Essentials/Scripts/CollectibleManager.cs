using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    public static CollectibleManager Instance;

    public GameObject confettiPrefab;
    private int totalCollectibles;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject); // Singleton pattern
        }
    }

    void Start()
    {
        // Count all collectibles at the start
        totalCollectibles = FindObjectsOfType<Collectible>().Length;
    }

    public void OnCollectibleCollected(Vector3 position)
    {
        totalCollectibles--;

        if (totalCollectibles <= 0)
        {
            // Trigger celebration
            Instantiate(confettiPrefab, position, Quaternion.identity);
            Debug.Log("?? All collectibles collected! Confetti triggered.");
        }
    }
}
