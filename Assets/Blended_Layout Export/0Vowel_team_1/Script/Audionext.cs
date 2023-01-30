using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audionext : MonoBehaviour
{
    public GameObject[] GA_Objects;
    public AudioSource AS_Empty;
    public AudioClip[] AudioClips;
    public int I_Qcount;
    public GameObject G_Final;

    private void Start()
    {
        G_Final.SetActive(false);
        I_Qcount = 0;
        ShowObject();
    }
    public void ShowObject()
    {
        for(int i=0;i<GA_Objects.Length;i++)
        {
            GA_Objects[i].SetActive(false);
        }
        GA_Objects[I_Qcount].SetActive(true);
    }
    public void BUT_Speaker()
    {
        AS_Empty.clip = AudioClips[I_Qcount];
        AS_Empty.Play();
    }

    public void BUT_Next()
    {
        if(I_Qcount<AudioClips.Length-1)
        {
            I_Qcount++;
            ShowObject();
        }
        else
        {
            G_Final.SetActive(true);
        }
       
    }
    public void BUT_Back()
    {
        if (I_Qcount >1)
        {
            I_Qcount--;
            ShowObject();
        }
        else
        {
            G_Final.SetActive(true);
        }

    }
}
