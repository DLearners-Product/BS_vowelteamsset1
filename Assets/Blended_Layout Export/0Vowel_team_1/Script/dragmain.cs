using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class dragmain : MonoBehaviour
{
    public static dragmain OBJ_dragmain;
    public GameObject[] GA_Questions;
    public int I_Qcount, I_Anscount;

    public GameObject  G_final;
    public AudioSource AS_crt, AS_wrg;
    public AudioClip[] AC_Clips;

   
    public void Start()
    {
        OBJ_dragmain = this;
        I_Qcount = -1;
        G_final.SetActive(false);
        
        showquestion();
    }
    public void showquestion()
    {
        
        if (I_Qcount<GA_Questions.Length-1)
        {
            I_Qcount++;
            for (int i = 0; i < GA_Questions.Length; i++)
            {
                GA_Questions[i].SetActive(false);
            }
            GA_Questions[I_Qcount].SetActive(true);
            GA_Questions[I_Qcount].transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).gameObject.SetActive(false);
            GA_Questions[I_Qcount].transform.GetChild(0).transform.GetChild(2).GetComponent<ClickAudio>().clip = null;
            if (I_Qcount == 2 || I_Qcount == 8)
            {
                GA_Questions[I_Qcount].transform.GetChild(0).transform.GetChild(3).gameObject.SetActive(false);
            }
        }
        else
        {
            G_final.SetActive(true);
        }
        
    }

    public void BUT_next()
    {
        showquestion();
    }
    public void THI_correct()
    {
        GA_Questions[I_Qcount].transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).gameObject.SetActive(true);
        GA_Questions[I_Qcount].transform.GetChild(0).transform.GetChild(2).GetComponent<ClickAudio>().clip = AC_Clips[I_Qcount];
        AS_crt.Play();
        if(I_Qcount==2||I_Qcount==8)
        {
            GA_Questions[I_Qcount].transform.GetChild(0).transform.GetChild(3).gameObject.SetActive(true);
        }
    }
    public void THI_wrg()
    {
        AS_wrg.Play();
    }
    
   
   

    
}
