using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public string Info;

    public void OnButtonClicked()
    {
        // Funkcja wywo�ywana po klikni�ciu guzika
        SceneManager.LoadScene(Info);
    }
}
