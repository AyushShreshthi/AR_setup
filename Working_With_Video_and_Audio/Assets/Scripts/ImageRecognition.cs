using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;


public class ImageRecognition : MonoBehaviour
{
    private ARTrackedImageManager _arTrackedImagemanager;

    private void Awake()
    {
        _arTrackedImagemanager = FindObjectOfType<ARTrackedImageManager>();
    }

    public void OnEnable()
    {
        _arTrackedImagemanager.trackedImagesChanged += OnImageChanged;
    }
    private void OnDisable()
    {
        _arTrackedImagemanager.trackedImagesChanged -= OnImageChanged;

    }
    private void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var trackedImage in args.added)
        {
            Debug.Log(trackedImage.name);
        }
    }
}
