using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Collector : MonoBehaviour
{
    [Header("Configuración")]
    [SerializeField] private int objetosNecesarios = 5;

    private GameObject puertaOculta;
    private int objetosRecolectados;

    private void Start()
    {
        objetosRecolectados = 0;

        puertaOculta = GameObject.FindGameObjectWithTag("Oculto");

        if (puertaOculta != null)
        {
            puertaOculta.SetActive(false);
            Debug.Log("🔒 Puerta OCULTA al iniciar");
        }
        else
        {
            Debug.LogError("❌ No se encontró objeto con tag Oculto");
        }

                
    }

    public void RecolectarObjeto()
    {
        objetosRecolectados++;

        Debug.Log($"Monedas: {objetosRecolectados}/{objetosNecesarios}");

        if (objetosRecolectados >= objetosNecesarios)
        {
            if (puertaOculta != null && !puertaOculta.activeSelf)
            {
                puertaOculta.SetActive(true);
                Debug.Log("🚪 PUERTA ACTIVADA");
            }
        }
    }
}
