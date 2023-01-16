using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Array2dimensionalExample : MonoBehaviour{
    public string[,] newArray;
    void Start() {
        newArray = new string[4, 4];
        newArray[0, 1] = "X";
        newArray[0, 2] = "W";
        newArray[1, 1] = "Z";
        newArray[3, 2] = "Y";

        string str = "";
        for (int a = 0; a < 4; a++){
            for (int b = 0; b < 4; b++){
                if (newArray[a, b] != null){
                    str += "||" + newArray[a, b];
                }
                else{
                    str += "||--";
                }
            }
            str += "||" + "\n";
        }
        print(str);
    }
}
