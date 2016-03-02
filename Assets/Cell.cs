using UnityEngine;
using System.Collections;

public class Cell : MonoBehaviour {

    [HideInInspector] public int columnIndex = -1;
    [HideInInspector] public int rowIndex = -1;

    [HideInInspector] public bool forcedInvalid = false;
    [HideInInspector] public bool isValid { get { return (columnIndex > -1 && rowIndex > -1 && forcedInvalid == false); } }
}
