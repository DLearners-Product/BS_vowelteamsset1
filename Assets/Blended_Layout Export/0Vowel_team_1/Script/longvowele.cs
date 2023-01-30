using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class longvowele : MonoBehaviour
{
    public GameObject[] GA_Questions;
    public int I_Qcount;
    public GameObject G_Final;

    public AudioSource AS_crt, AS_wrg, AS_Empty;
    public AudioClip[] AC_Clips;
    // Start is called before the first frame update
    void Start()
    {
        G_Final.SetActive(false);
        I_Qcount = 0;
        THI_ShowQuestion();
    }

    public void THI_ShowQuestion()
    {
        for (int i = 0; i < GA_Questions.Length; i++)
        {
            GA_Questions[i].SetActive(false);
        }
        GA_Questions[I_Qcount].SetActive(true);
        GA_Questions[I_Qcount].transform.GetChild(2).GetComponent<Animator>().Play("monkeydown");
        GA_Questions[I_Qcount].transform.GetChild(1).gameObject.SetActive(false);
        GA_Questions[I_Qcount].transform.GetChild(3).GetComponent<ClickAudio>().clip = null;
    }
    
    public void BUT_clicking()
    {
        GameObject dummy;
        dummy = EventSystem.current.currentSelectedGameObject;
        if(dummy.tag=="answer")
        {
           // AS_crt.Play();
            GA_Questions[I_Qcount].transform.GetChild(2).GetComponent<Animator>().Play("monkeyup");
            GA_Questions[I_Qcount].transform.GetChild(1).gameObject.SetActive(true);
            GA_Questions[I_Qcount].transform.GetChild(3).GetComponent<ClickAudio>().clip = AC_Clips[I_Qcount];
            AS_Empty.clip = AC_Clips[I_Qcount];
            AS_Empty.Play();
        }
        else
        {
            AS_wrg.Play();
        }
    }
    public void BUT_Next()
    {
        if(I_Qcount<GA_Questions.Length-1)
        {
            I_Qcount++;
            THI_ShowQuestion();
        }
        else
        {
            G_Final.SetActive(true);
        }
    }
}
