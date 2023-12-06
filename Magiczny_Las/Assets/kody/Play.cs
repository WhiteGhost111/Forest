using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public string Info;

    public void OnButtonClicked()
    {
        // Funkcja wywo³ywana po klikniêciu guzika
        SceneManager.LoadScene(Info);
    }
}
