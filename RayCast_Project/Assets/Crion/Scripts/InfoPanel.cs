using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InfoPanel : MonoBehaviour
{
    public GameObject infoPanel;
    public GameObject infoDetail;

   
    public TMP_Text descriptionText;

    public Button infoButton;
    public Button closeInfoPanel;

    public Transform currentTarget;

    public TMP_Text mainUIButtonText;

    void Start()
    {
        if (infoPanel != null)
            infoPanel.SetActive(false);

        if (infoDetail != null)
            infoDetail.SetActive(false);

        if (infoButton != null)
            infoButton.onClick.AddListener(ShowInfoDetail);

        if (closeInfoPanel != null)
            closeInfoPanel.onClick.AddListener(CloseInfoDetail);
    }

    public void ShowInfoPanel(string assetName, string description, Transform target)
    {
        if (infoPanel != null)
            infoPanel.SetActive(true);

        if (descriptionText != null)
            descriptionText.text = description;

      
        AssetData ad = target.GetComponent<AssetData>();
        Vector3 offset = new Vector3(0, 2f, 0);
        Vector3 rotation = Vector3.zero;

        if (ad != null)
        {
            offset = ad.panelOffset;
            rotation = ad.panelRotation;
        }

        infoPanel.transform.position = target.position + offset;
        infoPanel.transform.rotation = Quaternion.Euler(rotation);

       
        if (mainUIButtonText != null)
            mainUIButtonText.text = assetName;

        currentTarget = target;
    }

    public void ShowInfoDetail()
    {
        if (infoPanel != null)
            infoPanel.SetActive(false);

        if (infoDetail != null)
        {
            infoDetail.SetActive(true);

            if (currentTarget != null)
            {
                AssetData ad = currentTarget.GetComponent<AssetData>();
                Vector3 offset = new Vector3(0, 2f, 0);
                Vector3 rotation = Vector3.zero;

                if (ad != null)
                {
                    offset = ad.panelOffset;
                    rotation = ad.panelRotation;
                }

                infoDetail.transform.position = currentTarget.position + offset;
                infoDetail.transform.rotation = Quaternion.Euler(rotation);
            }
        }
    }

    public void CloseInfoDetail()
    {
        if (infoDetail != null)
            infoDetail.SetActive(false);
    }
}
