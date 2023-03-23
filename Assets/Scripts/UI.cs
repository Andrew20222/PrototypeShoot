using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;
    public void Play()
    {
        _sound.Play();
        SceneManager.LoadScene(1);
    }
}
