using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositionHandler : MonoBehaviour {

    private Camera m_Camera;                        // Used for referencing the camera.

	private void Awake ()
    {
        m_Camera = GetComponentInChildren<Camera> ();
    }
	// Use this for initialization
	void Start () {
		transform.position = new Vector3(0, 2654, 0);
        transform.rotation = Quaternion.Euler( 90, 90 , 0 );
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(0, 2654, 0);
        transform.rotation = Quaternion.Euler( 90, 90 , 0 );
	}
}


// Take Picture for cube(Package) - 3min
// Picture Setting in Photoshop for AR-Cuboid - 1hr
// Creating 3D model using Autodesk Remake- 1hr50min
// -take pictures 30min
// -pictues upload min-30min(depend on NetSpeed)
// -download 3D min-30min(depend on NetSpeed)
// -up quality of 3D in Maya max-20min

// Creating Transparence 3D Cube - 2min
// Unity AR setting - 3min
// Unity 3D setting - 10min


// ■AR-Transpackageアプリ
// .　Cubeのため写真を取る - 3分
// .　AR-CuboidのためPhotoshopで写真の設定 - 1時間
// .　Transparence 3D Cubeの作成 - 2分
// .　Unity ARの設定 - 3min
// .　Unityの中で3Dの設定 - 10min

// ●　3Dがある場合　
// .　Unity ARの設定 - 3min

// ●3Dがない場合【AutodeskRemakeでモデルを作る。】
// 　.　作りたいモデルの写真を取る。