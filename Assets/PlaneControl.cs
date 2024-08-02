using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class PlaneControl : MonoBehaviour
{
    public ARPlaneManager planeManager;

    public Material redMaterial;
    public Material greenMaterial;
    public Material purpleMaterial;

    public Button redButton;
    public Button greenButton;
    public Button purpleButton;
    public GameObject Sphere;

    public Text TextMesh;

    private MeshRenderer currentObj;

    private void Start()
    {
        redButton.onClick.AddListener(UpdateRed);
        greenButton.onClick.AddListener(UpdateGreen);
        purpleButton.onClick.AddListener(UpdatePurple);
    }

    private bool isRunning = false;

    public void Update()
    {
        if (!planeManager.isActiveAndEnabled && !isRunning)
        {
            Debug.Log("[Test]-> Plane Disable , this runs once ");

            Transform posValue = GameObject.FindGameObjectWithTag("pos").transform;
            GameObject obj = Instantiate(Sphere, posValue.position, Quaternion.identity);
            
            if(obj != null)
            {
                TextMesh.text = "Found GameObject";
                currentObj = obj.GetComponent<MeshRenderer>();
            }
            isRunning = true;
        }
    }

    public void UpdateTouches()
    {
        
    }

    private void UpdateRed()
    {
        if(currentObj != null)
        {
            TextMesh.text = "Red Button Pressed";
            currentObj.material = redMaterial;
            
        }
    }

    private void UpdateGreen()
    {
        if(currentObj != null)
        {
            TextMesh.text = "Green Button Pressed";
            currentObj.material = greenMaterial;
        }
    }

    private void UpdatePurple()
    {
        if(currentObj != null)
        {
            TextMesh.text = "Purple Button Pressed";
            currentObj.material = purpleMaterial;
        }
    }

    private void OnDisable()
    {
        redButton.onClick.RemoveListener(UpdateRed);
        greenButton.onClick.RemoveListener(UpdateGreen);
        purpleButton.onClick.RemoveListener(UpdatePurple);
    }
}
