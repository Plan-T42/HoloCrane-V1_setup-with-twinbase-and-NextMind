using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class JsonReader : MonoBehaviour
{
    public TextAsset jsonFile;


    [Serializable]
    public class Twin
    {
        public string url;
        public string name;
    }

    [Serializable]
    public class Owner
    {
        public string dt_id;
    }

    [Serializable]
    public class DT_document
    {
        public string baseurl;
        public Owner owner;
        public string repo_url;
        public string new_twin_url;
        public Twin[] twins;
    }


    void Start()
    {
        DT_document DTInJson = JsonUtility.FromJson<DT_document>(jsonFile.text);

        foreach (Twin twin in DTInJson.twins)
        {
            Debug.Log("Found digital twin: " + twin.name + " with url: " + twin.url);
        }

        Debug.Log("Owner: " + DTInJson.owner.dt_id);

    }
}
