using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelector : MonoBehaviour
{
    // 0 = Player A | 1 = Player B
    public void SelectCharacter(int characterID)
    {
        Debug.Log("Click en selector de personaje. ID seleccionado: " + characterID);

        PlayerPrefs.SetInt("SelectedCharacter", characterID);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Playground"); // escena de juego
    }
}
