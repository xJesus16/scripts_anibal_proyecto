using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscenaPuerta : MonoBehaviour
{
    [SerializeField] private string nombreEscena;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(nombreEscena);
        }
    }
}
