# 428.P1.HareshJhaveri
# This project runs on Unity version 2021.3.6f1 found in the unity download archive (https://unity3d.com/get-unity/download/archive), 
# find the version you want and click on the "Unity Hub" button to download it on Unity Hub which can be downloaded at (https://unity3d.com/get-unity/download) and clicking the "Download Unity Hub" button
# NOTE: You will need to sign up for a Unity account which is free to do
# Then, download the project from this repository (any way works as long as you can assess it, would recommend downloading as ZIP and extracting the files)
# On Unity Hub, click on the arrow next to the "Open" button and click on "Add project on disk". From there, click on the extracted folder containing the project and click on "add project"
# Before opening the project, you will need to register for a free Vuforia account at developer.vuforia.com, then download version 10.9 of vuforia sdk on developer.vuforia.com/ (If you can't find 10.9, version 10.10 will probably work)
# Now, when you open the project, you will probably get some pop ups saying there are errors, click "continue" and in the second popup, hit "ignore", the project will open
# For your project to be able to run, you will want to go to the assets tab, go to "Import Package" and click on "Custom Package". Now go to the file downloaded earlier and open it (give it permission to update).
# Save, restart the project and there should be no more errors. Just make sure you go to the Scenes folder and open the scene in there to properly run the project. You may need to move around to get closer to the object since they are very small.
# NOTE: The yacht will probably look black, I tried to set the textures to a material so that it rendered properly but I couldn't get it to work so don't worry about it
# It should work just fine if you run it normally, but if you want it to run on an Android phone, go to File -> Build Settings
# From there, click on Android and then click on the Switch Platform button.
# Before building, click the Player Settings button while still on this Build Settings window, go to Android if not there and go to other settings
# First set the Minimum API Level to "Android 8.0 'Oreo' (API Level 26)", and the Target API Level to "Automatic (highest installed)"
# Then, if your Scripting Backend is "Mono", change it to "IL2CCP" and in the Target Architectures section, uncheck ARM7 and check ARM64.
# Now, you will want to connect your Android phone to your computer using the appropriate cable
# On the phone go to Settings, select Developer options, and then enable USB debugging. 
# If you don't see developer options, go to Settings > About Phone > Build Number and tap the "Build Number" option 7 times to enable developer options. 
# Once developer options are enabled, turn on USB debugging. Then build and run the project in Build Settings (it may ask to save a copy of the apk, just save it on your computer somewhere outside of the project folder)
# NOTE: I have not yet tested this on an iOS phone so I cannot say for sure what setup will work
