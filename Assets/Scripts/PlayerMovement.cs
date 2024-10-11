using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 movedirection;
    float horizontalInput;
    float verticalInput;
    Rigidbody m_Rigidbody;
    public float speed = 5f;

    //puzzle 1
    public bool NearKey;
    public bool KeyHeld;
    public bool NearHatch;

    public GameObject Text;
    public GameObject KeyCollect;
    public GameObject Key;
    public GameObject Hatch;


    //puzzle 2
    public GameObject Knife;
    public GameObject Net;
    public GameObject Stone;
    public GameObject Wheel;
    public GameObject Vent;

    public bool NearKnife;
    public bool KnifeHeld;
    public bool NearStone;
    public bool StoneHeld;
    public bool NearWheel;
    public bool NearNet;

    //puzzle 3
    public GameObject Cushions;
    public GameObject BoltCutter;
    public GameObject CupboardDoor;
    public GameObject Terry;
    public GameObject Octopus;

    public bool NearCushions;
    public bool NearBoltCutter;
    public bool NearCupboardDoor;
    public bool NearTerry;
    public bool NearOctopus;

    public bool TerryHeld;
    public bool BoltCuttersHeld;
    public bool NearClock;

    //clock
    public GameObject ClockArea;
    public GameObject MainCamera;

    public CameraMove CameraScript;

    public Animator PlayerAnims;

    public Animator WheelAnims;

    public bool InMovement;

    public bool IdleAnimPlaying;


    public GameObject PlayerBoltCutters;
    public GameObject PlayerSardine;
    public GameObject PlayerRock;
    public GameObject PlayerKnife;
    public GameObject PlayerKey;

    public bool OctopusGone;

    public GameObject VentwithAnim;
    public GameObject RockwithRB1;
    public GameObject RockwithRB2;

    public GameObject LiftDoors;

    public GameObject Cube;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        movedirection = new Vector2(horizontalInput, verticalInput);
        m_Rigidbody.MovePosition(transform.position + movedirection * Time.deltaTime * speed);

        if (Input.GetMouseButtonDown(0)) //left click
        {
            //object held and interact with other objects

            if(KeyHeld && NearHatch)
            {
                PlayerKey.SetActive(false);
                KeyHeld = false;
                NearHatch = false;
                NearKey = false;
                CameraScript.Room2Enter();
                Hatch.SetActive(false);
            }

            if (NearNet && KnifeHeld)
            {
                NearNet = false;
                Net.SetActive(false);
                PlayerKnife.SetActive(false);
                RockwithRB1.SetActive(true);
                speed = 5;
                Stone.SetActive(false);
            }

            if(NearWheel && StoneHeld)
            {
                PlayerRock.SetActive(false);
                NearWheel = false;
                StoneHeld = false;
                RockwithRB2.SetActive(true);
                VentwithAnim.SetActive(true);

                Vent.SetActive(false);

                CameraScript.Room2VentUnlocked();
                WheelAnims.Play("WheelTurnAnim");
            }


            if(NearCupboardDoor && BoltCuttersHeld)
            {
                NearCupboardDoor = false;

                CupboardDoor.SetActive(false);
                PlayerBoltCutters.SetActive(false);
                BoltCuttersHeld = false;
            }

            if(NearOctopus && TerryHeld)
            {
                NearOctopus = false;
                TerryHeld = false;

                PlayerSardine.SetActive(false);
                Octopus.SetActive(false);
                OctopusGone = true;
                
            }

            if(NearClock && OctopusGone)
            {
                NearClock = false;

                ClockArea.SetActive(true);
                MainCamera.SetActive(false);

                transform.position = new Vector3(-1.32f, 24.33f, 3.86f);

                LiftDoors.SetActive(false);
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            //pick up object

            if(NearKey)
            {
                KeyHeld = true;
                PlayerKey.SetActive(true);
                Key.SetActive(false);
                NearKey = false;
            }

            if(NearKnife)
            {
                KnifeHeld = true;
                PlayerKnife.SetActive(true);
                Knife.SetActive(false);
                NearKnife = false;
            }

            if(NearStone)
            {
                StoneHeld = true;
                PlayerRock.SetActive(true);
                RockwithRB1.SetActive(false);
                Destroy(RockwithRB1);
                Stone.SetActive(false);
                NearStone = false;
            }
        
            if(NearCushions)
            {
                Cushions.SetActive(false);
                NearCushions = false;
            }

            if(NearBoltCutter && !NearCushions)
            {
                BoltCuttersHeld = true;
                NearBoltCutter = false;
                PlayerBoltCutters.SetActive(true);
                BoltCutter.SetActive(false);
            }

            if(NearTerry)
            {
                TerryHeld = true;
                NearTerry = false;
                PlayerSardine.SetActive(true);
                Terry.SetActive(false);
            }
        }

        if(Input.GetKey(KeyCode.W))
        {
            gameObject.transform.eulerAngles = new Vector3(0f, 180f, -90f);
            InMovement = true;
        }

        if(Input.GetKey(KeyCode.S))
        {
            gameObject.transform.eulerAngles = new Vector3(0f, 180f, 90f);
            InMovement = true;

        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
            InMovement = true;

        }

        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.eulerAngles = new Vector3(0f, 180f, 0f);
            InMovement = true;
            Debug.Log("test");
        }

        if(InMovement)
        {
            PlayerAnims.Play("Swimming Anim");
            IdleAnimPlaying = false;
            StopAllCoroutines();

            PlayerKnife.transform.localPosition = new Vector3(-9.12f, -0.74f, -0.374f);
            PlayerBoltCutters.transform.localPosition = new Vector3(-9.25f, 0.49f, -0.19f);
            PlayerRock.transform.localPosition = new Vector3(-8.65f, -0.87f, -0.223f);
            PlayerSardine.transform.localPosition = new Vector3(-8.65f, -0.77f, -0.222f);
            PlayerKey.transform.localPosition = new Vector3(-9.46f, -0.579f, -0.374f);
        }


        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D))
        {
            InMovement = false;
        }


        if(InMovement == false && !IdleAnimPlaying)
        {
            StartCoroutine(Wait());
        }

    }

    private void OnTriggerEnter(Collider collision)
    {

        if(collision.gameObject.tag == "Cube")
        {
            CameraScript.Room3Enter();
            Destroy(Cube);
        }
        if (collision.gameObject.tag == "KeyItem")
        {
            NearKey = true;
        }

        if (collision.gameObject.tag == "Hatch")
        {
            NearHatch = true;
        }

        if(collision.gameObject.tag == "Knife")
        {
            NearKnife = true;
        }

        if(collision.gameObject.tag == "Net")
        {
            NearNet = true;
        }

        if(collision.gameObject.tag == "Stone")
        {
            NearStone = true;
        }

        if(collision.gameObject.tag == "Wheel")
        {
            NearWheel = true;
        }

        if(collision.gameObject.tag == "Cushion")
        {
            NearCushions = true;
        }

        if(collision.gameObject.tag == "Bolt Cutters")
        {
            NearBoltCutter = true;
        }

        if(collision.gameObject.tag == "CupboardDoor")
        {
            NearCupboardDoor = true;
        }

        if(collision.gameObject.tag == "Terry")
        {
            NearTerry = true;
        }

        if(collision.gameObject.tag == "Octopus")
        {
            NearOctopus = true;
        }

        if (collision.gameObject.tag == "Clock")
        {
            NearClock = true;
        }

        if (collision.gameObject.tag == "Border")
        {
            transform.position = new Vector3(-2.85f, 0.86f, 0f);
        }
    }


    private void OnTriggerExit(Collider collision)
    {

        if (collision.gameObject.tag == "Clock")
        {
            NearClock = false;
        }

        if (collision.gameObject.tag == "KeyItem")
        {
            NearKey = false;
        }

        if(collision.gameObject.tag == "Hatch")
        {
            NearHatch = false;
        }

        if(collision.gameObject.tag == "Knife")
        {
            NearKnife = false;
        }

        if(collision.gameObject.tag == "Stone")
        {
            NearStone = false;
        }

        if(collision.gameObject.tag == "Wheel")
        {
            NearWheel = false;
        }

        if (collision.gameObject.tag == "Cushion")
        {
            NearCushions = false;
        }

        if (collision.gameObject.tag == "Bolt Cutters")
        {
            NearBoltCutter = false;
        }

        if (collision.gameObject.tag == "CupboardDoor")
        {
            NearCupboardDoor = false;
        }

        if (collision.gameObject.tag == "Terry")
        {
            NearTerry = false;
        }

        if (collision.gameObject.tag == "Octopus")
        {
            NearOctopus = false;
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(IdleAnimWait());
        IdleAnimPlaying = true;
    }

    IEnumerator IdleAnimWait()
    {
        yield return new WaitForSeconds(0.7f);
        gameObject.transform.eulerAngles = new Vector3(0f, 180f, 0f);

        PlayerAnims.Play("IdleAnim");

        PlayerKnife.transform.localPosition = new Vector3(-5.21f, -0.3f, -0.374f);
        PlayerBoltCutters.transform.localPosition = new Vector3(-5.01f, 0.05f, -0.294f);
        PlayerRock.transform.localPosition = new Vector3(-5.19f,-0.98f,-0.223f);
        PlayerSardine.transform.localPosition = new Vector3(-4.54f, -0.4f, -0.222f);
        PlayerKey.transform.localPosition = new Vector3(-5.44f, -0.27f, -0.374f);

    }
}
