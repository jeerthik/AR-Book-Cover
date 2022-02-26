# AR-Book-Cover
*Created by: Jeerthi Kannan*

*Class: CS 8395-01 Spring 22*

This repository contains code that is used to create an augmented reality book cover, which has augmented text and images.
***

The Vuforia Engine SDK in Unity was used to create AR front and back book covers for The Hunger Games book. 

The front cover displays the title and author in augmented text over a black background to mask the original cover. On top of the background are 2 3D character models representing the main characters in the book: Katniss Everdeen (character with the bow and arrow), and Peeta Mellark (character sitting down). Behind them and in front of the title is a fire effect, which was placed to represent the underlying theme of The Hunger Games series.

The back cover displays the book's relevant information. A virtual button is added on the back cover to toggle between the book's relevant information and a short review. To trigger the virtual button, place your finger or hand on top of the bottom middle section of the book.

Images of the original front and back covers of the book are stored in the **Media** folder.

## Tutorials Used
1. Create image targets, following the first method using the Vuforia Developer Portal (https://www.youtube.com/watch?v=Z4bBMpa4xWo)
2. Make a virtual button (https://www.youtube.com/watch?v=Ckw4RKKVE3k)
3. Add augmented text to an image target (https://www.youtube.com/watch?v=uyweJ9lPD90)
4. Use Adobe Mixamo to make 3D animated character models (https://www.youtube.com/watch?v=xxM6D6coDAU)

### The following files are stored using GitHub LFS (Large File Storage), as these files were too large to store in this repository without it:
- `Packages/com.ptc.vuforia.engine-10.5.5.tgz`
- `Packages/HGBookCover`

To retrieve these files when cloning, make sure to have GitHub Large File Storage installed, by running `git lfs install`

## How to Run (Two ways)
**Preliminary Steps**
1. Download this GitHub repository by running `git clone https://github.com/jeerthik/AR-Book-Cover.git` on command line.
2. Download Unity Hub (https://unity3d.com/get-unity/download), create a Unity Hub account, and open Unity Hub.
3. Within Unity Hub, install the latest version of Unity Editor. Within the Add Modules screen, add relevant modules for your OS. I added Android Build Support, Android SDK & NDK Tools, OpenJDK, Universal Windows Platform Build Support, and Windows Build Support.
4. (Optional) Create a Vuforia Developer Account and download the latest release of Vuforia as a unitypackage (https://developer.vuforia.com/downloads/sdk). Otherwise, you can stick with the version of the Vuforia package that comes with this repository.

**First Method: Use GitHub Repo as Project**
1. Within Unity Hub, go to Projects and click Open. Then select the folder to which you cloned this GitHub repository.
2. Now all the relevant resources are imported into a project. Click the 'Play' icon at the top of the screen to test.
3. Hold up the book or images of the front and back cover to see the AR objects.

**Second Method: Use UnityPackage within GitHub Repo**
1. Open a new 3D Project in Unity Hub
2. After everything is loaded, at the top, click Assets -> Import Package
3. Locate the HGBookCover package within the Packages folder and select it to import.
4. Now all the relevant assets are imported. Make sure to delete the Main Camera if present in the SampleScene.
5. Click the 'Play' icon at the top of the screen to test.
6. Hold up the book or images of the front and back cover to see the AR objects.

## Limitations
1. The back cover is not as easily detected by the AR Camera as the front. Hence, it may take some moving around and calibration of the back cover in position with the camera, in order to trigger the AR back cover to appear. 
2. Depending on the angle the image is held, the AR objects may seem to be floating on top of the book or in the air. This may be related with how the objects are anchored.
3. The virtual button is triggered only when continuously pressed. Otherwise, the effect of a previous depress does not carry over when you take your hand away.
