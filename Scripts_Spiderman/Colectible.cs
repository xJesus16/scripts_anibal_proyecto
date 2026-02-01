using UnityEngine;

public class Colectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Collector collector = other.GetComponent<Collector>();

            if (collector != null)
            {
                collector.RecolectarObjeto();
                Destroy(gameObject);
            }
            else
            {
                Debug.LogError("❌ El Player no tiene Collector");
            }
        }
    }
}
