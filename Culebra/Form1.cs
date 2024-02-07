using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Culebra
{
    public partial class frmPresentacion : Form
    {
        // Declaro las Variables
        private List<Circulo> Culebra = new List<Circulo>();
        private Circulo comida = new Circulo();

        public frmPresentacion()
        {
            InitializeComponent();

            // Establecer la configuración predeterminada
            new Ajustes();

            // Establecer la velocidad del juego y comenzar el temporizador
            timerJuego.Interval = 1000 / Ajustes.Velocidad;
            timerJuego.Tick += ActualizarPantalla;
            timerJuego.Start();

            // Empieza Juego Nuevo
            ComenzarJuego();
        }

        // Metodo Comenzar Juego
        private void ComenzarJuego()
        {
            // etiqueta muestra game over del juego
            lblGameOver.Visible = false;
            // Establecer la configuración predeterminada
            new Ajustes();

            // Crear un nuevo jugador
            Culebra.Clear();
            Circulo cabeza = new Circulo { X = 10, Y = 5 };
            Culebra.Add(cabeza);

            lblTotalMarcador.Text = Ajustes.Marcador.ToString();
            GenerarComida();
        }

        // Puesto o punto aleatoriamente para obtener la comida
        #region[Generador de Comida]
        private void GenerarComida()
        {
            int maximaXPosicion = pboxTableroJuego.Size.Width / Ajustes.Ancho;
            int maximaYPosicion = pboxTableroJuego.Size.Height / Ajustes.Alto;

            // Aleatoria
            Random r = new Random();
            comida = new Circulo { X = r.Next(0, maximaXPosicion), Y = r.Next(0, maximaYPosicion) };
        }
        #endregion


        #region[Actualiza la Pantalla]
        private void ActualizarPantalla(object sender, EventArgs e)
        {
            // Comprueba si el juego ha terminado
            if (Ajustes.GameOver)
            {
                if (Entrada.KeyPressed(Keys.Enter))
                {
                    ComenzarJuego();
                    lblTotalMarcador.Text = "0";
                }
            }
            else
            {
                if (Entrada.KeyPressed(Keys.Right) && Ajustes.Direccion != Direccion.Izquierda)
                {
                    Ajustes.Direccion = Direccion.Derecha;
                }
                else if (Entrada.KeyPressed(Keys.Left) && Ajustes.Direccion != Direccion.Derecha)
                {
                    Ajustes.Direccion = Direccion.Izquierda;
                }

                else if (Entrada.KeyPressed(Keys.Up) && Ajustes.Direccion != Direccion.Abajo)
                {
                    Ajustes.Direccion = Direccion.Arriba;
                }

                else if (Entrada.KeyPressed(Keys.Down) && Ajustes.Direccion != Direccion.Arriba)
                {
                    Ajustes.Direccion = Direccion.Abajo;
                }

                MoverJugador();    
            }

            pboxTableroJuego.Invalidate();
        }
        #endregion


        #region[Mover al Jugador]
        private void MoverJugador()
        {
            for (int i = Culebra.Count -1; i >= 0; i--)
            {
                // Mover cabeza
                if (i == 0)
                {
                    switch (Ajustes.Direccion)
                    {
                        case Direccion.Arriba:
                            Culebra[i].Y--;
                            break;
                        case Direccion.Abajo:
                            Culebra[i].Y++;
                            break;
                        case Direccion.Izquierda:
                            Culebra[i].X--;
                            break;
                        case Direccion.Derecha:
                            Culebra[i].X++;
                            break;

                    }

                    // Obtener maximo X and Posicion Y
                    int maxXPosicion = pboxTableroJuego.Size.Width / Ajustes.Ancho;
                    int maxYPosicion = pboxTableroJuego.Size.Height / Ajustes.Alto;

                    // Detecta Colision con los bordes del juego
                    if (Culebra[i].X < 0 || Culebra[i].Y < 0 || Culebra[i].X >= maxXPosicion || Culebra[i].Y >= maxYPosicion)
                    {
                        Muere();
                    }

                    // Detecta la Colision con el cuerpo
                    for (int j = 1; j < Culebra.Count; j++)
                    {
                        if (Culebra[i].X == Culebra[j].X && Culebra[i].Y == Culebra[j].Y)
                        {
                            Muere();
                        }
                    }

                    //Detecta la Colision con la pieza de comida
                    if (Culebra[0].X == comida.X && Culebra[0].Y == comida.Y)
                    {
                        Comer();
                    }
                }
                else
                {
                    // Mover cuerpo
                    Culebra[i].X = Culebra[i - 1].X;
                    Culebra[i].Y = Culebra[i - 1].Y;
                }
            }
        }

        private void Comer()
        {
            // Agregar circulo al cuerpo
            Circulo circulo = new Circulo
            {
                X = Culebra[Culebra.Count - 1].X,
                Y = Culebra[Culebra.Count - 1].Y
            };
            
            // Agrega un nuevo circulo
            Culebra.Add(circulo);

            // Actualizar Marcador
            Ajustes.Marcador += Ajustes.Puntos;
            lblTotalMarcador.Text = Ajustes.Marcador.ToString();

            GenerarComida();
        }
        #endregion

        // Metodo Morir
        #region[Muere]
        private void Muere()
        {
            Ajustes.GameOver = true;

        }
        #endregion


        private void frmPresentacion_Load(object sender, EventArgs e)
        {

        }

        #region[Pinta Tablero]
        private void pboxTableroJuego_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Ajustes.GameOver)
            {
                // Colocar Color a la culebra
                Brush culebraColor;

                for (int i = 0; i < Culebra.Count; i++)
                {
                    // Pintar culebra
                    if (i == 0)
                    {
                        culebraColor = Brushes.Black; // Pinta cabeza 
                    }
                    else
                    {
                        culebraColor = Brushes.Green; // Resto del cuerpo
                    }

                    // Pintar Culebra
                    canvas.FillEllipse(culebraColor, new Rectangle(Culebra[i].X * Ajustes.Ancho, Culebra[i].Y * Ajustes.Alto, Ajustes.Ancho, Ajustes.Alto));

                    // Pintar Comida
                    canvas.FillEllipse(Brushes.OrangeRed, new Rectangle(comida.X * Ajustes.Ancho, comida.Y * Ajustes.Alto, Ajustes.Ancho, Ajustes.Alto));
                }
            }
            else
            {
                string gameOver = "Game Over \nTu puntaje Final es: " + Ajustes.Marcador + "\nPresione la tecla Enter para volver a intentarlo";
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;

            }
        }

        #endregion

        #region[Mover tecla hacia Abajo]
        private void frmPresentacion_KeyDown(object sender, KeyEventArgs e)
        {
            Entrada.ChangeState(e.KeyCode, true);
        }
        #endregion

        #region[Mover tecla hacia Arriba]
        private void frmPresentacion_KeyUp(object sender, KeyEventArgs e)
        {
            Entrada.ChangeState(e.KeyCode, false);
        }
        #endregion

        #region[Salir del Juego]
        private void frmPresentacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult SioNO = MessageBox.Show("Está seguro de Salir del Juego ?", "Culebra-Juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SioNO == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }
        #endregion
    }
}
