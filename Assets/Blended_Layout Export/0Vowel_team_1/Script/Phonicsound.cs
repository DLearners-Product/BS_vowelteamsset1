using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Phonicsound : MonoBehaviour
{
    public GameObject[] GA_Questions;
    public GameObject G_Speaker,G_Final,G_Selected;
    public int I_Qcount;

    public AudioSource AS_Empty,AS_wrg;
    public AudioClip[] AC_Clips;
    void Start()
    {
        G_Speaker.transform.GetChild(0).gameObject.SetActive(false);
        G_Final.SetActive(false);
        I_Qcount = 0;
        THI_ShowQuestion();
    }

    public void THI_ShowQuestion()
    {
        for(int i=0;i<GA_Questions.Length;i++)
        {
            GA_Questions[i].SetActive(false);
        }
        GA_Questions[I_Qcount].SetActive(true);
        GA_Questions[I_Qcount].transform.GetChild(3).gameObject.SetActive(false);
    }
    
    public void BUT_Next()
    {
        AS_Empty.Stop();
        if (I_Qcount<GA_Questions.Length-1)
        {
            I_Qcount++;
            THI_ShowQuestion();
        }
        else
        {
            G_Final.SetActive(true);
        }    
    }

    public void BUT_Speaker()
    {
        G_Speaker.transform.GetChild(0).gameObject.SetActive(true);
        Invoke("THI_Offeffect", 1f);
        AS_Empty.clip = AC_Clips[I_Qcount];
        AS_Empty.Play();
    }

    public void THI_Offeffect()
    {
        G_Speaker.transform.GetChild(0).gameObject.SetActive(false);
    }
    public void BUT_Clicking()
    {
        AS_Empty.Stop();
        G_Selected = EventSystem.current.currentSelectedGameObject;
        if(G_Selected.tag=="answer")
        {
            GA_Questions[I_Qcount].transform.GetChild(3).gameObject.SetActive(true);
            /*G_Selected.transform.GetChild(3).gameObject.SetActive(false);
            G_Selected.transform.GetChild(1).gameObject.GetComponent<Animator>().enabled = true;*/
        }
        else
        {
            AS_wrg.Play();
        }
    }

    
}
