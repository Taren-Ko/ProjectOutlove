using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour
{
    public float backgroundSize;
    public float parallaxSpeed;

    private Transform cameraTransform;
    private Transform[] layers;
    private float viewzone = 10;
    private int leftIndex;
    private int rightIndex;
    private float lastCameraX;

    private void Start(){

        cameraTransform = Camera.main.transform;
        lastCameraX = cameraTransform.position.x;
        layers = new Transform[transform.childCount];
        for(int i=0; i<transform.childCount; i++){
            layers[i] = transform.GetChild(i);
        }
        leftIndex=0;
        rightIndex = layers.Length-1;
    }

    private void Update(){
        cameraTransform = Camera.main.transform;
        float deltaX = cameraTransform.position.x - lastCameraX;
        transform.position += Vector3.right * (deltaX * parallaxSpeed);
        lastCameraX = cameraTransform.position.x;

        if(cameraTransform.position.x < (layers[leftIndex].transform.position.x + viewzone)){
            ScrollLeft();
        }
        if (cameraTransform.position.x > (layers[rightIndex].transform.position.x - viewzone))
        {
            ScrollRight();
        }
    }

    private void ScrollLeft(){
        int lastRight = rightIndex;
        layers[rightIndex].position = Vector3.right * (layers[leftIndex].position.x - backgroundSize);
        leftIndex = rightIndex;
        rightIndex--;
        if (rightIndex < 0)
        {
            rightIndex = layers.Length-1;
        }
    }

    private void ScrollRight(){
        int lastLeft = leftIndex;
        layers[leftIndex].position = Vector3.right * (layers[rightIndex].position.x + backgroundSize);
        rightIndex = leftIndex;
        leftIndex++;
        if(leftIndex == layers.Length){
            leftIndex = 0;
        }
    }
}