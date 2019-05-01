// -----------------------------------------------------------------------------
#region File Info - CountObjectsActivator.cs
// -----------------------------------------------------------------------------
// Project:     Dino Unity Toolkit
// Created:     Sarah Herzog 2019
// Purpose:     Perform actions based on number of active objects in scene
// -----------------------------------------------------------------------------
#endregion
// -----------------------------------------------------------------------------


// -----------------------------------------------------------------------------
#region Libraries
// -----------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.Events;
// -----------------------------------------------------------------------------
#endregion
// -----------------------------------------------------------------------------


// -----------------------------------------------------------------------------
#region Component: CountObjectsActivator
// -----------------------------------------------------------------------------
[HelpURL("https://github.com/CodingDino/FifeCollege-Unity-DragNDrop/wiki/CountObjectsActivator")]
public class CountObjectsActivator : MonoBehaviour
{


    // -------------------------------------------------------------------------
    #region Editor Variables
    // -------------------------------------------------------------------------
    [Tooltip("Tag to search for.")]
    public string tagName = "";
    [Tooltip("Tag to search for.")]
    public int numToMatch = 0;
    [Tooltip("Perform these actions when the object count matches the conditions.")]
    public UnityEvent onObjectCountMatch;
    // -------------------------------------------------------------------------
    #endregion
    // -------------------------------------------------------------------------


    // -------------------------------------------------------------------------
    #region Unity Functions
    // -------------------------------------------------------------------------
    private void Update()
    {
        GameObject[] taggedObjectArray = GameObject.FindGameObjectsWithTag(tagName);
        if (taggedObjectArray.Length == numToMatch)
        {
            onObjectCountMatch.Invoke();
        }
    }
    // -------------------------------------------------------------------------
    #endregion
    // -------------------------------------------------------------------------
}
// -----------------------------------------------------------------------------
#endregion
// -----------------------------------------------------------------------------