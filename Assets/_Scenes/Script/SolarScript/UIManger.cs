using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManger : MonoBehaviour
{
    public GameObject merycuryPnl, venusPnl, earthpnl, marspnl, jupiterPnl, saturnpnl, uranusPnl, neptunepnl;
    // public GameObject merycuryPrefab, venusPrefab, earthPrefab, marsPrefab, jupiterPrefab, saturnPrefab, uranusPrefab, neptunePrefab;
    //public Transform S_mer, S_ven, S_earth, S_mars, S_jup, S_saturn, S_uranus, S_neptu;
    public GameObject S_mer, S_ven, S_earth, S_mars, S_jup, S_saturn, S_uranus, S_neptu;
    
    
    void Start()
    {
        merycuryPnl.SetActive(true);
        venusPnl.SetActive(false);
        earthpnl.SetActive(false);
        marspnl.SetActive(false);
        jupiterPnl.SetActive(false);
        saturnpnl.SetActive(false);
        uranusPnl.SetActive(false);
        neptunepnl.SetActive(false);
     

    }

    public void AddMerycury(){
        // Instantiate(merycuryPrefab, S_mer.position , Quaternion.identity );
        S_mer.SetActive(true);
    }

    public void AddVenus(){
        // Instantiate(venusPrefab , S_ven.position , Quaternion.identity);
        S_ven.SetActive(true);
    }

    public void AddEarth(){
        // Instantiate(earthPrefab, S_earth.position , Quaternion.identity);
        S_earth.SetActive(true);
    }

    public void AddMars(){
        // Instantiate(marsPrefab , S_mars.position, Quaternion.identity);
        S_mars.SetActive(true);
    }

    public void AddJupiter(){
        // Instantiate(jupiterPrefab, S_jup.position , Quaternion.identity);
        S_jup.SetActive(true);
    }

    public void AddSaturn(){
        // Instantiate(saturnPrefab,S_saturn.position, Quaternion.identity);
        S_saturn.SetActive(true);
    }

    public void AddUranus(){
        // Instantiate(uranusPrefab , S_uranus.position, Quaternion.identity);
        S_uranus.SetActive(true);
    }

    public void AddnNptune(){
        // Instantiate(neptunePrefab , S_neptu.position, Quaternion.identity);
        S_neptu.SetActive(true);
    }


    // Update is called once per frame
    public void NextOne()
    {
        merycuryPnl.SetActive(true);
        venusPnl.SetActive(false);
        earthpnl.SetActive(false);
        marspnl.SetActive(false);
        jupiterPnl.SetActive(false);
        saturnpnl.SetActive(false);
        uranusPnl.SetActive(false);
        neptunepnl.SetActive(false);
    }


    public void NextTwo()
    {
        merycuryPnl.SetActive(false);
        venusPnl.SetActive(true);
        earthpnl.SetActive(false);
        marspnl.SetActive(false);
        jupiterPnl.SetActive(false);
        saturnpnl.SetActive(false);
        uranusPnl.SetActive(false);
        neptunepnl.SetActive(false);
    }

    public void NextThree()
    {
        merycuryPnl.SetActive(false);
        venusPnl.SetActive(false);
        earthpnl.SetActive(true);
        marspnl.SetActive(false);
        jupiterPnl.SetActive(false);
        saturnpnl.SetActive(false);
        uranusPnl.SetActive(false);
        neptunepnl.SetActive(false);
    }

    public void NextFour()
    {
        merycuryPnl.SetActive(false);
        venusPnl.SetActive(false);
        earthpnl.SetActive(false);
        marspnl.SetActive(true);
        jupiterPnl.SetActive(false);
        saturnpnl.SetActive(false);
        uranusPnl.SetActive(false);
        neptunepnl.SetActive(false);
    }

    public void NextFive()
    {
        merycuryPnl.SetActive(false);
        venusPnl.SetActive(false);
        earthpnl.SetActive(false);
        marspnl.SetActive(false);
        jupiterPnl.SetActive(true);
        saturnpnl.SetActive(false);
        uranusPnl.SetActive(false);
        neptunepnl.SetActive(false);
    }


    public void NextSix()
    {
        merycuryPnl.SetActive(false);
        venusPnl.SetActive(false);
        earthpnl.SetActive(false);
        marspnl.SetActive(false);
        jupiterPnl.SetActive(false);
        saturnpnl.SetActive(true);
        uranusPnl.SetActive(false);
        neptunepnl.SetActive(false);
    }

    public void NextSeven()
    {
        merycuryPnl.SetActive(false);
        venusPnl.SetActive(false);
        earthpnl.SetActive(false);
        marspnl.SetActive(false);
        jupiterPnl.SetActive(false);
        saturnpnl.SetActive(false);
        uranusPnl.SetActive(true);
        neptunepnl.SetActive(false);
    }

    public void NextEight()
    {
        merycuryPnl.SetActive(false);
        venusPnl.SetActive(false);
        earthpnl.SetActive(false);
        marspnl.SetActive(false);
        jupiterPnl.SetActive(false);
        saturnpnl.SetActive(false);
        uranusPnl.SetActive(false);
        neptunepnl.SetActive(true);
    }


}

