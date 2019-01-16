using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour {

	public void changeScene(string name)
    {
#pragma warning disable CS0618 // Le type ou le membre est obsolète
        Application.LoadLevel(name);
#pragma warning restore CS0618 // Le type ou le membre est obsolète
        Debug.Log("Hello WORLD  ", gameObject);
    }

    public void openUrl()
    {
        Application.OpenURL("https://www.futbin.com/");
    }
}
