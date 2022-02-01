using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ragdollcontroller : MonoBehaviour
{
    public bool lol = true;
    private Rigidbody[] rigidbodies;
    private Collider[] colliders;
    // Start is called before the first frame update
  private void Awake() 
  {
      rigidbodies = GetComponentsInChildren<Rigidbody>();
      colliders = GetComponentsInChildren<Collider>();
      
  }
  private void Update() 
  {
      if(lol == true)
      {
          SetrigidbodiesKinematic(true);
      }
      else if(lol == false)
      {
          SetrigidbodiesKinematic(false);
      }
  }
  private void setCollidersEnabled(bool enabled)
  {
      foreach(Collider col in colliders)
      {
          col.enabled = enabled;
      }
  }
  public void SetrigidbodiesKinematic(bool kinematic)
  {
      foreach(Rigidbody rb in rigidbodies)
      {
          rb.isKinematic = kinematic;
      }
  }
}
