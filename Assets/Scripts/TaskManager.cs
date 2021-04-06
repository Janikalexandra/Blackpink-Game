using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    //private EnvironmentDialogManager envDialog;
    private Questions q;

    public GameObject lisaEats;

    public GameObject NarratorStart;
    public GameObject chapterIView;

    public GameObject[] popUps;

    public int popUpIndex;

    

    void Start()
    {
        //envDialog = GetComponent<EnvironmentDialogManager>();
        //lisaEatsQuestion = GameObject.FindWithTag("Lisa Eats");  
        q = GameObject.FindGameObjectWithTag("Lisa Questions").GetComponent<Questions>();
    }

    void Update()
    {
        for (int i = 0; i < popUps.Length; i++)
        {
            if (i == popUpIndex)
            {
                popUps[i].SetActive(true);
            }
            else
            {
                popUps[i].SetActive(false);
            }
        }     

        // Tutorial has just started
        // Checks popUpIndex and does what the if statement says
        if(popUpIndex == 0)
        {
            if (q.lisaEats == true)
            {              
                popUpIndex++;
                Debug.Log(popUpIndex);
            }
        } 
        else if(popUpIndex == 1){
            if (q.lisaCamel == true)
            {
                popUpIndex++;
            }
        }
        else if(popUpIndex == 2)
        {
            if (q.lisaCat == true)
            {
                popUpIndex++;
            }
        }
        else if (popUpIndex == 3)
        {
            if (q.lisaSings == true)
            {
                popUpIndex++;
            }
            
        }      
    }    
}
