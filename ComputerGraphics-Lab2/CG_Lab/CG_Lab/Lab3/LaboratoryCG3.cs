using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Lab.Lab3
{
    public partial class LaboratoryCG3 : Form
    {
        Vector3[] matrFigure; // Матрица вершин шестигранника
        int[,] matrFacets; // Матрица граней
        Matrix4x4 transformationMatrix; // Матрица преобразований

        // Параметры преобразований
        float scale = 1.0f;
        float rotateX = 0, rotateY = 0, rotateZ = 0;
        float translateX = 0, translateY = 0, translateZ = 0;
        bool reflectX = false, reflectY = false, reflectZ = false;
        float centerX, centerY;

        bool isAnimating = false;
        float animationSpeed = 1.0f;
        Color figureColor = Color.Red;


        public LaboratoryCG3()
        {
            InitializeComponent();

            centerX = pictureBox1.Width / 2;
            centerY = pictureBox1.Height / 2;

            InitializeFigure();
            transformationMatrix = Matrix4x4.Identity;
        }

        private void InitializeFigure()
        {
            matrFigure = new Vector3[]
            {
                new Vector3(0, 1, 0),
                new Vector3(1, 0, 0),
                new Vector3(0, 0, 1),
                new Vector3(-1, 0, 0),
                new Vector3(0, 0, -1),
                new Vector3(0, -1, 0)
            };

            matrFacets = new int[,]
            {
                {0, 1, 2},
                {0, 2, 3},
                {0, 3, 4},
                {0, 4, 1},
                {5, 2, 1},
                {5, 3, 2},
                {5, 4, 3},
                {5, 1, 4}
            };
        }

        private void DrawFigure()
        {
            if (pictureBox1.Image == null)
            {
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            }

            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            DrawAxes(g);

            UpdateTransformationMatrix();

            Vector3[] transformedVertices = new Vector3[matrFigure.Length];
            for (int i = 0; i < matrFigure.Length; i++)
            {
                transformedVertices[i] = Vector3.Transform(matrFigure[i], transformationMatrix);
            }

            DrawFacesWithDepth(g, transformedVertices);


            pictureBox1.Invalidate();
        }


        private void DrawAxes(Graphics g)
        {
            Pen axisPen = new Pen(Color.Red, 1);

            g.DrawLine(axisPen, centerX - 150, centerY, centerX + 150, centerY);
            g.DrawString("X", this.Font, Brushes.Red, centerX + 155, centerY - 10);

            g.DrawLine(axisPen, centerX, centerY - 150, centerX, centerY + 150);
            g.DrawString("Y", this.Font, Brushes.Red, centerX - 15, centerY - 155);

            g.DrawLine(axisPen, centerX - 100, centerY + 100, centerX + 100, centerY - 100);
            g.DrawString("Z", this.Font, Brushes.Red, centerX + 105, centerY - 105);

            axisPen.Dispose();
        }


        private void DrawFacesWithDepth(Graphics g, Vector3[] vertices)
        {
            var faceDepths = new List<Tuple<int, float>>();
            for (int i = 0; i < matrFacets.GetLength(0); i++)
            {
                float avgZ = (vertices[matrFacets[i, 0]].Z
                    + vertices[matrFacets[i, 1]].Z
                    + vertices[matrFacets[i, 2]].Z) / 3;
                faceDepths.Add(Tuple.Create(i, avgZ));
            }

            var sortedFaces = faceDepths.OrderByDescending(f => f.Item2).ToList();

            foreach (var face in sortedFaces)
            {
                int faceIndex = face.Item1;
                PointF[] points = new PointF[3];
                for (int j = 0; j < 3; j++)
                {
                    float zFactor = 1 + vertices[matrFacets[faceIndex, j]].Z * 0.1f + translateZ * 0.1f;
                    points[j] = new PointF(
                        centerX + vertices[matrFacets[faceIndex, j]].X * 50 * scale * zFactor,
                        centerY - vertices[matrFacets[faceIndex, j]].Y * 50 * scale * zFactor);
                }

                Pen pen = new Pen(figureColor, 2);
                g.DrawPolygon(pen, points);
            }
        }




        private void RotationButton1_Click(object sender, EventArgs e)
        {
            rotateY += 5;
            DrawFigure();
        }


        private void RotationButton2_Click(object sender, EventArgs e)
        {
            rotateY -= 5;
            DrawFigure();
        }
        private void RotationButton3_Click(object sender, EventArgs e)
        {
            rotateX += 5;
            DrawFigure();
        }

        private void RotationButton4_Click(object sender, EventArgs e)
        {
            rotateX -= 5;
            DrawFigure();
        }

        private void RotationButton5_Click(object sender, EventArgs e)
        {
            rotateZ += 5;
            DrawFigure();
        }


        private void RotationButton6_Click(object sender, EventArgs e)
        {
            rotateZ -= 5;
            DrawFigure();
        }

        private void UpdateTransformationMatrix()
        {
            Matrix4x4 scaleMat = Matrix4x4.CreateScale(scale);

            if (reflectX) scaleMat *= Matrix4x4.CreateScale(-1, 1, 1);
            if (reflectY) scaleMat *= Matrix4x4.CreateScale(1, -1, 1);
            if (reflectZ) scaleMat *= Matrix4x4.CreateScale(1, 1, -1);

            Matrix4x4 rotateXMat = Matrix4x4.CreateRotationX(rotateX * (float)Math.PI / 180);
            Matrix4x4 rotateYMat = Matrix4x4.CreateRotationY(rotateY * (float)Math.PI / 180);
            Matrix4x4 rotateZMat = Matrix4x4.CreateRotationZ(rotateZ * (float)Math.PI / 180);
            Matrix4x4 translateMat = Matrix4x4.CreateTranslation(translateX, translateY, translateZ);

            transformationMatrix = scaleMat * rotateXMat * rotateYMat * rotateZMat * translateMat;
        }



        private void DrawFigureButton_Click(object sender, EventArgs e)
        {
            DrawFigure();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            translateX += 0.1f;
            DrawFigure();
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            translateX -= 0.1f;
            DrawFigure();
        }

        private void DownButton_Click(Object sender, EventArgs e)
        {
            translateY -= 0.1f;
            DrawFigure();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            translateY += 0.1f;
            DrawFigure();
        }

        private void MinusOZButton_Click(object obj, EventArgs e)
        {
            translateZ -= 0.1f;
            DrawFigure();
        }

        private void PlusOZButton_Click(object sender, EventArgs e)
        {
            translateZ += 0.1f;
            DrawFigure();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            isAnimating = !isAnimating;
            StartButton.Text = isAnimating ? "Стоп" : "Старт";

            if (isAnimating)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void ScaleUpButton_Click(object sender, EventArgs e)
        {
            scale += 0.1f;
            DrawFigure();
        }
        private void ScaleDownButton_Click(object sender, EventArgs e)
        {
            scale = Math.Max(0.1f, scale - 0.1f);
            DrawFigure();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            rotateX += animationSpeed;
            rotateY += animationSpeed * 0.7f;
            rotateZ += animationSpeed * 0.3f;
            DrawFigure();
        }
        private void StartPositionButton_Click(object sender, EventArgs e)
        {
            scale = 1.0f;
            rotateX = rotateY = rotateZ = 0;
            translateX = translateY = translateZ = 0;
            DrawFigure();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                g.Clear(Color.White);
                pictureBox1.Invalidate();
            }

        }

        private void ReflectXButton_Click(object sender, EventArgs e)
        {
            reflectX = !reflectX;
            DrawFigure();
        }

        private void ReflectYButton_Click(object sender, EventArgs e)
        {
            reflectY = !reflectY;
            DrawFigure();
        }

        private void ReflectZButton_Click(object sender, EventArgs e)
        {
            reflectZ = !reflectZ;
            DrawFigure();
        }
    }
}