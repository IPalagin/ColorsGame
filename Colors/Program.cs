using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.Learning;
using SFML.Window;

namespace Colors
{
    internal class Program : Game
    {
        static Color[] colors = new Color[] { Color.Blue, Color.Green, Color.Red, Color.Cyan };
        static string[] colorName = new string[] { "Синий", "Зеленый", "Красный", "Голубой" };
        static Color currentColor = colors[0];
        static string currentColorName = colorName[0];

        static int score;
        static int maxScore = score;

        static void MenuDraw()
        {
            SetFillColor(Color.White);
            DrawText(20, 10, "Нажмите клавишу соответствующую цвету текста:", 35);
            DrawText(20, 40,  "Синий   - ' С '", 35);
            DrawText(20, 70,  "Зеленый - ' З '", 35);
            DrawText(20, 100, "Красный - ' К '", 35);
            DrawText(20, 130, "Голубой - ' Г '", 35);
            DrawText(300, 200, score.ToString(), 65);
            DrawText(20, 535, "Максимальный рузультат: " + maxScore.ToString(), 45);
        }

        static void RandomizationOfColorInTheName()
        {
            Random random = new Random();
            int i = random.Next(colors.Length);    
            currentColor = colors[i];

            i = random.Next(colorName.Length);
            currentColorName = colorName[i];
        }

        static void DrawText()
        {
            SetFillColor(currentColor);
            DrawText(300, 275, currentColorName, 85);
        }

        static void LogicOfUnputKeyToGetTheResult()
        {
            if (GetKeyDown(Keyboard.Key.C))
            {
                if (currentColor == Color.Blue)
                {
                    RandomizationOfColorInTheName();
                    score++;
                }
                else
                {
                    score = 0;
                }
            }
            else if (GetKeyDown(Keyboard.Key.P))
            {
                if (currentColor == Color.Green)
                {
                    RandomizationOfColorInTheName();
                    score++;
                }
                else
                {
                    score = 0;
                }
            }
            else if (GetKeyDown(Keyboard.Key.R))
            {
                if (currentColor == Color.Red)
                {
                    RandomizationOfColorInTheName();
                    score++;
                }
                else
                {
                    score = 0;
                }
            }
            else if (GetKeyDown(Keyboard.Key.U))
            {
                if (currentColor == Color.Cyan)
                {
                    RandomizationOfColorInTheName();
                    score++;
                }
                else
                {
                    score = 0;
                }
            }
        }

        static void Main(string[] args)
        {
            SetFont("Nevduplenysh-Regular.otf");

            InitWindow(800, 600, "ColorsGame");

            RandomizationOfColorInTheName();

            while (true)
            {
                DispatchEvents();

                LogicOfUnputKeyToGetTheResult();

                if (maxScore < score) maxScore = score;

                ClearWindow();

                MenuDraw();

                DrawText();

                DisplayWindow();

                Delay(1000);
            }
        }
    }
}
