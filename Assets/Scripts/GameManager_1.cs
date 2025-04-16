using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_1 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cube;
    public GameObject light;
    public MeshRenderer ground;

    //public Color lightcolor;

    void Start()
    {
        //cube.SetActive(false);

        //Instantiate(cube);
        //Destroy(cube);

        //cube.GetComponent<Rigidbody>().mass = 1000;
        //cube.GetComponent<Rigidbody>().useGravity = false;
        //

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CubeON()
    { 
        cube.SetActive(true);
    }

    public void CubeOff()
    {
        cube.SetActive(false);
    }

    public void GroundColor()
    {
        ground.material.color = Color.green;
    }

    public void LightColor()
    {
        light.GetComponent<Light>().color = new Color(255, 0, 0);
    }
}
