using UnityEngine;

public class TapKnobInteraction: MonoBehaviour
{
    public Transform tapKnob;
    public GameObject waterFlow;
    public GameObject instructionPanel;
    public AudioSource waterAudio; 

    private bool isOn = false;

    void Start()
    {
        if (instructionPanel != null)
            instructionPanel.SetActive(true);

        if (waterFlow != null)
            waterFlow.SetActive(true);

        //if (waterAudio != null && !waterAudio.isPlaying)
        //    waterAudio.Play();


        tapKnob.localRotation = Quaternion.Euler(0, 400f, 0);
        isOn = true; 
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == tapKnob)
                {
                    ToggleKnob();
                }
            }
        }
    }

    void ToggleKnob()
    {
        if (!isOn)
        {
            tapKnob.localRotation = Quaternion.Euler(0, 30f, 0);

            if (waterFlow != null)
                waterFlow.SetActive(true);

            if (instructionPanel != null)
                instructionPanel.SetActive(true);

            if (waterAudio != null && !waterAudio.isPlaying)
                waterAudio.Play();

            isOn = true;
        }
        else
        {
            tapKnob.localRotation = Quaternion.Euler(0, 0, 0);

            if (waterFlow != null)
                waterFlow.SetActive(false);

            if (instructionPanel != null)
                instructionPanel.SetActive(false);

            if (waterAudio != null && waterAudio.isPlaying)
                waterAudio.Stop();

            isOn = false;
        }
    }
}
