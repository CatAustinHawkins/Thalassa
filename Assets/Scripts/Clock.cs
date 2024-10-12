using UnityEngine;

public class Clock : MonoBehaviour
{

    public bool MinuteHandSelected;
    public bool HourHandSelected;

    public GameObject MinuteHand;
    public GameObject HourHand;

    public GameObject Player;
    public GameObject MainCamera;

    public bool MinuteHandDone;
    public bool HourHandDone;

    private void OnEnable()
    {
        Player.SetActive(false);
        MainCamera.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit, 100f))
            {
                CurrentClickedGameObject(raycastHit.transform.gameObject);
            }
        }

        if(MinuteHandDone && HourHandDone)
        {
            Player.SetActive(true);
            MainCamera.SetActive(true);
            gameObject.SetActive(false);
        }    
    }
    public void CurrentClickedGameObject(GameObject gameObject)
    {
        if (gameObject.tag == "HandMinute" && !MinuteHandDone)
        {
            MinuteHandSelected = true;
            HourHandSelected = false;
        }

        if(gameObject.tag == "HandHour" && !HourHandDone)
        {
            MinuteHandSelected = false;
            HourHandSelected = true;
        }

        if(gameObject.tag == "1")
        {
            if(MinuteHandSelected)
            {
                MinuteHand.transform.localRotation = Quaternion.Euler(-180f, 0, -30f);
            }

            if (HourHandSelected)
            {
                HourHand.transform.localRotation = Quaternion.Euler(-180f, 0, -30f);
            }
        }
        if (gameObject.tag == "2")
        {
            if (MinuteHandSelected)
            {
                MinuteHand.transform.localRotation = Quaternion.Euler(-180f, 0, -60f);
            }

            if (HourHandSelected)
            {
                HourHand.transform.localRotation = Quaternion.Euler(-180f, 0, -60f);
            }
        }
        if (gameObject.tag == "3")
        {
            if (MinuteHandSelected)
            {
                MinuteHand.transform.localRotation = Quaternion.Euler(-180f, 0, -90f);
            }

            if (HourHandSelected)
            {
                HourHand.transform.localRotation = Quaternion.Euler(-180f, 0, -90f);
            }
        }
        if (gameObject.tag == "4")
        {
            if (MinuteHandSelected)
            {
                MinuteHand.transform.localRotation = Quaternion.Euler(-180f, 0, -120f);
            }

            if (HourHandSelected)
            {
                HourHand.transform.localRotation = Quaternion.Euler(-180f, 0, -120f);
            }
        }
        if (gameObject.tag == "5")
        {
            if (MinuteHandSelected)
            {
                MinuteHand.transform.localRotation = Quaternion.Euler(-180f, 0, -150f);
            }

            if (HourHandSelected)
            {
                HourHand.transform.localRotation = Quaternion.Euler(-180f, 0, -150f);

                HourHandDone = true;
                HourHandSelected = false;
            }
        }
        if (gameObject.tag == "6")
        {
            if (MinuteHandSelected)
            {
                MinuteHand.transform.localRotation = Quaternion.Euler(-180f, 0, -180f);
            }

            if (HourHandSelected)
            {
                HourHand.transform.localRotation = Quaternion.Euler(-180f, 0, -180f);
            }
        }
        if (gameObject.tag == "7")
        {
            if (MinuteHandSelected)
            {
                MinuteHand.transform.localRotation = Quaternion.Euler(-180f, 0, -210f);
            }

            if (HourHandSelected)
            {
                HourHand.transform.localRotation = Quaternion.Euler(-180f, 0, -210f);
            }
        }
        if (gameObject.tag == "8")
        {
            if (MinuteHandSelected)
            {
                MinuteHand.transform.localRotation = Quaternion.Euler(-180f, 0, -240f);
            }

            if (HourHandSelected)
            {
                HourHand.transform.localRotation = Quaternion.Euler(-180f, 0, -240f);
            }
        }
        if (gameObject.tag == "9")
        {
            if (MinuteHandSelected)
            {
                MinuteHand.transform.localRotation = Quaternion.Euler(-180f, 0, -270f);
            }

            if (HourHandSelected)
            {
                HourHand.transform.localRotation = Quaternion.Euler(-180f, 0, -270f);
            }
        }
        if (gameObject.tag == "10")
        {
            if (MinuteHandSelected)
            {
                MinuteHand.transform.localRotation = Quaternion.Euler(-180f, 0, -300f);
            }

            if (HourHandSelected)
            {
                HourHand.transform.localRotation = Quaternion.Euler(-180f, 0, -300f);
            }
        }
        if (gameObject.tag == "11")
        {
            if (MinuteHandSelected)
            {
                MinuteHand.transform.localRotation = Quaternion.Euler(-180f, 0, -330f);
            }

            if (HourHandSelected)
            {
                HourHand.transform.localRotation = Quaternion.Euler(-180f, 0, -330f);
            }
        }
        if (gameObject.tag == "12")
        {
            if (MinuteHandSelected)
            {
                MinuteHand.transform.localRotation = Quaternion.Euler(-180f, 0, 0);
                MinuteHandDone = true;
                MinuteHandSelected = false;
            }

            if (HourHandSelected)
            {
                HourHand.transform.localRotation = Quaternion.Euler(-180f, 0, 0);
            }
        }
    }

}
