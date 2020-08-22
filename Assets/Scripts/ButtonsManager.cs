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

    public GameObject infoBox;

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
        infoBox.SetActive(false);
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
        infoBox.SetActive(false);
    }

    public void ToMezzanine()
    {
        //Debug.Log("ToMezzanine");
        cube.SetActive(false);
        mezzanine.SetActive(true);
        cubeCanvas.SetActive(false);
        mezzanineCanvas.SetActive(true);
    }

    public void InfoBox()
    {
        if (!infoBox.activeSelf)
        {
            infoBox.SetActive(true);
        }
        else
        {
            infoBox.SetActive(false);
        }
    }
}
