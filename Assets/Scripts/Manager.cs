using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    [SerializeField] private GameObject siebenSigment;
    [SerializeField] private Button startButton;
    private GameObject[] fluegel;
    private Vector3[] startPos;
    private bool isOn = false;

    void Start()
    {
        fluegel = new GameObject[7];
        for (int i = 0; i < 7; i++)
        {
            fluegel[i] = GameObject.Find("Fluegel" + i);
        }
        
    }

    void Update()
    {
        if (isOn) 
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                ResetPos();
                On(2);
                On(5);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                ResetPos();
                On(0);
                On(2);
                On(3);
                On(4);
                On(6);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                ResetPos();
                On(0);
                On(2);
                On(3);
                On(5);
                On(6);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                ResetPos();
                On(1);
                On(2);
                On(3);
                On(5);
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                ResetPos();
                On(0);
                On(1);
                On(3);
                On(5);
                On(6);
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                ResetPos();
                On(0);
                On(1);
                On(3);
                On(4);
                On(5);
                On(6);
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                ResetPos();
                On(0);
                On(2);
                On(5);
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                ResetPos();
                On(0);
                On(1);
                On(2);
                On(3);
                On(4);
                On(5);
                On(6);
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                ResetPos();
                On(0);
                On(1);
                On(2);
                On(3);
                On(5);
                On(6);
            }
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                ResetPos();
                On(0);
                On(1);
                On(2);
                On(4);
                On(5);
                On(6);
            }
        }
    }

    public void StartSigment()
    {
        if (!isOn)
        {
            siebenSigment.transform.Rotate(0, 180, 0);
            Rigidbody rb = siebenSigment.GetComponent<Rigidbody>();
            rb.isKinematic = true;  
            isOn = true;
            startButton.interactable = false;
            startPos = new Vector3[fluegel.Length];
            for (int i = 0; i < fluegel.Length; i++)
            {
                startPos[i] = fluegel[i].transform.position;
            }
        }
        
    }

    private void On(int i)
    {
        fluegel[i].transform.position = startPos[i] + new Vector3(0, 0, -1);


    }

    private void ResetPos()
    {
        for (int i = 0; i < fluegel.Length; i++) {
            fluegel[i].transform.position = startPos[i];
        }   
    }
}
