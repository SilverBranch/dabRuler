using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoom : MonoBehaviour
{
    public Texture[] textures;
    public float changeInterval = 0.33F;
    public Renderer rend;
    public int spinSpeed = 1;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        harlemShake();
        spin();
    }

    void harlemShake()
    {
        if (textures.Length == 0)
            return;

        int index = Mathf.FloorToInt(Time.time / changeInterval);
        index = index % textures.Length;
        rend.material.mainTexture = textures[index];
    }

    void spin()
    {
        transform.Rotate(spinSpeed, spinSpeed, spinSpeed * Time.deltaTime, Space.Self);
        transform.localScale += new Vector3(0.05F, 0, 0);
    }
}
