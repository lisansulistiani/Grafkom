using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Input;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Graf_Tubes_1572001_1572010
{
    class MyGLWindows : GameWindow
    {
        float x, y, z;
        Vector3 triPos;
        float angle = 0;
        public MyGLWindows(int panjang,int lebar) : base(panjang,lebar)
        {
            Title = "Tubes Grafkom | 1572001 / 1572010";
            x = 0;
            y = 0;
            z = 3;
            triPos = new Vector3(0, 1, 0);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Enable(EnableCap.DepthTest);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.ClearColor(Color.SkyBlue);
            

            Matrix4 projection, view;
            projection = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, this.Width / this.Height, 0.1f, 100);
            view = Matrix4.LookAt(
                new Vector3(x, y, z),
                new Vector3(0, 0, 0),
                new Vector3(0,1,0));
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
            //GL.MatrixMode(MatrixMode.Modelview);
            //GL.LoadMatrix(ref view);

            Matrix4 modelView, model, model2;
            model = Matrix4.CreateTranslation(new Vector3(0.6f, 0, 0));
            
            model2 = Matrix4.CreateRotationY(angle);

            modelView = Matrix4.Mult(view, model);
            modelView = Matrix4.Mult(model2, modelView);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelView);


            GL.Begin(PrimitiveType.Triangles);

            //GL.Color3(Color.Yellow);
            //GL.Vertex3(new Vector3(0.2f, -0.2f, -0.2f));
            //GL.Vertex3(new Vector3(0.2f, -0.2f, 0.2f));
            //GL.Vertex3(new Vector3(-0.2f, -0.2f, 0.2f));

            //GL.Color3(Color.Yellow);
            //GL.Vertex3(new Vector3(-0.2f, -0.2f, 0.2f));
            //GL.Vertex3(new Vector3(-0.2f, -0.2f, -0.2f));
            //GL.Vertex3(new Vector3(0.2f, -0.2f, -0.2f));

            GL.Color3(Color.Black);
            GL.Vertex3(new Vector3(0.2f, -0.2f, -0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(0, 0, 0));

            GL.Color3(Color.Blue);
            GL.Vertex3(new Vector3(0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(0, 0, 0));

            GL.Color3(Color.Red);
            GL.Vertex3(new Vector3(-0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.2f, -0.2f));
            GL.Vertex3(new Vector3(0, 0, 0));

            GL.Color3(Color.White);
            GL.Vertex3(new Vector3(-0.2f, -0.2f, -0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.2f, -0.2f));
            GL.Vertex3(new Vector3(0, 0, 0));

            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Color3(Color.Yellow);
            GL.Vertex3(new Vector3(0.2f, -0.2f, -0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.2f, -0.2f));
            GL.End();


            //balok
            //alas
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(Color.Pink);
            GL.Vertex3(new Vector3(0.2f, -0.8f, -0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.8f, 0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.8f, 0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.8f, -0.2f));
            GL.End();

            //samping kanan 
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(Color.Cornsilk);
            GL.Vertex3(new Vector3(0.2f, -0.2f, -0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.8f, 0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.8f, -0.2f));
            GL.End();

            //samping kiri 
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(Color.DarkMagenta);
            GL.Vertex3(new Vector3(-0.2f, -0.2f, -0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.8f, 0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.8f, -0.2f));
            GL.End();

            //depan
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(Color.DarkKhaki);
            GL.Vertex3(new Vector3(-0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.8f, 0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.8f, 0.2f));
            GL.End();

            //belakang
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(Color.Black);
            GL.Vertex3(new Vector3(-0.2f, -0.2f, -0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.2f, -0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.8f, -0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.8f, -0.2f));
            GL.End();

            //sayap kanan
            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(Color.Aqua);
            GL.Vertex3(new Vector3(0, -0.3f, -0.1f));
            GL.Vertex3(new Vector3(0.6f, -0.5f, -0.1f));
            GL.Vertex3(new Vector3(0, -0.7f, -0.1f));
            GL.End();

            //sayap kiri
            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(Color.Aqua);
            GL.Vertex3(new Vector3(0, -0.3f, -0.1f));
            GL.Vertex3(new Vector3(-0.6f, -0.5f, -0.1f));
            GL.Vertex3(new Vector3(0, -0.7f, -0.1f));
            GL.End();

            //sayap tengah
            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(Color.Yellow);
            GL.Vertex3(new Vector3(0, -0.5f, -0.2f));
            GL.Vertex3(new Vector3(0, -0.7f, 0.35f));
            GL.Vertex3(new Vector3(0, -0.7f, -0.2f));
            GL.End();

            //peluru
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(Color.Sienna);
            GL.Vertex3(new Vector3(-0.02f, -0.2f, 0));
            GL.Vertex3(new Vector3(0.02f, -0.2f, 0));
            GL.Vertex3(new Vector3(0.02f, 0.1f, 0));
            GL.Vertex3(new Vector3(-0.02f, 0.1f, 0));
            GL.End();

            //objek yg ditembak
            model = Matrix4.CreateTranslation(new Vector3(0.6f, 0.5f, 0));

            model2 = Matrix4.CreateScale(0.2f);

            modelView = Matrix4.Mult(view, model);
            modelView = Matrix4.Mult(model2, modelView);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelView);
            sasaran();

            SwapBuffers();
        }

        public void sasaran()
        {
            GL.Begin(PrimitiveType.Quads);

            //depan
            GL.Color3(Color.Red);
            GL.Vertex3(new Vector3(-0.2f, 0.2f, 0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(0.2f, 0.2f, 0.2f));

            //belakang
            GL.Color3(Color.Orange);
            GL.Vertex3(new Vector3(0.2f, 0.2f, -0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.2f, -0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.2f, -0.2f));
            GL.Vertex3(new Vector3(-0.2f, 0.2f, -0.2f));

            //kiri
            GL.Color3(Color.Green);
            GL.Vertex3(new Vector3(-0.2f, 0.2f, -0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.2f, -0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(-0.2f, 0.2f, 0.2f));

            //kanan
            GL.Color3(Color.Blue);
            GL.Vertex3(new Vector3(0.2f, 0.2f, 0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.2f, -0.2f));
            GL.Vertex3(new Vector3(0.2f, 0.2f, -0.2f));

            //atas
            GL.Color3(Color.Purple);
            GL.Vertex3(new Vector3(-0.2f, 0.2f, -0.2f));
            GL.Vertex3(new Vector3(-0.2f, 0.2f, 0.2f));
            GL.Vertex3(new Vector3(0.2f, 0.2f, 0.2f));
            GL.Vertex3(new Vector3(0.2f, 0.2f, -0.2f));

            //bawah
            GL.Color3(Color.Yellow);
            GL.Vertex3(new Vector3(0.2f, -0.2f, -0.2f));
            GL.Vertex3(new Vector3(0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.2f, 0.2f));
            GL.Vertex3(new Vector3(-0.2f, -0.2f, -0.2f));

            GL.End();
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            if (Keyboard[Key.W])
            {
                angle += 0.05f;
                //z -= 0.1F;
            }
            if (Keyboard[Key.S])
            {
                z += 0.1F;
            }
            if (Keyboard[Key.A])
            {
                x += 0.1F;
            }
            if (Keyboard[Key.D])
            {
                x -= 0.1F;
            }
            if (Keyboard[Key.E])
            {
                y += 0.1F;
            }
            if (Keyboard[Key.Q])
            {
                y -= 0.1F;
            }
        }
    }
}
