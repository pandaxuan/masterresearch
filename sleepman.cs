using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Examples;
using System.IO;
using System.Text;

public class sleepman : MonoBehaviour {
    private Animator anim;
    private double t, t1;
    private int t2;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        t2 = slide.interaction;
    }

    // Update is called once per frame
    void Update() {
        t = Time.timeSinceLevelLoad;
        t1 = slide.scoree0 + 30;
        if (slide.scoree0 > 0 && t < t1)
        {
            anim.SetBool("sleep", true);
            if(ExampleInteractiveItem.collidename == "Male1" && slide.interaction == t2)
            {
                Debug.Log("sleeppppppppppp");
                slide.interaction++;
                StreamWriter sw = new StreamWriter("../test2222222/Assets/Resources/LogData5.csv", true);
                StringBuilder sb = new StringBuilder();
                sb.Append(slide.interaction).Append(',').Append(this.gameObject.name);
                sw.WriteLine(sb);
                sw.Flush();
                sw.Close();
            }
        }
        else
        {
            anim.SetBool("sleep", false);
        }
	}
}
