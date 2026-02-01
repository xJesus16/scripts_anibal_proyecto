using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject[] playerPrefabs; // Tamaño 2 
    public Transform spawnPoint;

    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("SelectedCharacter", 0);
        Instantiate(playerPrefabs[selectedCharacter], spawnPoint.position, spawnPoint.rotation);
    }
}


 
