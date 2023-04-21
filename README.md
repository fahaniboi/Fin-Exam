# Final-Exam
 
Created a Unity Project before the exam to better prepare and imported all shaders that were used during the course. 

Imported a Wall Texture for the Even Scene.

The Wall Texture: https://www.istockphoto.com/photo/white-grunge-old-brick-wall-background-texture-for-home-design-gm625881290-110318577

Implemented the Wall texture to the DiffuseWrap shader that was previously made during lectures and then added the shader to the walls in the scene. The walls are created by using planes along with the floor also being a plane. The diffuseWrap shader was modified a little bit to be able to add shadows on all light source. Did this by changing #pragma surface surf WrapLambert to surface surf Lambert. 

![WallsandFloor](https://user-images.githubusercontent.com/72412425/233694450-72de2c3a-1faf-46f6-ab6d-7f43d7da2fea.png)

Added a Shadow Shader to the Plane thats acting as a floor. This way it has more similarity to the scene. Modified the shader so that it allows me to also place a texture for the object. In this case i added a green floor texture I found on the web. I did this by adding _MainTex in properties and the called it in the fragment shader. 

The Floor Texture: https://www.bigstockphoto.com/image-113641931/stock-photo-horizontal-texture-of-green-tarmac-floor-texture-background

The Floor in Unity: ![Floor](https://user-images.githubusercontent.com/72412425/233708612-4265b1bc-d4ba-492c-899c-cd385e79de8c.png)

Added a toon ramp shader to the Player. The player is created using a capsule. 
Changed the colour to a light green to make the capsule resemble the TNMT turtle.

![Player](https://user-images.githubusercontent.com/72412425/233695312-fac2199d-dc4f-424f-a7de-c48f7791d30f.png)


Implemented a Flowing Lava to the Scene. I did this by using the WaterShader that we made during class and added a Lava texture that I got from the web. This allows me to have a flowing lava shader.

The Lava texture: https://www.google.com/url?sa=i&url=https%3A%2F%2Funsplash.com%2Fs%2Fphotos%2Flava-texture&psig=AOvVaw1cv2_bf0-NAbIVwZx02NGo&ust=1682183632126000&source=images&cd=vfe&ved=0CBEQjRxqFwoTCNDFy8W8u_4CFQAAAAAdAAAAABAI

How it looks like in the Scene:

![Lava](https://user-images.githubusercontent.com/72412425/233697858-bc0d96cd-5978-4016-b04b-2e843bb6f41a.png)


Added Movement script to the Player to allow the user to control the capsue using WASD. Did this by using a c# script. The script takes in a gameObject, in this case the floor, and takes a speed float as well as a vector3 that is used to normalize the floor. In the Update function I added two floats , one for each GetAxis (Horizontal, and Vertical). Then we make sure the movementDir Vector3 has horizontal and vertical input and then finally we add the classic transform.position += movementDir * speed * Time.deltatime. This makes us move at the specified speed by updating the transform.position of the object by the multiplactions of movementDir, speed, and deltaTime. 

Added Bloom using c# script and Bloom Shader. The C# script for Bloom allows us to modify the Intensity, Threshold, and Iterations. 
