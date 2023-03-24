using UnityEngine;
using UnityEngine.SceneManagement;

public class UIService : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;
    public void Play()
    {
        _sound.Play();
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        _sound.Play();
        Application.Quit();
    }
}
