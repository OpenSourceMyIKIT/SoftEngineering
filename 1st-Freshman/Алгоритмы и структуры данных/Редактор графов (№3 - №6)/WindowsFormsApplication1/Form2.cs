using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;                                            // Для работы с вводом-выводом
using System.Runtime.Serialization.Formatters.Binary;       // Легкий способ созранения в бинарный файл
using System.Drawing.Imaging;                               // Для сохранения картинки

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        int diameter = 20;           // Диаметр круга
        int lastVertexNumber = 0;    // Номер последней добавленной вершины
        int selectStep = 0;          // Этапы добавления связи
        int selectDelStep = 0;       // Этапы удаления связи
        int firstVert = -1;          // Номер первой выделенной вершины
        int secondVert = -1;         // Номер второй выделенной вершины
        double nLink = 0;            // Счетчик связей       
        int selectedVert = -1;
        public int currWeight = 0;   // Переменная для хранения веса связи, вводимого пользователем
        public int shortestPath1 = 0;// Номер первой вершины при вычислении кратчайшего пути
        public int shortestPath2 = 0;// Номер второй вершины при вычислении кратчайшего пути
        bool drag = false;           // Переменная, отвечающая за то, происходит ли перетаскивание вершины

        public bool ostovRegime = false;
        public int[] closest;

        string currFileName = "Unnamed"; // Файл, с которым работаем
        bool fileIsModified = false;     // Изменяется ли файл, как напоминание пользователю о необходимости сохранить

        class DoubleBufferedPanel : Panel
        {
            public DoubleBufferedPanel() : base()
            {
                DoubleBuffered = true;
            }
        }

        [Serializable]
        public struct Link
        {
            public int endVert;     // Номер вершины, в которую уходит связь
            public int ves;         // Вес ребра
        }

        [Serializable]
        public struct Vertex
        {
            public int number;       // Порядковый номер вершины
            public int x;            // Координата вершины x
            public int y;            // Координата вершины y
            public List<Link> links; // Список связей
            public bool mark;   // Пометка для вычисление остовного дерева минимальной стоимости
        }

        List<Vertex> vert = new List<Vertex>(); // Инициализация списка всех вершин

        public Form2()
        {
            InitializeComponent();
        }

        private void panel_MouseDown(object sender, MouseEventArgs e) //Событие клика по панели
        {
            #region Режим добавления вершины
            if (rbAddVertex.Checked) //Режим добавления вершины
            {
                Vertex tempVertex = new Vertex(); //Создание буферной переменной
                tempVertex.number = lastVertexNumber + 1; //Присваивание новой вершине порядкового номера
                tempVertex.x = e.X; //Запоминаем координаты вершины (центра круга)
                tempVertex.y = e.Y;
                tempVertex.links = new List<Link>(); //Инициализация списка связей

                vert.Add(tempVertex); //Добавление текущей сформированной вершины в общий список
                lastVertexNumber++; //Увеличение номера последней добавленной вершины
            }
            #endregion

            #region Режим удаление вершины
            if (rbDelVertex.Checked && vert.Count > 0) //Режим удаления вершин
            {
                for (int i = 0; i < vert.Count; i++) //Проверяем весь список вершин
                {
                    if (e.X < vert[i].x + diameter/2 && //Если текущие координаты клика мыши попали в область одной из вершин
                        e.X > vert[i].x - diameter/2 &&
                        e.Y < vert[i].y + diameter/2 &&
                        e.Y > vert[i].y - diameter/2)
                    {
                        vert[i].links.Clear(); //Очистка списка связей
                        for (int k = 0; k < vert.Count; k++) //Проход по списку вершин
                        {
                            for (int j = 0; j < vert[k].links.Count; j++) //Проход по списку связей каждой вершины
                            {
                                if (vert[k].links[j].endVert == vert[i].number) //Если одна из вершин имеет связь с выбранной вершиной,
                                {
                                    vert[k].links.RemoveAt(j); //то данная связь удаляется
                                }
                            }
                        }
                        vert.RemoveAt(i); //Удаление вершины из списка
                        break; //Нужная вершина удалена, выходим из цикла
                    }
                }
            }
            #endregion

            #region Режим добавления связей
            if (rbAddLink.Checked && vert.Count > 1) //Режим добавления связей
            {
                if (selectStep == 0)
                {
                    selectStep = 1;
                }

                for (int i = 0; i < vert.Count; i++) //Проверяем весь список вершин
                {
                    if (e.X < vert[i].x + diameter/2 && //Если клик был произведен в область одной из вершин
                        e.X > vert[i].x - diameter/2 &&
                        e.Y < vert[i].y + diameter/2 &&
                        e.Y > vert[i].y - diameter/2)
                    {
                        if (selectStep == 2 && firstVert != i) //Вторая вершина не совпадает с первой
                        {
                            bool linkExist = false; //Проверка на существование связей
                            for (int j = 0; j < vert[firstVert].links.Count; j++) //Перебор списка связей первой вершины
                            {
                                if (vert[firstVert].links[j].endVert == vert[i].number) //Если первая вершина имеет связь со второй
                                {
                                    linkExist = true; //Связь найдена
                                    break;
                                }
                            }

                            if (linkExist == false) //Если связи нет
                            {
                                secondVert = i; //Запоминаем вторую вершину
                                int doubleWeight = -1; // Проверка на существование обратной связи с запоминанием индекса в списке
                                
                                for (int l = 0; l < vert[secondVert].links.Count; l++)
                                {
                                    if (vert[secondVert].links[l].endVert == vert[firstVert].number)
                                        doubleWeight = l;
                                    //MessageBox.Show("Found!");
                                }

                                Link tempLink;  //Создание временного списка
                                tempLink.endVert = vert[i].number; //Добавление номера второй вершины
                                tempLink.ves = 0;

                                panel.Refresh();
                                selectStep = 0; //Заканчиваем процесс добавления связи                                
                                    

                                if (doubleWeight != -1)
                                {
                                    tempLink.ves = vert[secondVert].links[doubleWeight].ves;
                                }
                                else
                                {
                                    AddWeight addWeight = new AddWeight();
                                    addWeight.Owner = this;
                                    addWeight.ShowDialog();

                                    tempLink.ves = currWeight;
                                    currWeight = 0;
                                }

                                secondVert = -1;
                                vert[firstVert].links.Add(tempLink); //В список связей первой вершины добавляем информацию о второй вершине


                            }                            
                        }

                        if (selectStep == 2 && firstVert == i) //При щелчке по той же вершина обрываем процесс
                        {
                            selectStep = 0;
                        }

                        if (selectStep == 1) //Была выбраны одна вершина
                        {
                            firstVert = i;   //Запоминаем ее номер в списке
                            selectStep = 2;  //Переходим ко второму этапу построения связи
                        }
                        break; //Если выделенная вершина найдена, нет смысла искать дальше
                    }
                }
            }
            else
            {
                selectStep = 0;
            }
            #endregion

            #region Режим перемещения вершин
            if (rbDragVertex.Checked && vert.Count > 0)
            {
                drag = true;
                selectedVert = -1;
                for (int i = 0; i < vert.Count; i++) //Проверяем весь список вершин
                {
                    if (e.X < vert[i].x + diameter / 2 && //Если клик был произведен в область одной из вершин
                        e.X > vert[i].x - diameter / 2 &&
                        e.Y < vert[i].y + diameter / 2 &&
                        e.Y > vert[i].y - diameter / 2)
                    {
                        selectedVert = i;
                        break;
                    }
                }
            }
            #endregion

            #region Режим удаления связи
            if (rbDelLink.Checked && nLink > 0)
            {
                if (selectDelStep == 0)
                {
                    selectDelStep = 1;
                }

                for (int i = 0; i < vert.Count; i++) //Проверяем весь список вершин
                {
                    if (e.X < vert[i].x + diameter/2 && //Если клик был произведен в область одной из вершин
                        e.X > vert[i].x - diameter/2 &&
                        e.Y < vert[i].y + diameter/2 &&
                        e.Y > vert[i].y - diameter/2)
                    {
                        if (selectDelStep == 2 && firstVert != i) //Вторая вершина не совпадает с первой
                        {
                            int linkExist = -1; // Проверка на существование связей
                            for (int j = 0; j < vert[firstVert].links.Count; j++) // Перебор списка связей первой вершины
                            {
                                if (vert[firstVert].links[j].endVert == vert[i].number) // Если первая вершина имеет связь со второй
                                {
                                    linkExist = j; // Связь найдена (в одну сторону). Запоминаем номер в списке связей                                    
                                    break;
                                }
                            }

                            if (linkExist != -1)  // Если связь существует
                            {
                                secondVert = i; // Запоминаем номер в списке второй вершины

                                int doubleWeight = -1; // Проверка на существование обратной связи с запоминанием индекса в списке                                
                                for (int l = 0; l < vert[secondVert].links.Count; l++)
                                {
                                    if (vert[secondVert].links[l].endVert == vert[firstVert].number) // Если из второй вершины существует связь с первой
                                        doubleWeight = l;                                            // то запоминаем номер в списке связей
                                }

                                vert[firstVert].links.RemoveAt(linkExist); // Удаление найденой связи первой вершины со второй из списка 
                                // первой вершины                                  

                                if (doubleWeight != -1) // Если найдена и обратная связь: из второй в первую
                                {
                                    vert[secondVert].links.RemoveAt(doubleWeight); // то удаляем информацию о ней из списка связей второй вершины
                                }

                                secondVert = -1;
                                firstVert = -1;
                                panel.Refresh();
                                selectDelStep = 0; //Заканчиваем процесс добавления связи         
                            }
                            else
                            {
                                MessageBox.Show("Для выбранных вершин связи не существует");
                                firstVert = -1;
                                selectDelStep = 0; //Заканчиваем процесс добавления связи   
                            }
                        }

                        if (selectDelStep == 2 && firstVert == i) //При щелчке по той же вершина обрываем процесс
                        {
                            selectDelStep = 0;
                        }

                        if (selectDelStep == 1) // Была выбраны одна вершина
                        {
                            firstVert = i;      // Запоминаем ее номер первой вершины в списке
                            selectDelStep = 2;  // Переходим ко второму этапу построения связи
                        }
                        break;                  // Если выделенная вершина найдена, нет смысла искать дальше
                    }
                }
            }
            else
            {
                selectDelStep = 0;
            }            
            #endregion

            if (vert.Count == 0) //Если нет вершин
            {
                lastVertexNumber = 0;
            }
            panel.Refresh(); //Обновление панели
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            rbAddVertex.Checked = true;
            this.Text = "GraphCreator v1.0 [Unnamed]";
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            lbCoordinates.Text = "(" + e.X + "," + e.Y + ")"; //Вывод текущих координат

            if (drag && selectedVert >=0)
            {
                Vertex tempVertex = new Vertex(); //Создание временной вершины
                tempVertex.number = vert[selectedVert].number;
                tempVertex.links = vert[selectedVert].links;
                tempVertex.x = e.X; //Получение текущих координат движения мыши
                tempVertex.y = e.Y; //

                vert[selectedVert] = tempVertex; //Изменение перемещаемой вершины
                panel.Refresh();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Выход из приложения
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;          
            g.SmoothingMode = SmoothingMode.AntiAlias; //Сглаживаем графику

            Pen peroVertex = new Pen(Color.Silver); //Цвет границы вершин
            peroVertex.Width = 2;

            Pen peroWeight = new Pen(Color.White);
            peroWeight.Width = 2;

            Pen peroLink = new Pen(Color.LightCoral); // Цвет ребер
            peroLink.EndCap = LineCap.ArrowAnchor;    // Указываем окончание линии (ребра графа)
            peroLink.CustomEndCap = new AdjustableArrowCap(5, 5); // Настройка толщины стрелки

            Pen peroDoubleLink = new Pen(Color.LightCoral);  // Pen для прорисовки двойной связи

            Pen peroDoubleLinkOstov = new Pen(Color.FromArgb(46, 204, 113), 2);

            Brush fill = new SolidBrush(Color.Gainsboro);    // Цвет всех вершин
            Brush fillSelect = new SolidBrush(Color.Bisque); // Цвет текущей выбранной вершины
            Brush fillWeight = new SolidBrush(Color.White);  // Цвет прямоугольника под вес

            Brush textBrush = new SolidBrush(Color.Black);
            Font textFont = new Font("Century Gothic", 9, FontStyle.Regular);
            Font textWeightFont = new Font("Century Gothic", 11, FontStyle.Bold);
            

            StringFormat strAlignment = new StringFormat();
            strAlignment.Alignment = StringAlignment.Center;
            strAlignment.LineAlignment = StringAlignment.Center;
            nLink = 0;
            for (int i = 0; i < vert.Count; i++) // Проход по все вершинам в списке
            {
                g.DrawEllipse(peroVertex, vert[i].x - diameter / 2, vert[i].y - diameter / 2, diameter, diameter);

                if ((selectStep == 2 || selectDelStep == 2) && (i == firstVert || i == secondVert))
                {
                    g.FillEllipse(fillSelect, vert[i].x - diameter / 2, vert[i].y - diameter / 2, diameter, diameter); //Закрашивание выбранной вершины  
                }
                else
                {
                    g.FillEllipse(fill, vert[i].x - diameter / 2, vert[i].y - diameter / 2, diameter, diameter);
                }
                g.DrawString(vert[i].number.ToString(), textFont, textBrush, vert[i].x, vert[i].y, strAlignment);

                
                for (int j = 0; j < vert[i].links.Count; j++) // Проход по всем связям текущей вершины (прорисовка линий)
                {
                    double alpha = 0;
                    double x1, x2, y1, y2;
                    int xOffset, yOffset;

                    int fpos = vert.FindIndex( //Получение индекса вершины в которую уходит связь
                        delegate(Vertex fvert)
                        {
                            return fvert.number == vert[i].links[j].endVert;
                        }
                    );

                    x1 = vert[i].x;
                    y1 = vert[i].y;
                    x2 = vert[fpos].x;
                    y2 = vert[fpos].y;
                    double x3 = ((x2 + x1) / 2);
                    double y3 = ((y2 + y1) / 2);                 

                    alpha = Math.Atan(Math.Abs((x2 - x1) / (y2 - y1)));

                    xOffset = Math.Sign(x2 - x1) * Convert.ToInt32(Convert.ToDouble(diameter) / 2f * Math.Sin(alpha)); //
                    yOffset = Math.Sign(y2 - y1) * Convert.ToInt32(Convert.ToDouble(diameter) / 2f * Math.Cos(alpha));

                    bool m = false; // Флаг на существование двусторонней связи
                    for (int k = 0; k < vert[fpos].links.Count; k++) // Проход по всем связям второй текущей вершины
                    {
                        if (vert[i].number == vert[fpos].links[k].endVert)
                        {
                            m = true;
                            nLink = nLink - 0.5; // Ловушка для двойной связи
                        }
                    }
                                       
                    if (m) // Если двойная связь существует, то прорисовывается прямая линия, затем - переход к новой итерации цикла
                    {
                        if (ostovRegime)
                        {
                            if (closest[i] == fpos && closest[i] != -1)
                            {
                                g.DrawLine(peroDoubleLinkOstov, Convert.ToInt32(x1) + xOffset, Convert.ToInt32(y1) + yOffset,
                                Convert.ToInt32(x2) - xOffset, Convert.ToInt32(y2) - yOffset);
                                g.DrawRectangle(peroWeight, (float)(x3 - 10), (float)(y3 - 10), 20f, 20f);
                                g.FillRectangle(fillWeight, (float)(x3 - 10), (float)(y3 - 10), 20f, 20f);
                                g.DrawString(vert[i].links[j].ves.ToString(), textWeightFont, textBrush, (float)x3, (float)y3, strAlignment);
                            }
                        }
                        else
                        {
                            g.DrawLine(peroDoubleLink, Convert.ToInt32(x1) + xOffset, Convert.ToInt32(y1) + yOffset,
                            Convert.ToInt32(x2) - xOffset, Convert.ToInt32(y2) - yOffset);
                            g.DrawRectangle(peroWeight, (float)(x3 - 10), (float)(y3 - 10), 20f, 20f);
                            g.FillRectangle(fillWeight, (float)(x3 - 10), (float)(y3 - 10), 20f, 20f);
                            g.DrawString(vert[i].links[j].ves.ToString(), textWeightFont, textBrush, (float)x3, (float)y3, strAlignment);
                        }                        
                        nLink++;                       
                        continue;
                    }                    
                        g.DrawLine(peroLink, Convert.ToInt32(x1) + xOffset, Convert.ToInt32(y1) + yOffset,
                        Convert.ToInt32(x2) - xOffset, Convert.ToInt32(y2) - yOffset);
                        nLink++;
                        g.DrawRectangle(peroWeight, (float)(x3 - 10), (float)(y3 - 10), 20f, 20f);
                        g.FillRectangle(fillWeight, (float)(x3 - 10), (float)(y3 - 10), 20f, 20f);
                        g.DrawString(vert[i].links[j].ves.ToString(), textWeightFont, textBrush, (float)x3, (float)y3, strAlignment);                    
                }
            }
            lbNumVertex.Text = vert.Count.ToString(); // Вывод количества вершин
            lbNumLinks.Text = nLink.ToString();       // Вывод количества связей
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            vert.Clear(); //Очищение всего списка с вершинами
            dgv.Columns.Clear();
            dgv.Visible = false;
            lastVertexNumber = 0; //Обнуления счетчика номеров вершин
            panel.Refresh(); //Перерисовка панели
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
            panel.Refresh();
        }

        private void сохранитьВBMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectStep = 0; //Прерываем процесс выбора вершины

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Сохранить в BMP"; //Заголовок о
            saveDialog.InitialDirectory = Application.StartupPath; //По умолчанию файл будет сохраняться там, где лежит exe-шник
            saveDialog.Filter = "Файлы *.bmp|*.bmp"; 

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(panel.Width, panel.Height); //Задаем размеры сохраняемого изображения
                panel.DrawToBitmap(bmp, new Rectangle(0, 0, panel.Width, panel.Height)); //
                bmp.Save(saveDialog.FileName, ImageFormat.Bmp);
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectStep = 0;

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Сохранть граф";
            saveDialog.InitialDirectory = Application.StartupPath;
            saveDialog.Filter = "Файл граф (*.gph)|*.gph";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveDialog.FileName != "")
                {
                    try
                    {
                        using (Stream stream = File.Open(saveDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            bin.Serialize(stream, vert);
                            MessageBox.Show("Файл успешно сохранен");
                            currFileName = saveDialog.FileName;
                            this.Text = currFileName;
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Невозможно сохранить файл", "Ошибка");
                    }
                }
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Открыть граф";
            openDialog.InitialDirectory = Application.StartupPath;
            openDialog.Filter = "Файл графа (*.gph)|*.gph";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                if (openDialog.FileName != "")
                {
                    try
                    {
                        using (Stream stream = File.Open(openDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            vert.Clear();
                            BinaryFormatter bin = new BinaryFormatter();
                            vert = (List<Vertex>)bin.Deserialize(stream);
                            panel.Refresh();
                            MessageBox.Show("Файл успешно загружен");
                            currFileName = openDialog.SafeFileName;
                            this.Text = "GraphCreator v1.0 [" + currFileName + "]";
                            dgv.Columns.Clear();
                            dgv.Visible = false;
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            openDialog.Dispose();            
            lastVertexNumber = vert[vert.Count-1].number;
        }

        private void btnShortestPath_Click(object sender, EventArgs e)
        {
            if (vert.Count >= 2)
            {
                dgv.Columns.Clear();
                int n = vert.Count;
                int[,] A = new int[n, n];
                int[,] B = new int[n, n];

                #region Заполнение матрицы начальными значениями
                for (int i = 0; i < n; ++i)
                    for (int j = 0; j < n; ++j)
                    {
                        if (i != j)
                        {
                            bool islink = false;
                            for (int l = 0; l < vert[i].links.Count; ++l)
                            {
                                if (vert[i].links[l].endVert == vert[j].number)
                                {
                                    A[i, j] = vert[i].links[l].ves;
                                    islink = true;
                                    break;                              // Выходим из цикла, так как нужная связь уже найдена
                                }
                            }
                            if (!islink)
                                A[i, j] = Int32.MaxValue / 3; // Бесконечность
                        }
                        else
                            A[i, j] = 0;
                    }
                #endregion                

                #region Вычисление кратчайших путей для всех вершин
                for (int k = 0; k < n; ++k)
                {
                    for (int i = 0; i < n; ++i)
                        for (int j = 0; j < vert.Count; ++j)
                        {
                            if (i != j)
                            {
                                if (A[i, k] + A[k, j] < A[i, j])
                                    B[i, j] = A[i, k] + A[k, j];
                                else
                                    B[i, j] = A[i, j];
                            }
                            else
                                B[i, j] = 0;
                        }                    
                    A = B;                    
                }
                #endregion

                TheShortestPath sp = new TheShortestPath();
                sp.Owner = this;
                sp.ShowDialog();

                try
                {
                    if (A[shortestPath1 - 1, shortestPath2 - 1] != Int32.MaxValue / 3)
                        MessageBox.Show("Кратчайший путь между вершинами: " + A[shortestPath1 - 1, shortestPath2 - 1], "Результат получен");
                    else
                        MessageBox.Show("Пути не существует");
                }
                catch
                {
                    MessageBox.Show("Одна из выбранных вершин не существует");
                }

                shortestPath1 = 0;
                shortestPath2 = 0;

                #region Вывод результирующей матрицы в DataGridView
                dgv.Visible = true;                                 
                for (int i = 0; i < n; ++i)
                {
                    dgv.Columns.Add((i + 1).ToString(), (i + 1).ToString());
                    dgv.Columns[i].Width = 42;
                }
                for (int i = 0; i < n; ++i)
                {
                    dgv.Rows.Add();
                    for (int j = 0; j < n; ++j)
                        if (A[i, j] == Int32.MaxValue / 3)
                            dgv.Rows[i].Cells[j].Value = System.Double.PositiveInfinity;
                        else
                            dgv.Rows[i].Cells[j].Value = A[i,j].ToString();
                }
                #endregion
            }
            else
                MessageBox.Show("Недосаточно данных для вычислений. Добавьте вершины и связи");
        }

        private void btnMinTree_Click(object sender, EventArgs e)
        {
            if (vert.Count > 1)
            {
                dgv.Columns.Clear();
                dgv.Visible = false;
                ostovRegime = true;

                int n = vert.Count;
                List<Vertex> U = new List<Vertex>(); // Множество вершин, формирующих остовное дерево минимальной стоимости                
                U.Add(vert[0]);                      // Добавление первой вершины
                closest = new int[n];                // Массив closest[i] для каждой вершины i содержит вершину, с которой он соединен ребром минимальной стоимости
                for (int i = 0; i < closest.Length; ++i)
                    closest[i] = -1;          
                bool[] used = new bool[n];           // used[i] равна true, если вершина i уже внесена в остов
                used[0] = true;                      // Первая вершина внесена в остов                

                try
                {
                    while (U.Count < n)              // Пока в множество вершин дерева не войдут все вершины графа
                    {                        
                        int tmpFirstOstov = 0;
                        int tmpSecondOstov = -1;
                        Double min = Double.PositiveInfinity;
                        for (int i = 0; i < U.Count; ++i)
                            for (int j = 0; j < U[i].links.Count; ++j)
                            {
                                if (used[U[i].links[j].endVert - 1] == false && U[i].links[j].ves < min)
                                {
                                    min = U[i].links[j].ves;
                                    tmpSecondOstov = U[i].links[j].endVert - 1; // Сохранение индекса вершины, которая имеет минимальное ребро с данной
                                    tmpFirstOstov = U[i].number - 1;            // Сохранение индекса первой вершины
                                }
                            }
                        panel.Refresh();
                        U.Add(vert[tmpSecondOstov]);      // Добавление новой вершины в остов
                        used[tmpSecondOstov] = true;      // Помечаем вершину как добавленную
                        if (closest[tmpFirstOstov] == -1) // Не изменялось
                            closest[tmpFirstOstov] = tmpSecondOstov;
                        else
                            closest[tmpSecondOstov] = tmpFirstOstov;
                        
                    }
                    panel.Refresh();
                }
                catch
                {
                    MessageBox.Show("Произошло изменение данных. Программа не сможет правильно выполнить указанное действие.");
                }                
                ostovRegime = false;
            }
            else
                MessageBox.Show("Недостаточно данных для вычислений. Добавьте вершины и связи");
        }
    }
}