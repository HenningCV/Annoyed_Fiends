using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuUI : MonoBehaviour {

    [Header("Level-Select Scene Name")]
    public string levelName = "LevelSelect";

    [Header("UI Elements")]
    public GameObject settingsUI;


    public void StartGame() {
        SceneManager.LoadScene(levelName);
    }

    public void QuitGame() {
        Debug.Log("Quit Game");
        Application.Quit();
    }


    public void ShowSettingsUI() {
        settingsUI.SetActive(true);
    }

    public void HideSettingsUI() {
        settingsUI.SetActive(false);
    }
}
