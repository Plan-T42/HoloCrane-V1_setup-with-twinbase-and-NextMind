using System.Collections;
using UnityEngine;
using SimpleJSON;
using UnityEngine.Networking;
using TMPro;

public class JsonReaderFromServer : MonoBehaviour
{
    
    public TMP_Text nameTXT;
    public TMP_Text descriptionTXT;
    public TMP_Text ownerTXT;
    public TMP_Text locationTXT;

    public void getJsonData()
    {
        Debug.Log("get JSON Data!");
        StartCoroutine(RequestWebService());
    }

    IEnumerator RequestWebService()
    {
        string getDataUrl = "https://dtw.dtp.fi/crane-ilmatar/index.json";
        //  + inputTxt.text
        //print(getDataUrl);
        Debug.Log("Data url: " + getDataUrl);

        using (UnityWebRequest webData = UnityWebRequest.Get(getDataUrl))
        {

            yield return webData.SendWebRequest();
            if (webData.isNetworkError || webData.isHttpError)
            {
                //print("---------------- ERROR ----------------");
                //print(webData.error);
                Debug.Log("ERROR: " + webData.error);
            }
            else
            {
                if (webData.isDone)
                {
                    JSONNode jsonData = JSON.Parse(System.Text.Encoding.UTF8.GetString(webData.downloadHandler.data));

                    if (jsonData == null)
                    {
                        Debug.Log("NO DATA");
                    }
                    else
                    {
                        Debug.Log("JSON DATA: ");
                        Debug.Log("jsonData.Count:" + jsonData.Count);

                        nameTXT.text = jsonData["name"];
                        Debug.Log("digital twin name: " + name);

                        descriptionTXT.text = jsonData["description"]; 
                        Debug.Log("desciption: " + jsonData["description"]);

                        ownerTXT.text = jsonData["owner"]["name"];
                        Debug.Log("desciption: " + jsonData["owner"]["name"]);

                        locationTXT.text = jsonData["location"]["streetAddress"];
                        Debug.Log("desciption: " + jsonData["location"]["streetAddress"]);
                    }
                }
            }
        }
    }
}
