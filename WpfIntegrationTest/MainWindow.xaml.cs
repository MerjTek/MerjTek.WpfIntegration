#region Using Statements

using System;
using System.Windows;
using System.Diagnostics;
using Primitives3D;
using Microsoft.Xna.Framework;

#endregion

namespace WpfIntegrationTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CubePrimitive cube;

        // We use a Stopwatch to track our total time for cube animation
        private Stopwatch watch = new Stopwatch();

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Control Loaded

        private void MonoGameControl_Loaded(object sender, MerjTek.WpfIntegration.GraphicsDeviceEventArgs e)
        {
            // Because this same event is hooked for all 4 controls, we check if the Stopwatch
            // is running to avoid loading our content 4 times.
            if (!watch.IsRunning)
            {
                // Create our 3D cube object
                cube = new CubePrimitive(e.GraphicsDevice);

                // Start the watch now that we're going to be starting our draw loop
                watch.Start();
            }
        }

        #endregion
        #region Render Red Control

        private void Red_Render(object sender, MerjTek.WpfIntegration.GraphicsDeviceEventArgs e)
        {
            e.GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.CornflowerBlue);

            // Compute some values for the cube rotation
            float time = (float)watch.Elapsed.TotalSeconds;
            float yaw = time * 0.4f;
            float pitch = time * 0.7f;
            float roll = time * 1.1f;

            // Create the world-view-projection matrices for the cube and camera
            Microsoft.Xna.Framework.Matrix world = Microsoft.Xna.Framework.Matrix.CreateFromYawPitchRoll(yaw, pitch, roll);
            Microsoft.Xna.Framework.Matrix view = Microsoft.Xna.Framework.Matrix.CreateLookAt(new Vector3(0, 0, 2.5f), Vector3.Zero, Vector3.Up);
            Microsoft.Xna.Framework.Matrix projection = Microsoft.Xna.Framework.Matrix.CreatePerspectiveFieldOfView(1, e.GraphicsDevice.Viewport.AspectRatio, 1, 10);

            // Draw a cube
            Microsoft.Xna.Framework.Color color = Microsoft.Xna.Framework.Color.Green;
            cube.Draw(world, view, projection, color);
        }

        #endregion
        #region Render Yellow Control

        private void Yellow_Render(object sender, MerjTek.WpfIntegration.GraphicsDeviceEventArgs e)
        {
            e.GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.CornflowerBlue);

            // Compute some values for the cube rotation
            float time = (float)watch.Elapsed.TotalSeconds;
            float yaw = time * 0.4f;
            float pitch = time * 0.7f;
            float roll = time * 1.1f;

            // Create the world-view-projection matrices for the cube and camera
            Microsoft.Xna.Framework.Matrix world = Microsoft.Xna.Framework.Matrix.CreateFromYawPitchRoll(yaw, pitch, roll);
            Microsoft.Xna.Framework.Matrix view = Microsoft.Xna.Framework.Matrix.CreateLookAt(new Vector3(0, 0, 2.5f), Vector3.Zero, Vector3.Up);
            Microsoft.Xna.Framework.Matrix projection = Microsoft.Xna.Framework.Matrix.CreatePerspectiveFieldOfView(1, e.GraphicsDevice.Viewport.AspectRatio, 1, 10);

            // Draw a cube
            Microsoft.Xna.Framework.Color color = Microsoft.Xna.Framework.Color.Blue;
            cube.Draw(world, view, projection, color);
        }

        #endregion
        #region Render Blue Control

        private void Blue_Render(object sender, MerjTek.WpfIntegration.GraphicsDeviceEventArgs e)
        {
            e.GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.CornflowerBlue);

            // Compute some values for the cube rotation
            float time = (float)watch.Elapsed.TotalSeconds;
            float yaw = time * 0.4f;
            float pitch = time * 0.7f;
            float roll = time * 1.1f;

            // Create the world-view-projection matrices for the cube and camera
            Microsoft.Xna.Framework.Matrix world = Microsoft.Xna.Framework.Matrix.CreateFromYawPitchRoll(yaw, pitch, roll);
            Microsoft.Xna.Framework.Matrix view = Microsoft.Xna.Framework.Matrix.CreateLookAt(new Vector3(0, 0, 2.5f), Vector3.Zero, Vector3.Up);
            Microsoft.Xna.Framework.Matrix projection = Microsoft.Xna.Framework.Matrix.CreatePerspectiveFieldOfView(1, e.GraphicsDevice.Viewport.AspectRatio, 1, 10);

            // Draw a cube
            Microsoft.Xna.Framework.Color color = Microsoft.Xna.Framework.Color.Yellow;
            cube.Draw(world, view, projection, color);
        }

        #endregion
        #region Render Green Control

        private void Green_Render(object sender, MerjTek.WpfIntegration.GraphicsDeviceEventArgs e)
        {
            e.GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.CornflowerBlue);

            // Compute some values for the cube rotation
            float time = (float)watch.Elapsed.TotalSeconds;
            float yaw = time * 0.4f;
            float pitch = time * 0.7f;
            float roll = time * 1.1f;

            // Create the world-view-projection matrices for the cube and camera
            Microsoft.Xna.Framework.Matrix world = Microsoft.Xna.Framework.Matrix.CreateFromYawPitchRoll(yaw, pitch, roll);
            Microsoft.Xna.Framework.Matrix view = Microsoft.Xna.Framework.Matrix.CreateLookAt(new Vector3(0, 0, 2.5f), Vector3.Zero, Vector3.Up);
            Microsoft.Xna.Framework.Matrix projection = Microsoft.Xna.Framework.Matrix.CreatePerspectiveFieldOfView(1, e.GraphicsDevice.Viewport.AspectRatio, 1, 10);

            // Draw a cube
            Microsoft.Xna.Framework.Color color = Microsoft.Xna.Framework.Color.Red;
            cube.Draw(world, view, projection, color);
        }

        #endregion
    }
}
