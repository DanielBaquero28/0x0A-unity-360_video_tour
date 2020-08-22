<html>
<header><h1>Project: Unity 360 Video Tour</h1></header>
<body>
<p><strong>In this project we'll be taking our first steps into a VR experience done with Unity. We'll be creating a VR tour experience of one of the campuses of Holberton School. Dive right into it !</strong></p>
<ul>
<li><strong>Task 0: </strong>In this project you will be creating a 360 video VR tour. Download the following source clips:
<ul>
<li>LivingRoom.mp4</li>
<li>Cantina.mp4</li>
<li>Cube.mp4</li>
<li>Mezzanine.mp4</li>
</ul>
Create a project called 0x0A-unity-360_video_tour and adjust your Project Settings, Build Settings, and Player Settings according to the device you will be building for. Import the four video files (LivingRoom.mp4, Cantina.mp4, Cube.mp4, Mezzanine.mp4) into a folder called Videos in the Assets folders your project.

NOTE: If you are developing for Google Cardboard and the videos do not play on your device, try lowering the video resolution in the Inspector

Create a scene called 360VideoTour. Create a Sphere object called LivingRoom and position the VR camera in the center of it. Using the LivingRoom.mp4 video, a Video Player component, and a Render Texture, wrap the video to the Sphere such that the camera is “inside” the video.
<ul>
<li>The video should play automatically and loop.</li>
<li>You are not allowed to use Movie Textures in this project.</li>
</ul>
<img src="https://holbertonintranet.s3.amazonaws.com/uploads/medias/2019/2/4fd49076a6664f03f124.gif?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIARDDGGGOUWMNL5ANN%2F20200818%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20200818T205529Z&X-Amz-Expires=86400&X-Amz-SignedHeaders=host&X-Amz-Signature=dc66e0e54f673aa4ed5aae082fbfd968ca5f3eb0b4e19f7b88a7564377dc7825">
</li>
<li><strong>Task 1: </strong>Create three new Spheres for the remaining videos and name them accordingly.
<ul>
<li>Cantina</li>
<li>Cube</li>
<li>Mezzanine</li>
</ul>
You may find that when running or testing your build, your headset or Unity itself may not be able to handle multiple videos or Render Textures at once. Keep videos disabled unless necessary.
</li>
<li><strong>Task 2: </strong>Inside the LivingRoom Sphere, create a Button with the provided image to be a hotspot called CantinaHotspot and a text element with the text “Cantina” next to it.

Create behavior for your hotspot button such that when the user interacts with it via controller or gaze, it will take them to the Cantina Sphere. Likewise, inside the Cantina Sphere, create a hotspot called LivingRoomHotspot that will return the user back to the LivingRoom Sphere.
<img src="https://holbertonintranet.s3.amazonaws.com/uploads/medias/2019/2/9da74aee019c17282907.gif?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIARDDGGGOUWMNL5ANN%2F20200818%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20200818T205529Z&X-Amz-Expires=86400&X-Amz-SignedHeaders=host&X-Amz-Signature=fc28086766239201ef09cb66db1671fb121b517d904d4c39f0ef57b01422f286">
The method of interaction with the hotspot depends upon your headset. If you have a controller, the user should be able to point and click the hotspot. The user should also be given visual feedback and confirmation to inform them that the are interacting with it. If you do not have a controller, utilize gaze controls instead to achieve the same functionality.
</li>
<li><strong>Task 3: </strong>Create hotspots to link the rest of the Spheres together as illustrated in task #0. The user should start in the LivingRoom and be able to navigate through all four rooms and view the associated 360 video for each. Keep your Hierarchy in mind as you create new GameObjects and organize them accordingly.
<img src="https://holbertonintranet.s3.amazonaws.com/uploads/medias/2019/2/fe4aed48e640f91b8157.gif?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIARDDGGGOUWMNL5ANN%2F20200818%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20200818T205529Z&X-Amz-Expires=86400&X-Amz-SignedHeaders=host&X-Amz-Signature=33ce35bc264cd4f1155e6751db522ca2f9634ed77cb74fc050ddb66d20392219">
The transition between rooms can cause disorientation and discomfort. Create a transition between rooms so that the current room fades out to black and the destination room fades in from black to ease the user into the scene change.
</li>
<li><strong>Task 4: </strong>In the LivingRoom Sphere, create a Button with the provided image that activates an informational text box when the user interacts with it.
<img src="https://holbertonintranet.s3.amazonaws.com/uploads/medias/2019/2/1c9f1fb933742f20fd11.gif?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIARDDGGGOUWMNL5ANN%2F20200818%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20200818T205529Z&X-Amz-Expires=86400&X-Amz-SignedHeaders=host&X-Amz-Signature=6e2a474a8a33d3d8ed0cf5368d68c8ac4a1d75c13153267411c696640da111a3">
<ul>
<li>The info box should fit within the camera’s field of view (i.e. the user should not have to move their head to see all of the info box)</li>
<li>The text should be of legible size</li>
<li>If the info box is open, clicking on the button should close it and vice versa</li>
<li>You do not have to add the photos in the info box as shown in the demo</li>
</ul>
</li>
<li><strong>Task 5: </strong>Create similar text boxes for the remaining Spheres with the following information.
<img src="https://holbertonintranet.s3.amazonaws.com/uploads/medias/2019/2/6153f15854d50d234f2b.gif?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIARDDGGGOUWMNL5ANN%2F20200818%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20200818T205529Z&X-Amz-Expires=86400&X-Amz-SignedHeaders=host&X-Amz-Signature=eb65b0a03a9b89d36274183abe669f3e00072a94935928f7ec57a22308443fd4">
(Note: You do not have to add the photos in the info box as shown in the demo.)
</li>
<li><strong>Task 6: </strong>Download the audio file “Tech Live” by Kevin MacLeod and import it into the project. Make sure your README.md contains attribution for the audio asset. Add the audio to the project so that it plays throughout the length of the tour and loops if necessary.

Create an Audio Mixer called BGMMixer with a new child group called Music. Apply it to the “Tech Live” audio and lower Music‘s Volume to -10.00dB.</li>
<li><strong>Task 7: </strong>Create a build of the tour in a Builds directory and name it based on your targeted device (ex. 360VideoTour_<TargetHeadsetName> -> 360VideoTour_OculusGo).</li>
</ul>
<p>Credits:
<ul>
<li>Music: <a href="https://incompetech.filmmusic.io/song/4463-tech-live/">Tech Live by Kevin MacLeod</a></li>
</ul>
</p>
</body>
<footer>Project made by: <a href="https://github.com/DanielBaquero28">Daniel Baquero</footer>
</html>