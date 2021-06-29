using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManger : MonoBehaviour
{
    public GameObject merycuryPnl, venusPnl, earthpnl, marspnl, jupiterPnl, saturnpnl, uranusPnl, neptunepnl; 
    // Start is called before the first frame update
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

