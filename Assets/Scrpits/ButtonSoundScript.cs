using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonSoundScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public AudioClip hoverSound;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource.clip = hoverSound;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        audioSource.Play();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        audioSource.Stop();
    }
}
