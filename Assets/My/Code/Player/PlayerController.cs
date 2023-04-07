using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public Mech Mech { get; set; }
     public void SetMech(Mech mech) {
         Mech = mech;
    }
}
