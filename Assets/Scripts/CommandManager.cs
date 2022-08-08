using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CommandManager : MonoBehaviour
{
    GameObject[] animals;
    public GameObject[] dogs;
    GameObject[] cats;
    GameObject[] chis;
    GameObject[] huskies;
    public GameObject animalSet;
    public GameObject commandSet;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BuildArrays());
        
    }

    private IEnumerator BuildArrays()
    {
        //wait for spawn
        yield return StartCoroutine(Wait());
        //Debug.Log("Done with coroutine, getting animals for arrays");
        //animals = FindObjectsOfType(typeof(Animal)) as GameObject[];
        
        dogs = getDogs();
        //Debug.Log("Done with dogs");
        //Debug.Log(dogs.Length);
        cats = getCats();
        //Debug.Log("Done with cats");
        //Debug.Log(cats.Length);
        chis = getChis();
        //Debug.Log("Done with chis");
        //Debug.Log(chis.Length);
        huskies = getHuskies();
        //Debug.Log("Done with huskies");
        //Debug.Log(huskies.Length);
        
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RunCommand()
    {
        string animalCheck=animalSet.GetComponent<TMPro.TextMeshProUGUI>().text;
        string commandCheck=commandSet.GetComponent<TMPro.TextMeshProUGUI>().text;
        switch (animalCheck)
        {
            case "Cat":
                switch (commandCheck)
                {
                    case "Vocalize":
                        VocalizeCat();
                        break;
                    case "Walk":
                        WalkCat();
                        break;
                    case "Run":
                        RunCat();
                        break;
                    case "Jump":
                        JumpCat();
                        break;
                    default:
                        break;
                }
                break;
            case "Dog":
                switch (commandCheck)
                {
                    case "Vocalize":
                        VocalizeDog();
                        break;
                    case "Walk":
                        WalkDog();
                        break;
                    case "Run":
                        RunDog();
                        break;
                    case "Jump":
                        JumpDog();
                        break;
                    default:
                        break;
                }
                break;
            case "Chi":
                switch (commandCheck)
                {
                    case "Vocalize":
                        VocalizeChi();
                        break;
                    case "Walk":
                        WalkChi();
                        break;
                    case "Run":
                        RunChi();
                        break;
                    case "Jump":
                        JumpChi();
                        break;
                    default:
                        break;
                }
                break;
            case "Husky":
                switch (commandCheck)
                {
                    case "Vocalize":
                        VocalizeHusky();
                        break;
                    case "Walk":
                        WalkHusky();
                        break;
                    case "Run":
                        RunHusky();
                        break;
                    case "Jump":
                        JumpHusky();
                        break;
                    default:
                        break;
                }
                break;
            default:
                break;
        }
    }

    #region JumpCalls
    public void JumpCat()
    {
        foreach (GameObject cat in cats)
        {
            cat.GetComponent<Cat>().Jump();
        }
    }
    public void JumpDog()
    {
        foreach (GameObject dog in dogs)
        {
            dog.GetComponent<Dog>().Jump();
        }
    }
    public void JumpChi()
    {
        foreach (GameObject chi in chis)
        {
            chi.GetComponent<Chi>().Jump();
        }
    }
    public void JumpHusky()
    {
        foreach (GameObject husky in huskies)
        {
            husky.GetComponent<Husky>().Jump();
        }
    }

    #endregion
    #region RunCalls
    public void RunCat()
    {
        foreach (GameObject cat in cats)
        {
            cat.GetComponent<Cat>().Run();
        }
    }
    public void RunDog()
    {
        foreach (GameObject dog in dogs)
        {
            dog.GetComponent<Dog>().Run();
        }
    }
    public void RunChi()
    {
        foreach (GameObject chi in chis)
        {
            chi.GetComponent<Chi>().Run();
        }
    }
    public void RunHusky()
    {
        foreach (GameObject husky in huskies)
        {
            husky.GetComponent<Husky>().Run();
        }
    }

    #endregion
    #region WalkCalls
    public void WalkCat()
    {
        foreach (GameObject cat in cats)
        {
            cat.GetComponent<Cat>().Walk();
        }
    }
    public void WalkDog()
    {
        foreach (GameObject dog in dogs)
        {
            dog.GetComponent<Dog>().Walk();
        }
    }
    public void WalkChi()
    {
        foreach (GameObject chi in chis)
        {
            chi.GetComponent<Chi>().Walk();
        }
    }
    public void WalkHusky()
    {
        foreach (GameObject husky in huskies)
        {
            husky.GetComponent<Husky>().Walk();
        }
    }

    #endregion
    #region Vocalize Calls
    public void VocalizeCat()
    {
        foreach (GameObject cat in cats)
        {
            cat.GetComponent<Cat>().Vocalize();
        }
    }
    public void VocalizeDog()
    {
        foreach (GameObject dog in dogs)
        {
            dog.GetComponent<Dog>().Vocalize();
        }
    }
    public void VocalizeChi()
    {
        foreach (GameObject chi in chis)
        {
            chi.GetComponent<Chi>().Vocalize();
        }
    }
    public void VocalizeHusky()
    {
        foreach (GameObject husky in huskies)
        {
            husky.GetComponent<Husky>().Vocalize();
        }
    }
    #endregion

    #region GetAnimalArrays
    public GameObject[] getDogs() 
    {
            Dog[] dogs = FindObjectsOfType<Dog> ();
            GameObject[] objects = new GameObject[dogs.Length];        
            for (int i = 0; i < objects.Length; i++)
            objects [i] = dogs [i].gameObject;
            return objects;
    }
    public GameObject[] getCats() 
    {
            Cat[] cats = FindObjectsOfType<Cat> ();
            GameObject[] objects = new GameObject[cats.Length];        
            for (int i = 0; i < objects.Length; i++)
            objects [i] = cats [i].gameObject;
            return objects;
    }
    public GameObject[] getChis() 
    {
            Chi[] chis = FindObjectsOfType<Chi> ();
            GameObject[] objects = new GameObject[chis.Length];        
            for (int i = 0; i < objects.Length; i++)
            objects [i] = chis [i].gameObject;
            return objects;
    }
    public GameObject[] getHuskies() 
    {
            Husky[] huskies = FindObjectsOfType<Husky> ();
            GameObject[] objects = new GameObject[huskies.Length];        
            for (int i = 0; i < objects.Length; i++)
            objects [i] = huskies [i].gameObject;
            return objects;
    }
    #endregion
}
