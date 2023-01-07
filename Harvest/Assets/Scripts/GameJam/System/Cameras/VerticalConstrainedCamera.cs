using UnityEngine;

namespace GameJam.System.Cameras
{
    [RequireComponent(typeof(Camera))]
    public class VerticalConstrainedCamera : MonoBehaviour
    {
        private const float SCREEN_WIDTH = 768;
        private const float SCREEN_HEIGHT = 1024;
        
        private Camera _camera;
        
        void Start()
        {
            _camera = GetComponent<Camera>();
            
            var verticalConstrainedSize = SCREEN_HEIGHT * 0.5f;
            Camera.main.orthographicSize = verticalConstrainedSize;
        }
    }
}
