# HoloCrane Twinbase and NextMind Setup

## Overview
This project is a development extension from the [HoloCrane V0 project](https://github.com/Plan-T42/HoloCrane-V0.git), which is a mixed reality interface running on Microsoft HoloLens 1 device for the digital twin based crane opeation.
The setups of the following two modules are currently being investigated in this project:
 
* The mixed reality application accessing the DT documents using [twinbase](https://github.com/twinbase/twinbase).  
    * [Description of terms](https://github.com/Plan-T42/HoloCrane-V1_setup-with-twinbase-and-NextMind/blob/master/Descriptions%20of%20terms.md) file describes the internal application parameters that should be included in the DT document. As we are stil design phase, the parameters have not been fully implemented in the current demo apllication yet. 
    * [SimpleJSON](https://github.com/HenrikPoulsen/SimpleJSON) script for Unity is utilized as a JSON parser and included in the Asset folder.    
    * The unity project can send web requests to access the URL of the [raw JSON file](https://dtw.dtp.fi/crane-ilmatar/index.json) from the [DT document for Ilmatar crane](https://dtw.dtp.fi/crane-ilmatar/).

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


## Run the demo application

You are all set!

Select the scene (either "DT_document.unity" or "NextMind.unity") from the [Project Window](https://docs.unity3d.com/Manual/UsingTheEditor.html).

When you are located in the selected scene (you should find the scene name in the [Hierarchy window](https://docs.unity3d.com/Manual/UsingTheEditor.html), press play, and wait for the system to initialize. 

### DT document scene

Click the "get Digital Twin Info" button, the content from the JSON URL will be fetched and selectively displayed in the canvas under "Digital Twin name", "Description", "Owner" and "Location" headers. 

### NextMind scene 

This part is currently under development, the expected release date of which depends on when NextMind releases their AR demo. 

## Next releases

The following features are planned to be implemented in the next releases:

- holographic visualization and control logic based on the parameters of the HoloCrane application that are read from DT document.
  - dashboard to display the basic digital twin information;
  - operational area indicator; 
  - spatial transformation offset based on given locations of the registration marker and target holograms;
  - various layout options determined by given design parameters' values.
- A customed Unity C# package of accessing the DT document.
- The registration marker as a QR-code with DT-id that meanwhile can be used to access the crane DT document URL.  
- A complete demo of NextMind application.
- Integration of both DT document access and NextMind control setups into the [HoloCrane V0 project](https://github.com/Plan-T42/HoloCrane-V0.git).
