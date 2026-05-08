using UnityEngine;

public class PlayerDelivery : MonoBehaviour
{
    [Header("Color Settings")]
    [SerializeField] Color32 hasPackage = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackage = new Color32(1, 1, 1, 1);

    [Header("References")]
    [SerializeField] SpriteRenderer spriteRenderer;

    [Header("Package Settings")]
    [SerializeField] bool hasDeliveryPackage;
    [SerializeField] private float destroyDelay = 0.5f;

    private void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Delivery" && !hasDeliveryPackage)
        {
            hasDeliveryPackage = true;
            spriteRenderer.color = hasPackage;
            Destroy(collision.gameObject, destroyDelay);
        }

        if(collision.gameObject.tag == "Customer" && hasDeliveryPackage)
        {
            hasDeliveryPackage = false;
            spriteRenderer.color = noPackage;
        }
    }
}