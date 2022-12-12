using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondCutscene : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("Legend of the museum", LoadSceneMode.Single);
    }
}
