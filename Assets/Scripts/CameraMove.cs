using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Vector3 movedirection;
    float horizontalInput;
    float verticalInput;
    public float speed = 5f;

    public float speed2 = 0.5f;

    public GameObject Player;
    public GameObject Position1;
    public GameObject Position2;
    public GameObject Position3;

    public float ZValue;

    public bool FollowPlayer = true;
    public Rigidbody m_Rigidbody;

    public bool Room2Entered;
    public bool VentUnlocked;
    public bool Room3Entered;

    public GameObject Puzzle1Complete;
    public GameObject Puzzle2Complete;

    void Start()
    {
        ZValue = -6.54f;
    }

    void FixedUpdate()
    {
        if (FollowPlayer)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
            movedirection = new Vector2(horizontalInput, verticalInput);
            movedirection = new Vector2(Player.transform.position.x, Player.transform.position.y);
            transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, ZValue);
        }

        if(Room2Entered)
        {
            transform.position = Vector3.MoveTowards(transform.position, Position1.transform.position, speed2);

        }

        if(VentUnlocked)
        {
            transform.position = Vector3.MoveTowards(transform.position, Position2.transform.position, speed2);
        }

        if (Room3Entered)
        {
            transform.position = Vector3.MoveTowards(transform.position, Position3.transform.position, speed2);
        }
    }


    public void Room2Enter()
    {
        FollowPlayer = false;
        Room2Entered = true;
        Puzzle1Complete.SetActive(true);
        StartCoroutine(Wait());

    }

    public void Room2VentUnlocked()
    {
        FollowPlayer = false;
        VentUnlocked = true;
        Puzzle2Complete.SetActive(true);
        StartCoroutine(Wait());

    }

    public void Room3Enter()
    {
        FollowPlayer = false;
        Room3Entered = true;
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
        FollowPlayer = true;
        Room2Entered = false;
        VentUnlocked = false;
        Room2Entered = false;

        Puzzle1Complete.SetActive(false);
        Puzzle2Complete.SetActive(false);
    }

}
