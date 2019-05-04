using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

[RequireComponent(typeof(AudioSource))]
public class scriptButton : MonoBehaviour
{
    private static int x = 0;
    private static int y = 0;
    private static int z = 0;

    private static int xx;
    private static int yy;
    private static int zz;

    private static AudioClip clip;
    private static AudioSource source;


    public GameObject canvasToDisable;

    
    public void SetBackground()
    {
        Text txt = transform.Find("Text").GetComponent<Text>();
        xx = x;
        yy = y;
        zz = z;

        GameObject image = GameObject.Find("HelpImage");
        if(image != null)
            image.SetActive(false);

        if (source == null)
            source = gameObject.AddComponent<AudioSource>();
        if(clip == null)
            clip = (AudioClip)AssetDatabase.LoadAssetAtPath("Assets/Resources/music/music.mp3", typeof(AudioClip));

        if (txt.text == "0")
        {
            z = -1;
        }
        else if (txt.text == "1")
        {
            z = 0;
        }
        else if (txt.text == "2")
        {
            z = 1;
        }
        else if (txt.text == "3")
        {
            z = 2;
        }
        else if (txt.text == "4")
        {
            z = 3;
        }
        else if (txt.text == "x+")
        {
            x++;
        }
        else if (txt.text == "x-")
        {
            x--;
        }
        else if (txt.text == "y-")
        {
            y--;
        }
        else if (txt.text == "y+")
        {
            y++;
        }

        if ((x == 4 && y == 1) || (x == 15 && y == 1))
        {   
            //play music
            if (clip != null && !source.isPlaying)
            {
                source.PlayOneShot(clip, 0.7F);
            }
            else
            {
                Debug.Log("Attempted to play missing audio clip");
            }

            //afficher boutons
            canvasToDisable.SetActive(true);
            print("On est dans l ascenseur");
        }
        else
        {
            //cacher boutons
            canvasToDisable.SetActive(false);
            //stop music
            if (clip != null)
                source.Stop();
        }



        Material material = (Material)AssetDatabase.LoadAssetAtPath("Assets/materials/" + x + "-" + y + "-" + z + ".mat", typeof(Material));

        if (material != null)
        {
            RenderSettings.skybox = material;
        }

        else
        {
            x = xx;
            y = yy;
            z = zz;
        }
      
    }


    // Update is called once per frame
    void Update()
    {
        
    }

}
