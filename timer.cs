using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class timer : MonoBehaviour {
    public Text timeLabel;
    private float time = 839.0f;
    public GameObject obj;
    SteamVR_TrackedObject trackedObj;
    // Use this for initialization

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        time -= Time.deltaTime;
        var minutes = time / 60;
        var seconds = time % 60;
        var fraction = (time * 100) % 100;

        timeLabel.text = string.Format("{0:00} : {1:00} : {2:000}", minutes, seconds, fraction);

	}
}
