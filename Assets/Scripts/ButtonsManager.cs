using UnityEngine;
using UnityEngine.Video;

public class ButtonsManager : MonoBehaviour
{
    //public GameObject cam;
    public GameObject livingRoom;
    public GameObject cantina;
    public GameObject cube;
    public GameObject mezzanine;

    public GameObject canvas;

    public GameObject infoBoxLiv1;
    public GameObject infoBoxLiv2;
    public GameObject infoBoxCan1;
    public GameObject infoBoxCube1;
    public GameObject infoBoxMezz1;
    public GameObject infoBoxMezz2;

    GameObject livingRoomCanvas;
    GameObject cantinaCanvas;
    GameObject cubeCanvas;
    GameObject mezzanineCanvas;

    public void Start()
    {
        livingRoomCanvas = canvas.transform.GetChild(0).gameObject;
        cantinaCanvas = canvas.transform.GetChild(1).gameObject;
        cubeCanvas = canvas.transform.GetChild(2).gameObject;
        mezzanineCanvas = canvas.transform.GetChild(3).gameObject;
    }


    public void ToCantina()
    {
        //Debug.Log("ToCantina");
        livingRoom.SetActive(false);
        cantina.SetActive(true);
        cube.SetActive(false);
        livingRoomCanvas.SetActive(false);
        cantinaCanvas.SetActive(true);
        cubeCanvas.SetActive(false);
        infoBoxLiv1.SetActive(false);
        infoBoxLiv2.SetActive(false);
        infoBoxCube1.SetActive(false);
    }

    public void ToLivingRoom()
    {
        //Debug.Log("ToLivingRoom");
        livingRoom.SetActive(true);
        cantina.SetActive(false);
        cube.SetActive(false);
        cubeCanvas.SetActive(false);
        livingRoomCanvas.SetActive(true);
        cantinaCanvas.SetActive(false);
        infoBoxCan1.SetActive(false);
        infoBoxCube1.SetActive(false);
    }

    public void ToCube()
    {
        //Debug.Log("ToCube");
        livingRoom.SetActive(false);
        cantina.SetActive(false);
        cube.SetActive(true);
        mezzanine.SetActive(false);
        livingRoomCanvas.SetActive(false);
        cantinaCanvas.SetActive(false);
        cubeCanvas.SetActive(true);
        mezzanineCanvas.SetActive(false);
        infoBoxLiv1.SetActive(false);
        infoBoxLiv2.SetActive(false);
        infoBoxCan1.SetActive(false);
        infoBoxMezz1.SetActive(false);
        infoBoxMezz2.SetActive(false);
    }

    public void ToMezzanine()
    {
        //Debug.Log("ToMezzanine");
        cube.SetActive(false);
        mezzanine.SetActive(true);
        cubeCanvas.SetActive(false);
        mezzanineCanvas.SetActive(true);
        infoBoxCube1.SetActive(false);
    }

    public void InfoBoxLiv1()
    {
        if (!infoBoxLiv1.activeSelf)
        {
            infoBoxLiv1.SetActive(true);
        }
        else
        {
            infoBoxLiv1.SetActive(false);
        }
    }

    public void InfoBoxLiv2()
    {
        if (!infoBoxLiv2.activeSelf)
        {
            infoBoxLiv2.SetActive(true);
        }
        else
        {
            infoBoxLiv2.SetActive(false);
        }
    }

    public void InfoBoxCan1()
    {
        if (!infoBoxCan1.activeSelf)
        {
            infoBoxCan1.SetActive(true);
        }
        else
        {
            infoBoxCan1.SetActive(false);
        }
    }

    public void InfoBoxCube1()
    {
        if (!infoBoxCube1.activeSelf)
        {
            infoBoxCube1.SetActive(true);
        }
        else
        {
            infoBoxCube1.SetActive(false);
        }
    }

    public void InfoBoxMezz1()
    {
        if (!infoBoxMezz1.activeSelf)
        {
            infoBoxMezz1.SetActive(true);
        }
        else
        {
            infoBoxMezz1.SetActive(false);
        }
    }

    public void InfoBoxMezz2()
    {
        if (!infoBoxMezz2.activeSelf)
        {
            infoBoxMezz2.SetActive(true);
        }
        else
        {
            infoBoxMezz2.SetActive(false);
        }
    }

}
