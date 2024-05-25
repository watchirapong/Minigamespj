using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    void Interact();   
    
    void Clickcount(int count);
    //เมื่อประกาศmethod class ที่นำไปใช้ ต้องใช้ทุก method
}
