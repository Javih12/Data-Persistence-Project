using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Name : MonoBehaviour
{
    public TMP_InputField inputName;
    public TMP_Text nombre;
    public GameObject startButton;

   public void aceptar()
    {
        PlayerPrefs.SetString("NamePlayer", inputName.text);
        SceneManager.LoadScene(1);
    }
}
