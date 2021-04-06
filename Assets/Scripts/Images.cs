using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Images : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    private SoundEffectManager sound;
    private AnswerManager a;
    private TaskManager t;
    private Questions q;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        t = GameObject.FindGameObjectWithTag("Task Manager").GetComponent<TaskManager>();
        a = GameObject.FindGameObjectWithTag("Answer Manager").GetComponent<AnswerManager>();
        sound = GameObject.FindGameObjectWithTag("Sound Effect Manager").GetComponent<SoundEffectManager>();
        q = GetComponentInParent<Questions>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseOver()
    {   // Vaihtaa kuvan v‰rin harmaaksi kun hiiri on sen p‰‰ll‰
        spriteRenderer.color = Color.gray;
    }
    private void OnMouseExit()
    {   // Vaihtaa v‰rin takaisin valkoiseksi kun hiiri on pois p‰‰lt‰
        spriteRenderer.color = Color.white;
    }

    void OnMouseDown()
    {   
        if(t.popUpIndex == 0)
        {   // Kun popUpIndex on 0, ja GameObjectin tagi on "Lisa Eats", sound effecti ja lisaEats muuttuu trueksi
            if(gameObject.CompareTag("Lisa Eats"))
            {
                sound.nougatYouAre.Play();
                Debug.Log("Correct");
                q.lisaEats = true;
            }
            else
            {
                // Jos if lause ei tule toteen "v‰‰rin" sound effect ja "Try again" UI ilmestyy 
                sound.elephant.Play();
                a.wrongAnswer.SetActive(true);
                Debug.Log("Wrong");
            }
        }

        if (t.popUpIndex == 1)
        {
            if (a.lisaEaten == true)
            {
                if (gameObject.CompareTag("Lisa Camel"))
                {
                    sound.boombayah.Play();
                    Debug.Log("Correct");
                    q.lisaCamel = true;
                }
                else
                {
                    a.wrongAnswer.SetActive(true);
                    Debug.Log("Wrong");
                }
            }                        
        }

        if (t.popUpIndex == 2)
        {
            if (a.lisaBeenCamel == true)
            {
                if (gameObject.CompareTag("Lisa Cat"))
                {
                    sound.boombayah.Play();
                    Debug.Log("Correct");
                    q.lisaCat = true;
                }
                else
                {
                    a.wrongAnswer.SetActive(true);
                    Debug.Log("Wrong");
                }
            }
        }

        if (t.popUpIndex == 3)
        {
            if (a.lisaCatShown == true)
            {
                if (gameObject.CompareTag("Lisa Sings"))
                {
                    sound.nougatYouAre.Play();
                    Debug.Log("Correct");
                    q.lisaSings = true;
                }
                else
                {
                    a.wrongAnswer.SetActive(true);
                    Debug.Log("Wrong");
                }
            }
        }
    }
}
