using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;

namespace Graf_Tubes_1572001_1572010_v2
{
    public class MyGLWindows : GameWindow
    {
        float x, y, z;
        Vector3 triPos;
        float angle = 0;
        public MyGLWindows(int panjang, int lebar) : base(panjang, lebar)
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
                new Vector3(0, 1, 0));
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projection);
            //GL.MatrixMode(MatrixMode.Modelview);
            //GL.LoadMatrix(ref view);

            Matrix4 modelView, model, model2;
            model = Matrix4.CreateTranslation(new Vector3(0, 0, 0));

            model2 = Matrix4.CreateRotationY(angle);

            modelView = Matrix4.Mult(view, model);
            modelView = Matrix4.Mult(model2, modelView);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref modelView);

            //comment dulu aja
            //GL.Begin(PrimitiveType.Triangles);

            ////GL.Color3(Color.Yellow);
            ////GL.Vertex3(new Vector3(0.2f, -0.2f, -0.2f));
            ////GL.Vertex3(new Vector3(0.2f, -0.2f, 0.2f));
            ////GL.Vertex3(new Vector3(-0.2f, -0.2f, 0.2f));

            ////GL.Color3(Color.Yellow);
            ////GL.Vertex3(new Vector3(-0.2f, -0.2f, 0.2f));
            ////GL.Vertex3(new Vector3(-0.2f, -0.2f, -0.2f));
            ////GL.Vertex3(new Vector3(0.2f, -0.2f, -0.2f));

            ////piramida
            //GL.Color3(Color.LightGray);
            //GL.Vertex3(new Vector3(0.2f, -0.2f, -0.2f));
            //GL.Vertex3(new Vector3(0.2f, -0.2f, 0.2f));
            //GL.Vertex3(new Vector3(0, 0, 0));

            //GL.Color3(Color.LightGray);
            //GL.Vertex3(new Vector3(0.2f, -0.2f, 0.2f));
            //GL.Vertex3(new Vector3(-0.2f, -0.2f, 0.2f));
            //GL.Vertex3(new Vector3(0, 0, 0));

            //GL.Color3(Color.LightGray);
            //GL.Vertex3(new Vector3(-0.2f, -0.2f, 0.2f));
            //GL.Vertex3(new Vector3(-0.2f, -0.2f, -0.2f));
            //GL.Vertex3(new Vector3(0, 0, 0));

            //GL.Color3(Color.LightGray);
            //GL.Vertex3(new Vector3(-0.2f, -0.2f, -0.2f));
            //GL.Vertex3(new Vector3(0.2f, -0.2f, -0.2f));
            //GL.Vertex3(new Vector3(0, 0, 0));

            //GL.End();

            //GL.Begin(PrimitiveType.Quads);
            //GL.Color3(Color.LightGray);
            //GL.Vertex3(new Vector3(0.2f, -0.2f, -0.2f));
            //GL.Vertex3(new Vector3(0.2f, -0.2f, 0.2f));
            //GL.Vertex3(new Vector3(-0.2f, -0.2f, 0.2f));
            //GL.Vertex3(new Vector3(-0.2f, -0.2f, -0.2f));
            //GL.End();


            ////balok
            ////alas
            //GL.Begin(PrimitiveType.Quads);
            //GL.Color3(Color.Pink);
            //GL.Vertex3(new Vector3(0.2f, -0.8f, -0.2f));
            //GL.Vertex3(new Vector3(0.2f, -0.8f, 0.2f));
            //GL.Vertex3(new Vector3(-0.2f, -0.8f, 0.2f));
            //GL.Vertex3(new Vector3(-0.2f, -0.8f, -0.2f));
            //GL.End();

            ////samping kanan 
            //GL.Begin(PrimitiveType.Quads);
            //GL.Color3(Color.Cornsilk);
            //GL.Vertex3(new Vector3(0.2f, -0.2f, -0.2f));
            //GL.Vertex3(new Vector3(0.2f, -0.2f, 0.2f));
            //GL.Vertex3(new Vector3(0.2f, -0.8f, 0.2f));
            //GL.Vertex3(new Vector3(0.2f, -0.8f, -0.2f));
            //GL.End();

            ////samping kiri 
            //GL.Begin(PrimitiveType.Quads);
            //GL.Color3(Color.LightGray);
            //GL.Vertex3(new Vector3(-0.2f, -0.2f, -0.2f));
            //GL.Vertex3(new Vector3(-0.2f, -0.2f, 0.2f));
            //GL.Vertex3(new Vector3(-0.2f, -0.8f, 0.2f));
            //GL.Vertex3(new Vector3(-0.2f, -0.8f, -0.2f));
            //GL.End();

            ////depan
            //GL.Begin(PrimitiveType.Quads);
            //GL.Color3(Color.LightGray);
            //GL.Vertex3(new Vector3(-0.2f, -0.2f, 0.2f));
            //GL.Vertex3(new Vector3(0.2f, -0.2f, 0.2f));
            //GL.Vertex3(new Vector3(0.2f, -0.8f, 0.2f));
            //GL.Vertex3(new Vector3(-0.2f, -0.8f, 0.2f));
            //GL.End();

            ////belakang
            //GL.Begin(PrimitiveType.Quads);
            //GL.Color3(Color.LightGray);
            //GL.Vertex3(new Vector3(-0.2f, -0.2f, -0.2f));
            //GL.Vertex3(new Vector3(0.2f, -0.2f, -0.2f));
            //GL.Vertex3(new Vector3(0.2f, -0.8f, -0.2f));
            //GL.Vertex3(new Vector3(-0.2f, -0.8f, -0.2f));
            //GL.End();

            ////sayap kanan
            //GL.Begin(PrimitiveType.Triangles);
            //GL.Color3(Color.LightGray);
            //GL.Vertex3(new Vector3(0, -0.3f, -0.1f));
            //GL.Vertex3(new Vector3(0.6f, -0.5f, -0.1f));
            //GL.Vertex3(new Vector3(0, -0.7f, -0.1f));
            //GL.End();

            ////sayap kiri
            //GL.Begin(PrimitiveType.Triangles);
            //GL.Color3(Color.LightGray);
            //GL.Vertex3(new Vector3(0, -0.3f, -0.1f));
            //GL.Vertex3(new Vector3(-0.6f, -0.5f, -0.1f));
            //GL.Vertex3(new Vector3(0, -0.7f, -0.1f));
            //GL.End();

            ////sayap tengah
            //GL.Begin(PrimitiveType.Triangles);
            //GL.Color3(Color.LightGray);
            //GL.Vertex3(new Vector3(0, -0.5f, -0.2f));
            //GL.Vertex3(new Vector3(0, -0.7f, 0.35f));
            //GL.Vertex3(new Vector3(0, -0.7f, -0.2f));
            //GL.End();

            ////peluru
            //GL.Begin(PrimitiveType.Quads);
            //GL.Color3(Color.Sienna);
            //GL.Vertex3(new Vector3(-0.02f, -0.2f, 0));
            //GL.Vertex3(new Vector3(0.02f, -0.2f, 0));
            //GL.Vertex3(new Vector3(0.02f, 0.1f, 0));
            //GL.Vertex3(new Vector3(-0.02f, 0.1f, 0));
            //GL.End();

            ////objek yg ditembak
            //model = Matrix4.CreateTranslation(new Vector3(0.6f, 0.5f, 0));

            //model2 = Matrix4.CreateScale(0.2f);

            //modelView = Matrix4.Mult(view, model);
            //modelView = Matrix4.Mult(model2, modelView);
            //GL.MatrixMode(MatrixMode.Modelview);
            //GL.LoadMatrix(ref modelView);
            //sasaran();



            #region kepala
            GL.Begin(PrimitiveType.Triangles);
            //alas dasar
            GL.Color3(Color.Black);
            //titik tengah atas
            GL.Vertex3(0, 0, 0.03f);
            //kiri bawah
            GL.Vertex3(-0.04f, -0.2f, 0);
            //kanan bawah
            GL.Vertex3(0.04f, -0.2f, 0);

            //samping kiri
            GL.Color3(Color.Gray);
            //kanan bawah
            GL.Vertex3(-0.02f, -0.2f, 0.05f);
            //kiri bawah
            GL.Vertex3(-0.04f, -0.2f, 0);
            //atas tengah
            GL.Vertex3(0, 0, 0.03f);

            //samping kanan
            GL.Color3(Color.Gray);
            //kiri bawah
            GL.Vertex3(0.02f, -0.2f, 0.05f);
            //atas tengah
            GL.Vertex3(0, 0, 0.03f);
            //kanan bawah
            GL.Vertex3(0.04f, -0.2f, 0);

            //segitiga tengah penutup
            GL.Color3(Color.DarkGray);
            //titik tengah
            GL.Vertex3(0, 0, 0.03f);
            //kiri
            GL.Vertex3(-0.02f, -0.2f, 0.05f);
            //kanan
            GL.Vertex3(0.02f, -0.2f, 0.05f);
            GL.End();
            #endregion

            #region bagian 2
            GL.Begin(PrimitiveType.Quads);
            //kiri
            GL.Color3(Color.Gray);
            //sebelah kiri atas
            GL.Vertex3(-0.04f, -0.2f, 0);
            //kanan atas
            GL.Vertex3(-0.02f, -0.2f, 0.05f);
            //kanan bawah
            GL.Vertex3(-0.03f, -0.3f, 0.06f);
            //kiri bawah
            GL.Vertex3(-0.05f, -0.3f, 0);

            //tengah
            GL.Color3(Color.DarkGray);
            //kiri atas
            GL.Vertex3(-0.02f, -0.2f, 0.05f);
            //kanan atas
            GL.Vertex3(0.02f, -0.2f, 0.05f);
            //kanan bawah
            GL.Vertex3(0.03f, -0.3f, 0.06f);
            //kiri bawah
            GL.Vertex3(-0.03f, -0.3f, 0.06f);

            //kanan
            GL.Color3(Color.Gray);
            //sebelah kiri atas
            GL.Vertex3(0.02f, -0.2f, 0.05f);
            //kanan atas
            GL.Vertex3(0.04f, -0.2f, 0);
            //kanan bawah
            GL.Vertex3(0.05f, -0.3f, 0);
            //kiri bawah
            GL.Vertex3(0.03f, -0.3f, 0.06f);

            //alas
            GL.Color3(Color.Black);
            //kiri bawah
            GL.Vertex3(-0.05f, -0.3f, 0);
            //kiri atas
            GL.Vertex3(-0.04f, -0.2f, 0);
            //kanan atas
            GL.Vertex3(0.04f, -0.2f, 0);
            //kanan bawah
            GL.Vertex3(0.05f, -0.3f, 0);

            GL.End();
            #endregion

            #region badan tengah bawah kaca
            GL.Begin(PrimitiveType.Quads);
            //tengah
            GL.Color3(Color.DarkGray);
            //kiri atas
            GL.Vertex3(-0.03f, -0.3f, 0.06f);
            //kanan atas
            GL.Vertex3(0.03f, -0.3f, 0.06f);
            //kanan bawah
            GL.Vertex3(0.03f, -0.6f, 0.06f);
            //kiri bawah
            GL.Vertex3(-0.03f, -0.6f, 0.06f);

            //kiri
            GL.Color3(Color.Gray);
            //kiri atas
            GL.Vertex3(-0.05f, -0.3f, 0);
            //kanan atas
            GL.Vertex3(-0.03f, -0.3f, 0.06f);
            //kanan bawah
            GL.Vertex3(-0.03f, -0.6f, 0.06f);
            //kiri bawah
            GL.Vertex3(-0.05f, -0.6f, 0);

            //kanan
            GL.Color3(Color.Gray);
            //kiri atas
            GL.Vertex3(0.03f, -0.3f, 0.06f);
            //kanan atas
            GL.Vertex3(0.05f, -0.3f, 0);
            //kanan bawah
            GL.Vertex3(0.05f, -0.6f, 0);
            //kiri bawah 
            GL.Vertex3(0.03f, -0.6f, 0.06f);

            //alas
            GL.Color3(Color.Black);
            //kiri atas
            GL.Vertex3(-0.05f, -0.3f, 0);
            //kanan atas
            GL.Vertex3(0.05f, -0.3f, 0);
            //kanan bawah
            GL.Vertex3(0.05f, -0.6f, 0);
            //kiri bawah
            GL.Vertex3(-0.05f, -0.6f, 0);
            GL.End();
            #endregion

            #region kaca depan
            GL.Begin(PrimitiveType.Quads);
            //bagian tengah
            GL.Color3(Color.AntiqueWhite);
            //kiri atas
            GL.Vertex3(-0.03f, -0.3f, 0.06f);
            //kanan atas
            GL.Vertex3(0.03f, -0.3f, 0.06f);
            //kanan bawah
            GL.Vertex3(0.02f, -0.4f, 0.09f);
            //kiri bawah
            GL.Vertex3(-0.02f, -0.4f, 0.09f);
            GL.End();
            
            GL.Begin(PrimitiveType.Triangles);
            //bagian kanan
            GL.Color3(Color.LightGray);
            //titik tengah atas
            GL.Vertex3(0.03f, -0.3f, 0.06f);
            //kiri bawah
            GL.Vertex3(0.02f, -0.4f, 0.09f);
            //kanan bawah
            GL.Vertex3(0.03f, -0.4f, 0.06f);

            //bagian kiri
            GL.Color3(Color.LightGray);
            //titik tengah atas
            GL.Vertex3(-0.03f, -0.3f, 0.06f);
            //kanan bawah
            GL.Vertex3(-0.02f, -0.4f, 0.09f);
            //kiri bawah
            GL.Vertex3(-0.03f, -0.4f, 0.06f);
            GL.End();
            #endregion

            #region border antara kaca depan dan tengah
            GL.Begin(PrimitiveType.Quads);
            //bagian tengah
            GL.Color3(Color.DarkGray);
            //kiri atas
            GL.Vertex3(-0.03f, -0.39f, 0.09f);
            //kanan atas
            GL.Vertex3(0.03f, -0.39f, 0.09f);
            //kanan bawah
            GL.Vertex3(0.02f, -0.4f, 0.09f);
            //kiri bawah
            GL.Vertex3(-0.02f, -0.4f, 0.09f);
            

            
            //bagian kanan
            GL.Color3(Color.DarkGray);
            //kanan atas
            GL.Vertex3(0.03f, -0.39f, 0.06f);
            //kanan bawah
            GL.Vertex3(0.03f, -0.4f, 0.06f);
            //kiri bawah
            GL.Vertex3(0.02f, -0.4f, 0.09f);
            //kiri atas
            GL.Vertex3(0.03f, -0.39f, 0.09f);


            //bagian kiri
            GL.Color3(Color.DarkGray);
            //kiri atas
            GL.Vertex3(-0.03f, -0.39f, 0.06f);
            //kanan atas
            GL.Vertex3(-0.03f, -0.39f, 0.09f);
            //kanan bawah
            GL.Vertex3(-0.02f, -0.4f, 0.09f);
            //kiri bawah
            GL.Vertex3(-0.03f, -0.4f, 0.06f);
            GL.End();
            #endregion

            #region kaca tengah
            GL.Begin(PrimitiveType.Quads);
            //bagian tengah
            GL.Color3(Color.AntiqueWhite);
            //kiri atas
            GL.Vertex3(-0.02f, -0.4f, 0.09f);
            //kanan atas
            GL.Vertex3(0.02f, -0.4f, 0.09f);
            //kanan bawah
            GL.Vertex3(0.02f, -0.5f, 0.09f);
            //kiri bawah
            GL.Vertex3(-0.02f, -0.5f, 0.09f);

            //bagian kiri
            GL.Color3(Color.LightGray);
            //kiri atas
            GL.Vertex3(-0.03f, -0.4f, 0.06f);
            //kanan atas
            GL.Vertex3(-0.02f, -0.4f, 0.09f);
            //kanan bawah
            GL.Vertex3(-0.02f, -0.5f, 0.09f);
            //kiri bawah
            GL.Vertex3(-0.03f, -0.5f, 0.06f);

            //bagian kanan
            GL.Color3(Color.LightGray);
            //kiri atas
            GL.Vertex3(0.02f, -0.4f, 0.09f);
            //kanan atas
            GL.Vertex3(0.03f, -0.4f, 0.06f);
            //kanan bawah
            GL.Vertex3(0.03f, -0.5f, 0.06f);
            //kiri bawah
            GL.Vertex3(0.02f, -0.5f, 0.09f);
            GL.End();
            #endregion

            #region border antara kaca tengah dan belakang
            GL.Begin(PrimitiveType.Quads);
            //bagian tengah
            GL.Color3(Color.DarkGray);
            //kiri atas
            GL.Vertex3(-0.03f, -0.49f, 0.092f);
            //kanan atas
            GL.Vertex3(0.03f, -0.49f, 0.092f);
            //kanan bawah
            GL.Vertex3(0.02f, -0.5f, 0.092f);
            //kiri bawah
            GL.Vertex3(-0.02f, -0.5f, 0.092f);


            //bagian kanan
            GL.Color3(Color.DarkGray);
            //kanan atas
            GL.Vertex3(0.03f, -0.49f, 0.06f);
            //kanan bawah
            GL.Vertex3(0.03f, -0.5f, 0.06f);
            //kiri bawah
            GL.Vertex3(0.02f, -0.5f, 0.09f);
            //kiri atas
            GL.Vertex3(0.03f, -0.49f, 0.09f);


            //bagian kiri
            GL.Color3(Color.DarkGray);
            //kiri atas
            GL.Vertex3(-0.03f, -0.49f, 0.06f);
            //kanan atas
            GL.Vertex3(-0.03f, -0.49f, 0.09f);
            //kanan bawah
            GL.Vertex3(-0.02f, -0.5f, 0.09f);
            //kiri bawah
            GL.Vertex3(-0.03f, -0.5f, 0.06f);
            GL.End();
            #endregion

            #region kaca belakang
            GL.Begin(PrimitiveType.Quads);
            //bagian tengah
            GL.Color3(Color.AntiqueWhite);
            //kiri atas
            GL.Vertex3(-0.02f, -0.5f, 0.09f);
            //kanan atas
            GL.Vertex3(0.02f, -0.5f, 0.09f);
            //kanan bawah
            GL.Vertex3(0.03f, -0.6f, 0.06f);
            //kiri bawah
            GL.Vertex3(-0.03f, -0.6f, 0.06f);
            GL.End();

            GL.Begin(PrimitiveType.Triangles);
            //bagian kanan
            GL.Color3(Color.LightGray);
            //titik tengah bawah
            GL.Vertex3(0.03f, -0.6f, 0.06f);
            //kiri atas
            GL.Vertex3(0.02f, -0.5f, 0.09f);
            //kanan bawah
            GL.Vertex3(0.03f, -0.5f, 0.06f);

            //bagian kiri
            GL.Color3(Color.LightGray);
            //titik tengah bawah
            GL.Vertex3(-0.03f, -0.6f, 0.06f);
            //kanan bawah
            GL.Vertex3(-0.02f, -0.5f, 0.09f);
            //kiri bawah
            GL.Vertex3(-0.03f, -0.5f, 0.06f);
            GL.End();

            #endregion

            #region bagian 5
            GL.Begin(PrimitiveType.Quads);
            //kiri
            GL.Color3(Color.Gray);
            //kiri atas
            GL.Vertex3(-0.05f, -0.6f, 0);
            //kanan atas
            GL.Vertex3(-0.03f, -0.6f, 0.06f);            
            //kanan bawah
            GL.Vertex3(-0.02f, -0.7f, 0.05f);
            //kiri bawah
            GL.Vertex3(-0.05f, -0.7f, 0);

            //tengah
            GL.Color3(Color.DarkGray);
            //kiri atas
            GL.Vertex3(-0.03f, -0.6f, 0.06f);
            //kanan atas
            GL.Vertex3(0.03f, -0.6f, 0.06f);
            //kanan bawah
            GL.Vertex3(0.02f, -0.7f, 0.05f);
            //kiri bawah
            GL.Vertex3(-0.02f, -0.7f, 0.05f);

            //kanan
            GL.Color3(Color.Gray);
            //sebelah kiri atas
            GL.Vertex3(0.03f, -0.6f, 0.06f);
            //kanan atas
            GL.Vertex3(0.05f, -0.6f, 0);
            //kanan bawah
            GL.Vertex3(0.05f, -0.7f, 0);
            //kiri bawah
            GL.Vertex3(0.02f, -0.7f, 0.05f);

            //alas
            GL.Color3(Color.Black);
            //kiri bawah
            GL.Vertex3(-0.04f, -0.7f, 0);
            //kiri atas
            GL.Vertex3(-0.05f, -0.6f, 0);
            //kanan atas
            GL.Vertex3(0.05f, -0.6f, 0);
            //kanan bawah
            GL.Vertex3(0.04f, -0.7f, 0);

            GL.End();
            #endregion

            #region bagian belakang
            GL.Begin(PrimitiveType.Quads);
            //tengah
            GL.Color3(Color.DarkGray);
            //kiri atas
            GL.Vertex3(-0.02f, -0.7f, 0.05f);
            //kanan atas
            GL.Vertex3(0.02f, -0.7f, 0.05f);
            //kanan bawah
            GL.Vertex3(0.01f, -0.85f, 0.03f);
            //kiri bawah
            GL.Vertex3(-0.01f, -0.85f, 0.03f);

            //kiri
            GL.Color3(Color.Gray);
            //kiri atas
            GL.Vertex3(-0.05f, -0.7f, 0);
            //kanan atas
            GL.Vertex3(-0.02f, -0.7f, 0.05f);
            //kanan bawah
            GL.Vertex3(-0.01f, -0.85f, 0.03f);
            //kiri bawah
            GL.Vertex3(-0.02f, -0.85f, 0.02f);

            //kanan
            GL.Color3(Color.Gray);
            //kiri atas
            GL.Vertex3(0.05f, -0.7f, 0);
            //kanan atas
            GL.Vertex3(0.02f, -0.7f, 0.05f);
            //kanan bawah
            GL.Vertex3(0.01f, -0.85f, 0.03f);
            //kiri bawah
            GL.Vertex3(0.02f, -0.85f, 0.02f);

            //alas
            GL.Color3(Color.Black);
            //kiri atas
            GL.Vertex3(-0.04f, -0.7f, 0);
            //kanan atas
            GL.Vertex3(0.04f, -0.7f, 0);
            //kanan bawah
            GL.Vertex3(0.01f, -0.85f, 0.02f);
            //kiri bawah
            GL.Vertex3(-0.02f, -0.85f, 0.02f);
            GL.End();
            #endregion

            #region trapesium ekor
            GL.Begin(PrimitiveType.Quads);
            //alas
            //y=0.55
            //x=-0.5-0.5
            //z=0.03 - 0.02
            GL.Color3(Color.LightGray);
            //kiri atas
            GL.Vertex3(-0.14f, -0.7f, 0.025f);
            //kanan atas
            GL.Vertex3(0.14f, -0.7f, 0.025f);
            //kanan bawah
            GL.Vertex3(0.3f, -1, -0.025f);
            //kiri bawah
            GL.Vertex3(-0.3f, -1, -0.025f);

            //balok buat wadah peluru kiri
            GL.Color3(Color.DarkGray);
            //alas
            GL.Vertex3(-0.09, -0.53f, 0.02f);
            GL.Vertex3(-0.12, -0.53f, 0.02f);
            GL.Vertex3(-0.12, -0.65f, 0.02f);
            GL.Vertex3(-0.09, -0.65f, 0.02f);
            //kiri
            GL.Color3(Color.Gray);
            GL.Vertex3(-0.09, -0.53f, 0.02f);
            GL.Vertex3(-0.09, -0.53f, 0.04);
            GL.Vertex3(-0.09, -0.65f, 0.04);
            GL.Vertex3(-0.09, -0.65f, 0.02f);

            GL.Vertex3(-0.12, -0.53f, 0.02f);
            GL.Vertex3(-0.12, -0.53f, 0.04);
            GL.Vertex3(-0.12, -0.65f, 0.04);
            GL.Vertex3(-0.12, -0.65f, 0.02f);

            //balok peluru kanan
            GL.Color3(Color.DarkGray);
            GL.Vertex3(0.09, -0.53f, 0.03f);
            GL.Vertex3(0.12, -0.53f, 0.03f);
            GL.Vertex3(0.12, -0.65f, 0.03f);
            GL.Vertex3(0.09, -0.65f, 0.03f);

            GL.Color3(Color.Gray);
            GL.Vertex3(0.09, -0.53f, 0.02f);
            GL.Vertex3(0.09, -0.53f, 0.04);
            GL.Vertex3(0.09, -0.65f, 0.04);
            GL.Vertex3(0.09, -0.65f, 0.02f);

            GL.Vertex3(0.12, -0.53f, 0.02f);
            GL.Vertex3(0.12, -0.53f, 0.04);
            GL.Vertex3(0.12, -0.65f, 0.04);
            GL.Vertex3(0.12, -0.65f, 0.02f);

            //lapisan atas
            GL.Color3(Color.Gray);
            //lapisan penutup atas trapesium
            GL.Vertex3(-0.15f, -0.55f, 0.02f);
            GL.Vertex3(0.15f, -0.55f, 0.02f);
            GL.Vertex3(0.15f, -0.55f, 0.05f);
            GL.Vertex3(-0.15f, -0.55f, 0.05f);
            //lapisan atas trapesium
            GL.Color3(Color.DarkGray);
            GL.Vertex3(-0.15f, -0.55f, 0.04f);
            GL.Vertex3(0.15f, -0.55f, 0.04f);
            GL.Vertex3(0.23f, -0.8f, 0.05f);
            GL.Vertex3(-0.23f, -0.8f, 0.05f);
            //lapisan bawah
            //alas dari trapesium atas
            GL.Color3(Color.Black);
            GL.Vertex3(-0.15f, -0.55f, 0.02f);
            GL.Vertex3(0.15f, -0.55f, 0.02f);
            GL.Vertex3(0.23f, -0.8f, 0);
            GL.Vertex3(-0.23f, -0.8f, 0);

            //lapisan bawah kiri
            GL.Color3(Color.Gray);
            //lapisan pinggir di kiri trapesium
            GL.Vertex3(-0.15f, -0.55f, 0.02);
            GL.Vertex3(-0.15f, -0.55f, 0.04f);
            GL.Vertex3(-0.23f, -0.8f, 0.05f);
            GL.Vertex3(-0.23f, -0.8f, 0);

            //lapisan bawah kanan
            //lapisan pinggir di kanan trapesium
            GL.Vertex3(0.15f, -0.55f, 0.02f);
            GL.Vertex3(0.15f, -0.55f, 0.04f);
            GL.Vertex3(0.23f, -0.8f, 0.05f);
            GL.Vertex3(0.23f, -0.8f, 0);
            GL.End();

            //lapisan belakang kiri segitiga yg dipinggir itu loh
            GL.Begin(PrimitiveType.Quads);

            //lapisan bawahnya
            GL.Color3(Color.Black);
            GL.Vertex3(-0.23f, -0.8f, 0);
            GL.Vertex3(0, -0.8f, 0);
            GL.Vertex3(-0.25f, -0.95f, -0.03f);
            GL.Vertex3(-0.35f, -0.95f, -0.05f);

            //lapisan atasnya
            GL.Color3(Color.DarkGray);
            GL.Vertex3(-0.23f, -0.8f, 0.05f);
            GL.Vertex3(0, -0.8f, 0.05f);
            GL.Vertex3(-0.25f, -0.95f, -0.01f);
            GL.Vertex3(-0.35f, -0.95f, -0.03f);

            //lapisan penutup kiri luar
            GL.Color3(Color.Gray); 
            GL.Vertex3(-0.23f, -0.8f, 0);
            GL.Vertex3(-0.23f, -0.8f, 0.05f);
            GL.Vertex3(-0.35f, -0.95f, -0.03f);
            GL.Vertex3(-0.35f, -0.95f, -0.05f);

            //lapisan penutup kiri dalem
            GL.Vertex3(0, -0.8f, 0);
            GL.Vertex3(0, -0.8f, 0);
            GL.Vertex3(-0.24f, -0.95f, -0.01f);
            GL.Vertex3(-0.24f, -0.95f, -0.03f);

            //lapisan tutup belakang kiri
            GL.Vertex3(-0.35f, -0.95f, -0.03f);
            GL.Vertex3(-0.24f, -0.95f, -0.01f);
            GL.Vertex3(-0.35f, -0.95f, -0.05f);
            GL.Vertex3(-0.24f, -0.95f, -0.03f);

            //comment aja
            //GL.Color3(Color.Red);
            //GL.Vertex3(-0.23f, -0.8f, -0.03f);
            //GL.Vertex3(-0.35f, -0.95f, 0);
            //GL.Vertex3(-0.35f, -0.95f, 0);
            //GL.Vertex3(-0.23f, -0.8f, -0.03f);

            //lapisan belakang kanan
            GL.Color3(Color.Black);
            //lapisan atas
            GL.Vertex3(0.23f, -0.8f, 0);
            GL.Vertex3(0, -0.8f, 0);
            GL.Vertex3(0.25f, -0.95f, -0.03f);
            GL.Vertex3(0.35f, -0.95f, -0.05f);

            //lapisan bawah
            GL.Color3(Color.DarkGray);
            GL.Vertex3(0.23f, -0.8f, 0.05f);
            GL.Vertex3(0, -0.8f, 0.05f);
            GL.Vertex3(0.25f, -0.95f, -0.01f);
            GL.Vertex3(0.35f, -0.95f, -0.03f);

            //lapisan tutup kanan luar
            GL.Color3(Color.Gray);
            GL.Vertex3(0.23f, -0.8f, 0);
            GL.Vertex3(0.23f, -0.8f, 0.05f);
            GL.Vertex3(0.35f, -0.95f, -0.03f);
            GL.Vertex3(0.35f, -0.95f, -0.05f);

            //lapisan tutup kanan bawah
            GL.Vertex3(0.35f, -0.95f, -0.03f);
            GL.Vertex3(0.24f, -0.95f, -0.01f);
            GL.Vertex3(0.35f, -0.95f, -0.05f);
            GL.Vertex3(0.24f, -0.95f, -0.03f);

            //lapisan tutup kanan dalem
            GL.Vertex3(0, -0.8f, 0);
            GL.Vertex3(0, -0.8f, 0);
            GL.Vertex3(0.24f, -0.95f, -0.01f);
            GL.Vertex3(0.24f, -0.95f, -0.03f);
            GL.End();

            //comment dulu aja
            //GL.Begin(PrimitiveType.Triangles);
            //GL.Color3(Color.Red);
            //GL.Vertex3(0.23f, -0.8f, 0.03f);
            //GL.Vertex3(0.23f, -0.8f, 0.01f);
            //GL.Vertex3(0.35f, -0.95f, 0);

            //GL.Vertex3(-0.23f, -0.8f, 0.03f);
            //GL.Vertex3(-0.23f, -0.8f, 0.01f);
            //GL.Vertex3(-0.35f, -0.95f, 0);
            //GL.End();

            #endregion

            #region ekor ekor ekor hehe
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(Color.DarkGray);
            GL.Vertex3(-0.1f,-0.8f,0.03f);
            GL.Vertex3(0.1f, -0.8f, 0.03f);
            GL.Vertex3(0.05f, -1, 0.03f);
            GL.Vertex3(-0.05f, -1, 0.03f);
            //lagi males
            //kiri
            GL.Color3(Color.LightGray);
            GL.Vertex3(-0.045f, -0.85f, 0.03f);
            GL.Vertex3(-0.045f, -0.88f, 0.15f);
            GL.Vertex3(-0.045f, -0.9f, 0.15f);
            GL.Vertex3(-0.045f, -0.9f, 0.03f);

            GL.Vertex3(-0.044f, -0.85f, 0.03f);
            GL.Vertex3(-0.044f, -0.88f, 0.15f);
            GL.Vertex3(-0.044f, -0.9f, 0.15f);
            GL.Vertex3(-0.044f, -0.9f, 0.03f);

            GL.Vertex3(-0.043f, -0.85f, 0.03f);
            GL.Vertex3(-0.043f, -0.88f, 0.15f);
            GL.Vertex3(-0.043f, -0.9f, 0.15f);
            GL.Vertex3(-0.043f, -0.9f, 0.03f);

            GL.Vertex3(-0.042f, -0.85f, 0.03f);
            GL.Vertex3(-0.042f, -0.88f, 0.15f);
            GL.Vertex3(-0.042f, -0.9f, 0.15f);
            GL.Vertex3(-0.042f, -0.9f, 0.03f);

            GL.Vertex3(-0.041f, -0.85f, 0.03f);
            GL.Vertex3(-0.041f, -0.88f, 0.15f);
            GL.Vertex3(-0.041f, -0.9f, 0.15f);
            GL.Vertex3(-0.041f, -0.9f, 0.03f);

            GL.Vertex3(-0.04f, -0.85f, 0.03f);
            GL.Vertex3(-0.04f, -0.88f, 0.15f);
            GL.Vertex3(-0.04f, -0.9f, 0.15f);
            GL.Vertex3(-0.04f, -0.9f, 0.03f);

            //kanan
            GL.Vertex3(0.045f, -0.85f, 0.03f);
            GL.Vertex3(0.045f, -0.88f, 0.15f);
            GL.Vertex3(0.045f, -0.9f, 0.15f);
            GL.Vertex3(0.045f, -0.9f, 0.03f);

            GL.Vertex3(0.044f, -0.85f, 0.03f);
            GL.Vertex3(0.044f, -0.88f, 0.15f);
            GL.Vertex3(0.044f, -0.9f, 0.15f);
            GL.Vertex3(0.044f, -0.9f, 0.03f);

            GL.Vertex3(0.043f, -0.85f, 0.03f);
            GL.Vertex3(0.043f, -0.88f, 0.15f);
            GL.Vertex3(0.043f, -0.9f, 0.15f);
            GL.Vertex3(0.043f, -0.9f, 0.03f);

            GL.Vertex3(0.042f, -0.85f, 0.03f);
            GL.Vertex3(0.042f, -0.88f, 0.15f);
            GL.Vertex3(0.042f, -0.9f, 0.15f);
            GL.Vertex3(0.042f, -0.9f, 0.03f);

            GL.Vertex3(0.041f, -0.85f, 0.03f);
            GL.Vertex3(0.041f, -0.88f, 0.15f);
            GL.Vertex3(0.041f, -0.9f, 0.15f);
            GL.Vertex3(0.041f, -0.9f, 0.03f);

            GL.Vertex3(0.04f, -0.85f, 0.03f);
            GL.Vertex3(0.04f, -0.88f, 0.15f);
            GL.Vertex3(0.04f, -0.9f, 0.15f);
            GL.Vertex3(0.04f, -0.9f, 0.03f);
            GL.End();
            #endregion
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
                angle -= 0.05f;
                //z += 0.1F;
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
