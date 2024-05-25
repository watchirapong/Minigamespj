using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IClickable
{   
    //interface ประกาศได้แค่ method
    // public int hi = 1;
    void Interact();
    void Clickcount(int count);
}
