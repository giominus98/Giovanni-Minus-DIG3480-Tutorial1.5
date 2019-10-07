using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public AudioSource MusicSource;
    public AudioClip MusicClipOne;
    public AudioClip MusicClipTwo;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            MusicSource.clip = MusicClipOne;
            MusicSource.Play();
            anim.SetInteger("State", 1);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            MusicSource.Stop();
            anim.SetInteger("State", 0);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            MusicSource.clip = MusicClipTwo;
            MusicSource.Play();
            anim.SetInteger("State", 2);
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            MusicSource.Stop();
            anim.SetInteger("State", 0);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            MusicSource.loop = true;
        }

        if (Input.GetKeyUp(KeyCode.L))
        {
            MusicSource.loop = false;
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
