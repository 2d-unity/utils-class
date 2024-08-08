using UnityEngine;

public static class UtilsClass {

    private static Camera mainCamera;
    public static Vector3 getMouseWorldPosition() {
        if(mainCamera == null) {
            mainCamera = Camera.main;
        }
        Vector3 v = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        v.z = 0f;
        // Debug.Log(v);
        return v;
    }
}