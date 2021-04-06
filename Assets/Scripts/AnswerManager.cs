using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerManager : MonoBehaviour
{
    private TaskManager t;

    public GameObject[] ApopUps;

    public GameObject lisaEating;
    public GameObject lisaCamel;
    public GameObject lisaCats;
    public GameObject lisaSinging;
    public GameObject wrongAnswer;

    public GameObject lisaQuestionEnds;

    private Questions q;

    public bool lisaEaten = false;
    public bool lisaBeenCamel = false;
    public bool lisaCatShown = false;
    public bool lisaSong = false;


    // Start is called before the first frame update
    void Start()
    {
        q = GameObject.FindGameObjectWithTag("Lisa Questions").GetComponent<Questions>();
        t = GameObject.FindGameObjectWithTag("Task Manager").GetComponent<TaskManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (q.lisaEats == true && lisaEaten == false)
        {
            lisaEating.SetActive(true);         
        }
        else if (q.lisaCamel == true && lisaBeenCamel == false)
        {
            lisaCamel.SetActive(true);          
        }
        else if (q.lisaCat == true && lisaCatShown == false)
        {
            lisaCats.SetActive(true);
        }
        else if (q.lisaSings == true && lisaSong == false)
        {
            lisaSinging.SetActive(true);          
        }
    }
    
    public void LisaAte()
    {
        lisaEaten = true;
    }

    public void LisaCamel()
    {
        lisaBeenCamel = true;
    }
    public void LisaCate()
    {
        lisaCatShown = true;
    }
    public void LisaSang()
    {
        lisaSong = true;
    }


}
            
        

