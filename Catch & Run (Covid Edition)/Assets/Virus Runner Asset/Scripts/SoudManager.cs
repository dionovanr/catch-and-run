using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoudManager : MonoBehaviour
{
    public static AudioClip skorSound, jumpSound, zonkSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        skorSound = Resources.Load<AudioClip>("collect");
        jumpSound = Resources.Load<AudioClip>("jump");
        zonkSound = Resources.Load<AudioClip>("zonk");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "collect" :
                audioSrc.PlayOneShot(skorSound);
                break;
            case "jump" :
                audioSrc.PlayOneShot(jumpSound);
                break;
            case "zonk" :
                audioSrc.PlayOneShot(zonkSound);
                break;

        }
    }
}
