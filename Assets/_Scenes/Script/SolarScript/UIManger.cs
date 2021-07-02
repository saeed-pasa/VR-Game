using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManger : MonoBehaviour
{
    public GameObject istgah, pnltotal , spaceship, space, merycuryPnl, venusPnl, earthpnl, marspnl, jupiterPnl, saturnpnl, uranusPnl, neptunepnl;
    public GameObject[] planets, planetssss;
    public GameObject[] planetsSpace;
    public Camera camera1, camera2 , camera3;
    public float speed = 7;
    bool isMove = false;
    // Start is called before the first frame update
    void Start()
    {
        spaceship.SetActive(false);
        merycuryPnl.SetActive(true);
        venusPnl.SetActive(false);
        earthpnl.SetActive(false);
        marspnl.SetActive(false);
        jupiterPnl.SetActive(false);
        saturnpnl.SetActive(false);
        uranusPnl.SetActive(false);
        neptunepnl.SetActive(false);
        camera1.gameObject.SetActive(true);
        camera2.gameObject.SetActive(false);
        camera3.gameObject.SetActive(false);
        for (int i = 0; i < planetssss.Length; i++)
        {

            planetssss[i].SetActive(false);

        }
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

    public void PickMerycury()
    {
        spaceship.SetActive(true);
    

        istgah.SetActive(false);
        pnltotal.SetActive(false);
        camera1.gameObject.SetActive(false);
        camera2.gameObject.SetActive(true);

    }


    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera2.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == "Merycury")
                {
                    Debug.Log("Dd");
                    camera3.gameObject.SetActive(true);
                    camera2.gameObject.SetActive(false);
                    camera1.gameObject.SetActive(false);
                   
                    GameObject planet = Instantiate(planets[0], space.transform.position, Quaternion.identity);
                     planet.transform.parent = spaceship.transform;
                    planet.transform.localScale = new Vector3(3, 3, 3);
                    isMove = true;
                }
            }
        }

        if (isMove == true)
        {
            float step = speed * Time.deltaTime;
            spaceship.transform.position = Vector3.MoveTowards(spaceship.transform.position, planetsSpace[0].transform.position, step);
            if (spaceship.transform.position == planetsSpace[0].transform.position)
            {
                camera1.gameObject.SetActive(true);
                camera3.gameObject.SetActive(false);
                planetssss[0].SetActive(true);
                planets[0].SetActive(false);
                istgah.SetActive(true);
                pnltotal.SetActive(true);
                planetsSpace[0].SetActive(false);
            }
        }
    }
    void FixedUpdate()
    {
        float x = 2 * Input.GetAxis("Mouse X");
       // float y = 2 * -Input.GetAxis("Mouse Y");
       camera3.transform.Rotate(0, x, 0);
        }



    }

