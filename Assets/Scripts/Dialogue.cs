using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]//permet la réutilisation dans d'autres scripts. 
public class Dialogue
{
    public string name;

    [TextArea(3, 10)]
    public string[] sentences; //en liste pour les afficher les unes à la suite des autres. 
}
