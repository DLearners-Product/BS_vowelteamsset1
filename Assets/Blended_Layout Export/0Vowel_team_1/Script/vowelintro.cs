using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vowelintro : MonoBehaviour
{

    public GameObject[] GA_Images;
    public GameObject G_mainmenu;

    // Start is called before the first frame update
    void Start()
    {
        G_mainmenu.SetActive(true);
        for (int i = 0; i < GA_Images.Length; i++)
        {
            GA_Images[i].SetActive(false);
        }
    }

    public void BUT_ShowExample(int index)
    {
        G_mainmenu.SetActive(false);
        for (int i=0;i<GA_Images.Length;i++)
        {
            GA_Images[i].SetActive(false);
        }
        GA_Images[index].SetActive(true);
    }
    
    public void BUT_Back()
    {
        for (int i = 0; i < GA_Images.Length; i++)
        {
            GA_Images[i].SetActive(false);
        }
        G_mainmenu.SetActive(true);
    }
}
