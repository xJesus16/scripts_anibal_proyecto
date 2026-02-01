using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class Venom_Music : MonoBehaviour
{
    public AudioSource musica;
// Reproducir la música cuando el jugador entre en el área
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!musica.isPlaying)
            {
                musica.Play();
            }
        }
    }
    // Detener la música cuando el jugador salga del área
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            musica.Stop();
        }
    }
}
