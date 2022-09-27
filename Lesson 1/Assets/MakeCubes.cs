using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;


public class MakeCubes : MonoBehaviour
{
    public Text inp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnterBtn()
    {
        CubeGen();
    }
    [SerializeField] private GameObject cube;
    [SerializeField] private GameObject sphere;

    public void CubeGen()
    {
        var text = inp.text;
        if (text == "") return;
        for (var i = 0; i < int.Parse(text); i++) Instantiate(cube, sphere.transform.position, Quaternion.identity);
    }
}