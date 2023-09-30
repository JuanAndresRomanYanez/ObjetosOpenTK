using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using Proyecto1_01;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class Game : GameWindow
    {

        Objeto pared = new Objeto();
        Objeto repisa = new Objeto();
        Objeto auto = new Objeto();

        private Camera camera;
        Punto p = new Punto();
        /*
        Escenario a = new Escenario(30,15,-15);//derecha arriba fondo
        Escenario b = new Escenario(30,-40,15);//derecha abajo frente
        Escenario c = new Escenario(-30,-40,15);//izquierda abajo frente
        Escenario d = new Escenario(-30,15,-15);//izquierda arriba fondo
        */
        //-----------------------------------------------------------------------------------------------------------------
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            camera.Update(e);
            base.OnUpdateFrame(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color4.SeaGreen);

            // Configura la cámara con la posición inicial y velocidad
            Vector3 initialPosition = new Vector3(0, 0, 3); // Posición inicial
            Vector3 initialFront = new Vector3(0, 0, -1);  // Dirección hacia donde mira
            Vector3 initialUp = Vector3.UnitY; // Vector "arriba"
            float cameraSpeed = 0.08f; // Velocidad de movimiento
            /////////////////////////////////

            // Coordenada x,y,z
            // ancho, alto, profundidad, color
            /*
            a.Construir();
            b.Construir();
            c.Construir();
            d.Construir();
            */
            //////////////PARED
            Poligono p1 = new Poligono(Color.Silver);//el z viene hacia afuera
            Parte partepared = new Parte();
            p1.Adicionar(new Punto(0, 0, 0));//cara de atras
            p1.Adicionar(new Punto(50, 0, 0));
            p1.Adicionar(new Punto(50, 100, 0));
            p1.Adicionar(new Punto(0, 100, 0));
            partepared.Adicionar(p1);

            p1 = new Poligono(Color.Silver);//cara derecha
            p1.Adicionar(new Punto(50, 0, 0));
            p1.Adicionar(new Punto(50, 100, 0));
            p1.Adicionar(new Punto(50, 100, 4));
            p1.Adicionar(new Punto(50, 0, 4));
            partepared.Adicionar(p1);

            p1 = new Poligono(Color.Silver);//cara izquierda
            p1.Adicionar(new Punto(0, 0, 0));
            p1.Adicionar(new Punto(0, 100, 0));
            p1.Adicionar(new Punto(0, 100, 4));
            p1.Adicionar(new Punto(0, 0, 4));
            partepared.Adicionar(p1);

            p1 = new Poligono(Color.Silver);//cara arriba
            p1.Adicionar(new Punto(0, 100, 0));
            p1.Adicionar(new Punto(50, 100, 0));
            p1.Adicionar(new Punto(50, 100, 4));
            p1.Adicionar(new Punto(0, 100, 4));
            partepared.Adicionar(p1);

            p1 = new Poligono(Color.Silver);//cara abajo
            p1.Adicionar(new Punto(0, 0, 0));
            p1.Adicionar(new Punto(50, 0, 0));
            p1.Adicionar(new Punto(50, 0, 4));
            p1.Adicionar(new Punto(0, 0, 4));
            partepared.Adicionar(p1);

            p1 = new Poligono(Color.Silver);//cara de frente
            p1.Adicionar(new Punto(0, 100, 4));
            p1.Adicionar(new Punto(50, 100, 4));
            p1.Adicionar(new Punto(50, 0, 4));
            p1.Adicionar(new Punto(0, 0, 4));
            partepared.Adicionar(p1);

            pared.AdicionarParte("pared", partepared);
            ///
            /////////////////REPISA
            p1 = new Poligono(Color.DarkOrange);
            Parte parterepisa = new Parte();


            p1.Adicionar(new Punto(0, 70, 4));
            p1.Adicionar(new Punto(0, 75, 4));
            p1.Adicionar(new Punto(50, 75, 4));
            p1.Adicionar(new Punto(50, 70, 4));
            parterepisa.Adicionar(p1);

            p1 = new Poligono(Color.DarkOrange);
            p1.Adicionar(new Punto(0, 70, 4));
            p1.Adicionar(new Punto(0, 75, 4));
            p1.Adicionar(new Punto(50, 75, 4));
            p1.Adicionar(new Punto(50, 70, 4));
            parterepisa.Adicionar(p1);


            p1 = new Poligono(Color.DarkOrange);
            p1.Adicionar(new Punto(50, 70, 50));
            p1.Adicionar(new Punto(50, 75, 50));
            p1.Adicionar(new Punto(50, 75, 4));
            p1.Adicionar(new Punto(50, 70, 4));
            parterepisa.Adicionar(p1);


            p1 = new Poligono(Color.DarkOrange);
            p1.Adicionar(new Punto(0, 70, 50));
            p1.Adicionar(new Punto(0, 75, 50));
            p1.Adicionar(new Punto(0, 75, 4));
            p1.Adicionar(new Punto(0, 70, 4));
            parterepisa.Adicionar(p1);


            p1 = new Poligono(Color.DarkOrange);
            p1.Adicionar(new Punto(0, 75, 50));
            p1.Adicionar(new Punto(0, 75, 4));
            p1.Adicionar(new Punto(50, 75, 4));
            p1.Adicionar(new Punto(50, 75, 50));
            parterepisa.Adicionar(p1);


            p1 = new Poligono(Color.DarkOrange);
            p1.Adicionar(new Punto(0, 70, 50));
            p1.Adicionar(new Punto(0, 70, 4));
            p1.Adicionar(new Punto(50, 70, 4));
            p1.Adicionar(new Punto(50, 70, 50));
            parterepisa.Adicionar(p1);

            parterepisa.Adicionar(p1);

            repisa.AdicionarParte("parte", parterepisa);
            ////////////////////////////////
            ////AUTO////
            p1 = new Poligono(Color.Red);//el z viene hacia afuera
            Parte parteauto = new Parte();
            p1.Adicionar(new Punto(12, 78, 10));//cara de atras
            p1.Adicionar(new Punto(4, 78, 10));
            p1.Adicionar(new Punto(4, 82, 10));
            p1.Adicionar(new Punto(12, 84, 10));
            p1.Adicionar(new Punto(18, 90, 10));
            p1.Adicionar(new Punto(32, 90, 10));
            p1.Adicionar(new Punto(36, 84, 10));
            p1.Adicionar(new Punto(42, 84, 10));
            p1.Adicionar(new Punto(42, 78, 10));
            p1.Adicionar(new Punto(36, 78, 10));

            parteauto.Adicionar(p1);

            p1 = new Poligono(Color.Red);
            p1.Adicionar(new Punto(12, 78, 30));//cara de adelante
            p1.Adicionar(new Punto(4, 78, 30));
            p1.Adicionar(new Punto(4, 82, 30));
            p1.Adicionar(new Punto(12, 84, 30));
            p1.Adicionar(new Punto(18, 90, 30));
            p1.Adicionar(new Punto(32, 90, 30));
            p1.Adicionar(new Punto(36, 84, 30));
            p1.Adicionar(new Punto(42, 84, 30));
            p1.Adicionar(new Punto(42, 78, 30));
            p1.Adicionar(new Punto(36, 78, 30));
            parteauto.Adicionar(p1);

            p1 = new Poligono(Color.Red);
            p1.Adicionar(new Punto(18, 90, 10));//techo
            p1.Adicionar(new Punto(32, 90, 10));
            p1.Adicionar(new Punto(32, 90, 30));
            p1.Adicionar(new Punto(18, 90, 30));
            parteauto.Adicionar(p1);

            p1 = new Poligono(Color.White);//ventana de adelante
            p1.Adicionar(new Punto(12, 84, 10));
            p1.Adicionar(new Punto(18, 90, 10));
            p1.Adicionar(new Punto(18, 90, 30));
            p1.Adicionar(new Punto(12, 84, 30));
            parteauto.Adicionar(p1);

            p1 = new Poligono(Color.Red);//capo
            p1.Adicionar(new Punto(4, 82, 10));
            p1.Adicionar(new Punto(12, 84, 10));
            p1.Adicionar(new Punto(12, 84, 30));
            p1.Adicionar(new Punto(4, 82, 30));
            parteauto.Adicionar(p1);

            p1 = new Poligono(Color.Yellow);//parte de adelante
            p1.Adicionar(new Punto(4, 78, 10));
            p1.Adicionar(new Punto(4, 82, 10));
            p1.Adicionar(new Punto(4, 82, 30));
            p1.Adicionar(new Punto(4, 78, 30));
            parteauto.Adicionar(p1);


            p1 = new Poligono(Color.White);//ventana de atras
            p1.Adicionar(new Punto(32, 90, 10));
            p1.Adicionar(new Punto(36, 84, 10));
            p1.Adicionar(new Punto(36, 84, 30));
            p1.Adicionar(new Punto(32, 90, 30));
            parteauto.Adicionar(p1);

            p1 = new Poligono(Color.Red);//Maletero arriba
            p1.Adicionar(new Punto(36, 84, 10));
            p1.Adicionar(new Punto(42, 84, 10));
            p1.Adicionar(new Punto(42, 84, 30));
            p1.Adicionar(new Punto(36, 84, 30));
            parteauto.Adicionar(p1);

            p1 = new Poligono(Color.Yellow);//Luces de atras
            p1.Adicionar(new Punto(42, 84, 10));
            p1.Adicionar(new Punto(42, 78, 10));
            p1.Adicionar(new Punto(42, 78, 30));
            p1.Adicionar(new Punto(42, 84, 30));
            parteauto.Adicionar(p1);

            p1 = new Poligono(Color.DarkGray);//parte de abajo
            p1.Adicionar(new Punto(4, 78, 10));
            p1.Adicionar(new Punto(42, 78, 10));
            p1.Adicionar(new Punto(42, 78, 30));
            p1.Adicionar(new Punto(4, 78, 30));
            parteauto.Adicionar(p1);

            auto.AdicionarParte("chasis", parteauto);

            ///LLantas del auto
            Parte partellantas = new Parte();
            ///LLanta delantera
            p1 = new Poligono(Color.Black);
            p1.Adicionar(new Punto(12,74,9));//cara de atras
            p1.Adicionar(new Punto(20,74,9));
            p1.Adicionar(new Punto(20,82,9));
            p1.Adicionar(new Punto(12,82,9));
            partellantas.Adicionar(p1);

            p1 = new Poligono(Color.Black);//cara derecha
            p1.Adicionar(new Punto(20, 74, 9));
            p1.Adicionar(new Punto(20, 82, 9));
            p1.Adicionar(new Punto(20, 82, 31));
            p1.Adicionar(new Punto(20, 74, 31));
            partellantas.Adicionar(p1);

            p1 = new Poligono(Color.Black);//cara izquierda
            p1.Adicionar(new Punto(12, 74, 9));
            p1.Adicionar(new Punto(12, 82, 9));
            p1.Adicionar(new Punto(12, 82, 31));
            p1.Adicionar(new Punto(12, 74, 31));
            partellantas.Adicionar(p1);

            p1 = new Poligono(Color.Black);//cara arriba
            p1.Adicionar(new Punto(12, 82, 9));
            p1.Adicionar(new Punto(20, 82, 9));
            p1.Adicionar(new Punto(20, 82, 31));
            p1.Adicionar(new Punto(12, 82, 31));
            partellantas.Adicionar(p1);

            p1 = new Poligono(Color.Black);//cara abajo
            p1.Adicionar(new Punto(12, 74, 9));
            p1.Adicionar(new Punto(20, 74, 9));
            p1.Adicionar(new Punto(20, 74, 31));
            p1.Adicionar(new Punto(12, 74, 31));
            partellantas.Adicionar(p1);

            p1 = new Poligono(Color.Black);
            p1.Adicionar(new Punto(12, 74, 31));//cara de frente
            p1.Adicionar(new Punto(20, 74, 31));
            p1.Adicionar(new Punto(20, 82, 31));
            p1.Adicionar(new Punto(12, 82, 31));
            partellantas.Adicionar(p1);

            ///Llanta trasera
            ///
            p1 = new Poligono(Color.Black);
            p1.Adicionar(new Punto(28,74,9));//cara de atras
            p1.Adicionar(new Punto(36,74,9));
            p1.Adicionar(new Punto(36,82,9));
            p1.Adicionar(new Punto(28,82,9));
            partellantas.Adicionar(p1);

            p1 = new Poligono(Color.Black);//cara derecha
            p1.Adicionar(new Punto(36, 74, 9));
            p1.Adicionar(new Punto(36, 82, 9));
            p1.Adicionar(new Punto(36, 82, 31));
            p1.Adicionar(new Punto(36, 74, 31));
            partellantas.Adicionar(p1);

            p1 = new Poligono(Color.Black);//cara izquierda
            p1.Adicionar(new Punto(28, 74, 9));
            p1.Adicionar(new Punto(28, 82, 9));
            p1.Adicionar(new Punto(28, 82, 31));
            p1.Adicionar(new Punto(28, 74, 31));
            partellantas.Adicionar(p1);

            p1 = new Poligono(Color.Black);//cara arriba
            p1.Adicionar(new Punto(28, 82, 9));
            p1.Adicionar(new Punto(36, 82, 9));
            p1.Adicionar(new Punto(36, 82, 31));
            p1.Adicionar(new Punto(28, 82, 31));
            partellantas.Adicionar(p1);

            p1 = new Poligono(Color.Black);//cara abajo
            p1.Adicionar(new Punto(28, 74, 9));
            p1.Adicionar(new Punto(36, 74, 9));
            p1.Adicionar(new Punto(36, 74, 31));
            p1.Adicionar(new Punto(28, 74, 31));
            partellantas.Adicionar(p1);

            p1 = new Poligono(Color.Black);
            p1.Adicionar(new Punto(28, 74, 31));//cara de frente
            p1.Adicionar(new Punto(36, 74, 31));
            p1.Adicionar(new Punto(36, 82, 31));
            p1.Adicionar(new Punto(28, 82, 31));
            partellantas.Adicionar(p1);
            ///
            auto.AdicionarParte("llantas", partellantas);

            ///
            camera = new Camera(initialPosition, initialFront, initialUp, cameraSpeed);
            //////////////////////////////////////////////////////////////////////////
            base.OnLoad(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnUnload(EventArgs e)
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            //GL.DeleteBuffer(VertexBufferObject);
            base.OnUnload(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            //GL.DepthMask(true);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);
            GL.LoadIdentity();
            //
            /////CAMARA//////////////////////////
            // Configura la matriz de vista (View Matrix) para cambiar la vista
            Matrix4 viewMatrix = camera.GetViewMatrix();
            // Configura la matriz de vista
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref viewMatrix);
            /////CAMARA//////////////////////////
            //---------------------

            /////////////////////////////////////////////////
            /*
            a.Dibujar();
            b.Dibujar();
            c.Dibujar();
            d.Dibujar();
            */
            pared.Dibujar();
            repisa.Dibujar();
            auto.Dibujar();
            //
            // Dibuja los ejes de coordenadas
            GL.LineWidth(2.0f); // Cambia 2.0f al grosor deseado
            GL.Begin(PrimitiveType.Lines);

            // Eje X (rojo)
            GL.Color3(Color.Red); // Rojo
            GL.Vertex3(0.0f, 0.0f, 0.0f); // Origen
            GL.Vertex3(80f, 0.0f, 0.0f); // Punto en X positivo

            // Eje Y (verde)
            GL.Color3(Color.Green); // Verde
            GL.Vertex3(0.0f, 0.0f, 0.0f); // Origen
            GL.Vertex3(0.0f, 80f, 0.0f); // Punto en Y positivo

            // Eje Z (azul)
            GL.Color3(Color.Purple); // Azul
            GL.Vertex3(0.0f, 0.0f, 0.0f); // Origen
            GL.Vertex3(0.0f, 0.0f, 80f); // Punto en Z positivo

            GL.End();
            ///////////////////////////////////////////////
            //

            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnResize(EventArgs e)
        {
            float d = 240;//80
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-d, d, -135, 135, -d, d);//16:9
            //GL.Frustum(-80, 80, -80, 80, 4, 100);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            base.OnResize(e);
        }
    }
}
