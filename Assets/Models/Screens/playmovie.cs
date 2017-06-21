using UnityEngine;
using System.Collections;

public class playmovie : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MovieTexture movie = GetComponent<Renderer>().material.mainTexture as MovieTexture;
        movie.Play();
        movie.loop = true;
    }
	
	// Update is called once per frame
	void Update () {


        //    Renderer r = GetComponent<Renderer>();
        //    MovieTexture movie = (MovieTexture)r.material.mainTexture;

        //    if (movie.isPlaying)
        //    {
        //    }
        //    else
        //    {
        //        movie.Play();
        //    }


	}
}
