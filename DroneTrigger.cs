using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneTrigger : MonoBehaviour {

    public Animator TargetAnimator = null;
    public string TriggerName = string.Empty;

    public void OnTriggerEnter(Collider Col)
    {
        TargetAnimator.SetTrigger(TriggerName);
    }

    public void OnTriggerExit(Collider other)
    {
        TargetAnimator.ResetTrigger(TriggerName);
    }

}
