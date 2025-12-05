using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class LoginManager : MonoBehaviour
{
    public TMP_InputField emailField;
    public TMP_InputField passwordField;
    public TMP_Text errorMessage;
    public string correctEmail = "justin";
    public string correctPassword = "VR123";

    public void AttemptLogin()
    {
        if (passwordField.text == correctPassword && emailField.text == correctEmail)
        {
            SceneManager.LoadScene(2);
            errorMessage.gameObject.SetActive(false);
        }
        else
        {
            errorMessage.text = "Incorrect password.";
            errorMessage.gameObject.SetActive(true);
        }
    }
}
