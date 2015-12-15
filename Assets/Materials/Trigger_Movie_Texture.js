var movieFile : MovieTexture;
 
function OnTriggerEnter (col : Collider) {
    //This gets called when the player hits the movie plane
    if (col.gameObject.name.StartsWith("Player")) { //Check that we are dealing with the player.
        GetComponent.<Renderer>().material.mainTexture = movieFile; // Assign the movie to the renderer.
        movieFile.Play(); //Play the movie on the plane
    }
}
