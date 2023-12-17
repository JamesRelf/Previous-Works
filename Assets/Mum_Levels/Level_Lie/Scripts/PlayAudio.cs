using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    [SerializeField] AudioManager am;
    
    
    public void PlaySFX()
    {
        am.AudioRope();
    }
}
