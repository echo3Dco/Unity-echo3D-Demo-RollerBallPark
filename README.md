# Unity-echo3D-Demo-RollerBallPark
Roll up to the finish line and use just the right amount of force to stay on the platform! Push the cubes out of your way without pushing yourself off.


## Setup
* Built with Unity 2020.3.25.  _(Note: The echo3D Unity SDK is supported in 2020.3.25 and higher.)_
* Register for FREE at [echo3D](https://console.echo3D.co/#/auth/register).
* [Add the Unity SDK](https://medium.com/r/?url=https%3A%2F%2Fdocs.echo3d.co%2Funity%2Finstallation). Troubleshoot [here](https://docs.echo3d.com/unity/troubleshooting#im-getting-a-newtonsoft.json.dll-error-in-unity).
* Clone this repo. 


## Setup
* [Add these models](https://docs.echo3D.co/quickstart/add-a-3d-model) to the echo3D console from the Unity Assets/Models folder:  <br>
      - Ball <br>
      - Floor <br>
      - Floor (1)<br>
      - Floor (2)<br>
      - Floor (3)<br>
      - Floor (4)<br>


* Open the _SampleScene_ scene.
* [Set the API key](https://docs.echo3d.co/quickstart/access-the-console) and Entry IDs for those same models in the Inspector. <br>
![APIKeyandEntryId](https://user-images.githubusercontent.com/99516371/195749269-f7a43477-b67a-49e8-a212-6abdb9c948fd.png)<br>
![NEWAPIKeyandEntryID](https://user-images.githubusercontent.com/99516371/205407613-b746840f-8e8a-4ec8-b056-a680395dfab4.png)<br>

* [Type your Secret Key](https://docs.echo3d.co/web-console/deliver-pages/security-page#secret-key) as the value for the parameter secKey in the file Packages/co.echo3D.unity/Runtime/Echo3DHologram.cs. _(Note: Secret Key only matters if you have the Security Key enabled). You can turn it off in the Security options in your echo3D console._
![NEWSecKey2](https://user-images.githubusercontent.com/99516371/195749308-b2349a3b-7e43-4d3c-8f09-fbfa9d3cb0be.png)<br>


* (Recommended) To move, resize or edit the assets live in your Scene view, check the boxes for “Editor Preview” and “Ignore Model Transforms”. To enable this, click Echo3D > Load Editor Holograms in your Unity toolbar. <br>
![EditorPreviewAndIgnoreModelTransforms](https://user-images.githubusercontent.com/99516371/195749348-dc0b06ad-efa6-4dbd-962f-0119b5c33ea0.png)<br>
![LoadHolograms](https://user-images.githubusercontent.com/99516371/195749354-b2295183-f877-444a-af22-ed87ffb17705.png) <br>



## Run
Press Play in Unity and use your arrow keys to roll around: up, down, right and left.

## Learn more
Refer to our [documentation](https://docs.echo3D.co/unity/) to learn more about how to use Unity and echo3D.

## Support
Feel free to reach out at [support@echo3D.co](mailto:support@echo3D.co) or join our [support channel on Slack](https://go.echo3D.co/join). 

## Screenshots
![ezgif com-gif-maker](https://user-images.githubusercontent.com/99516371/182938828-236a8939-b440-4f8b-a860-3988283e7120.gif)<br>
![Screenshot](https://user-images.githubusercontent.com/99516371/182938841-dd4fc606-6923-42e9-b80b-958d19170fea.png)<br>
![Screenshot1](https://user-images.githubusercontent.com/99516371/182938842-cdbeedd5-117d-4666-a8dc-461992854e99.png)<br>
![Screenshot2](https://user-images.githubusercontent.com/99516371/182938837-a0dcff03-4130-46fe-970a-15d46c466602.png)<br>
![Screenshot3](https://user-images.githubusercontent.com/99516371/182938839-e2e2fe4e-4152-47be-a2ba-b38240bb409f.png)

