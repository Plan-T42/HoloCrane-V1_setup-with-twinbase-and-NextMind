# HoloCrane Twinbase and NextMind Setup

## Overview
This project is a development extension from the [HoloCrane project](https://github.com/Plan-T42/HoloCrane), which is a mixed reality interface running on Microsoft HoloLens 1 device for the digital twin based crane opeation.
The setups of the following two modules are currently being investigated in this project:
 
* The mixed reality application accessing the DT documents using [twinbase](https://github.com/twinbase/twinbase).  
    * The internal application parameters that should be included in the DT document are specified in the [description of terms](https://github.com/Plan-T42/HoloCrane-V1_setup-with-twinbase-and-NextMind/blob/master/Descriptions%20of%20terms.md) file.
    * [SimpleJSON](https://github.com/HenrikPoulsen/SimpleJSON) script for Unity is utilized as a JSON parser and included in the Asset folder.    
    * The script access the URL of the [raw JSON file](https://dtw.dtp.fi/crane-ilmatar/index.json) from the [DT document for Ilmatar crane](https://dtw.dtp.fi/crane-ilmatar/).

* Integrating mind-controlled interaction into the mixed reality application using [NextMind DevKit](https://www.next-mind.com/documentation).



## Prequisites

- [Unity 2019.3.0f6](https://unity3d.com/get-unity/download/archive)
- [NET 4.6 equivalent and C# 7.3](https://docs.unity3d.com/2019.3/Documentation/Manual/CSharpCompiler.html)
- [NextMind Unity SDK](https://www.next-mind.com/documentation/unity-sdk/download/)
- Git

The project was developed and tested on Windows 10. 

## Installation 

Download the [Unity 2019.3.0f6](https://unity3d.com/get-unity/download/archive). 
If you have mutiple versions of Unity installed, [Unity Hub](https://docs.unity3d.com/Manual/GettingStartedInstallingHub.html) is suggested.

Clone source code.
```sh
git clone https://github.com/Plan-T42/HoloCrane-V1_setup-with-twinbase-and-NextMind.git
```

Open the proejct folder with Unity 2019.3.0f6.

Install the NextMind Unity SDK following the steps below (details see [tutorial](https://www.next-mind.com/documentation/unity-sdk/download/)). 

- Download the asset package [here](https://nextmind-sdk.s3-eu-west-1.amazonaws.com/unity/NextMindSDK.unitypackage).
- Drag & drop NextMindSDK.unitypackage in the project view of Unity.
- Or go to Assets / Import Package / Custom package..., then find NextMindSDK.unitypackage using the file picker.


## Run the demo

You are all set!

Pick the scene (either "DT_document.unity" or "NextMind.unity") by double click its name in the [Project Window](https://docs.unity3d.com/Manual/UsingTheEditor.html).

When you are located in the selected scene (you can find the scene name in the [Hierarchy window](https://docs.unity3d.com/Manual/UsingTheEditor.html), press play, and wait for the system to initialize. 

### DT document scene

Click the "get Digital Twin Info" button, the content fetched from the JSON URL will be selectively displayed in the canvas under "Digital Twin name", "Description", "Owner" and "Location". 

### NextMind scene 

under development, expected release date: fall 2021.

