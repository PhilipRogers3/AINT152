using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndTrigger : MonoBehaviour
{
    [SerializeField]private string loadlevel;

    void onTriggerEnter(Collider col)
    {
        
        if (col.CompareTag ("Player"))
        {
            SceneManager.LoadScene(loadlevel);
        }
        
    }
}
