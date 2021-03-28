using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public GameObject audioSource;
    bool soundToggle = true;
    // Start is called before the first frame update

   public void OnGUI()
    {
        soundToggle = !soundToggle;
        if (soundToggle)
        {
            audioSource.SetActive(true);
            //audioSource.mute = true;
            //audioSource.volume = 1.0f;
        }
        else
        {
            audioSource.SetActive(false);
            //audioSource.mute = false;
            //audioSource.volume = 0.0f;
        }
    }
}
