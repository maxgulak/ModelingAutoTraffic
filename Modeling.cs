using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModelingAutoTraffic
{
    public partial class Modeling : Form
    {
        private int CountWays;
        private int CountLines;
        private int TimeTrafficLight;
        private string roadType;
        private bool trigger = false;
        private bool _isStopped = false;
        private bool isTonnel = false;

        int wid, y, y1, speed_x = 3, speed_x1 = 4;
        int x1 = -10;
        int x = 300;
        int count = 0;
        Timer timer = new Timer();

        private int _minSpeed = MIN_SPEED_CITY;
        private int _maxSpeed = MAX_SPEED_CITY;

        private bool isReverseStopped = false;
        private bool isFirstRigthStopped = false;


        private TransportSettingModel _typeTransport;
        private TransportSettingModel _speedTransport;

        private SignumSpeed _currentSignumSpeed;

        
        private SignumSpeed _lastUpImageSignumSpeed;

        
        private SignumSpeed _lastDownImageSignumSpeed;

        
        private const int MIN_SPEED_CITY = 5;
        private const int MAX_SPEED_CITY = 7;

        private const int MIN_SPEED_TONNEL = 3;
        private const int MAX_SPEED_TONNEL = 5;

        private const int OFFSET_CAR_STOP = 100;
        private const string NAME_UP_SIGNUM = "Up";
        private const string NAME_DOWN_SIGNUM = "Down";
        private List<List<Car>> _reverseCars;
        private List<List<Car>> _cars;


        private const int OFFSET_MOUSE_POSTION = 70;
 
        private Point _pointUpSignum;

        private Point _pointDownSignum;
 
        private List<(System.Windows.Forms.Label, Car)> _timersAppearsCar;

  
        private const int POSITION_X_TIMER_CARS = 30;
     
        private const int POSITION_X_TIMER_REVERSE_CARS = 1050;

        private List<(System.Windows.Forms.Label, Car)> _timersAppearsReverseCar;

     
        private System.Windows.Forms.Label _timerUpTonnel;

  
        private System.Windows.Forms.Label _timerDownTonnel;

    
        private float _timerUpTonnelValue;


        private float _timerDownTonnelValue;

        Font speedFont = new Font("Microsoft Comic Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));


        public string setRoaType
        {
            set { roadType = value; }
        }
        public int setCountLines
        {
            set { CountLines = value; }
        }
        public int setCountWays
        {
            set { CountWays = value; }
        }
        public int setTimeTrafficLight
        {
            set { TimeTrafficLight = value; }
        }

        public Modeling()
        {
            InitializeComponent();

            _currentSignumSpeed = null;
            _lastUpImageSignumSpeed = null;
            _lastDownImageSignumSpeed = null;
            _typeTransport = new TransportSettingModel()
            {
                IsDeterminate = true,
                DeterminateInterval = 2,
                IsRandom = false
            };
            _speedTransport = new TransportSettingModel()
            {
                IsDeterminate = true,
                DeterminateInterval = 80,
                IsRandom = false
            };
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        public void SettingFormClosed(object sender, FormClosedEventArgs e)
        {
            var form = (OptionsForm)sender;
            _typeTransport = form.TypeTransport;
            _speedTransport = form.SpeedTransport;
        }

        private void Modeling_Load(object sender, EventArgs e)
        {
            _timersAppearsCar = new List<(Label, Car)>();
            _timersAppearsReverseCar = new List<(Label, Car)>();

            PaintRoad();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            OptionsForm sett_form = new OptionsForm(_typeTransport, _speedTransport);
            sett_form.FormClosed += new FormClosedEventHandler(SettingFormClosed);
            sett_form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!DesignMode && !trigger)
            {
                timer.Interval = 30;
                timer.Tick += new EventHandler(timer1_FirstTick);
                timer.Tick += new EventHandler(timer1_SecondTick);
                timer.Start();

                if (isTonnel)
                {
                    timerUpLigth.Interval = 10;
                    timerUpLigth.Tick += new EventHandler(timerUpLigthTick);
                    timerUpLigth.Start();

                    timerDownLigth.Interval = 10;
                    timerDownLigth.Tick += new EventHandler(timerDownLigthTick);
                    timerDownLigth.Start();
                }
            }
            trigger = true;
            _isStopped = false;
        }
        

        private void buttonPause_Click(object sender, EventArgs e)
        {
            _isStopped = true;
            timerTrafficLight.Tick -= new EventHandler(StopCars);

            timer.Tick -= new EventHandler(timer1_FirstTick);
            timer.Tick -= new EventHandler(timer1_SecondTick);
            trigger = false;
            timer.Stop();

            timerUpLigth.Tick -= new EventHandler(timerUpLigthTick);
            timerUpLigth.Stop();

            timerDownLigth.Tick -= new EventHandler(timerDownLigthTick);
            timerDownLigth.Stop();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            wid = ((pictureBox1.Height / (CountLines * CountWays)) - 20);
            if (!DesignMode)
            {
                g = e.Graphics;
                if (trigger)
                {
                    for (int j = 0; j < _cars.Count; j++)
                    {
                        foreach (var item in _cars[j])
                        {
                            e.Graphics.DrawIcon(item.IconCar, item.cur_x, item.cur_y);

                            e.Graphics.DrawString($"{item.speed * 10}", speedFont, Brushes.Yellow, item.cur_x + 15, item.cur_y);
                        }
                    }
                    for (int j = 0; j < _reverseCars.Count; j++)
                    {
                        foreach (var item in _reverseCars[j])
                        {
                            e.Graphics.DrawIcon(item.IconCar, item.cur_x, item.cur_y);

                            e.Graphics.DrawString($"{item.speed * 10}", speedFont, Brushes.Yellow, item.cur_x, item.cur_y);
                        }
                    }
                    if (x >= pictureBox1.Width / 8 || count > 0)
                    {
                    }
                    base.OnPaint(e);
                }
            }
            SetColorLights(e.Graphics);
        }

        private void TimerSignumTick(object sender, EventArgs e)
        {
            PictureBox pictureBox;

            var globalMouse = Cursor.Position;
            var controlPosition = this.Location;

            var rigthLocationX = globalMouse.X - controlPosition.X - 15;
            var rigthLocationY = globalMouse.Y - controlPosition.Y - 35;

            if (CountWays == 1)
            {
                pictureBox = Controls[NAME_UP_SIGNUM] as PictureBox;

                if (rigthLocationX < 70 || rigthLocationX > pictureBox1.Width + 20)
                {
                    rigthLocationX = pictureBox.Location.X;
                }

                pictureBox.Location = new Point(rigthLocationX, pictureBox.Location.Y);
                pictureBox.BackgroundImage = _currentSignumSpeed?.ImageSignum;
                pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                Refresh();
            }
            else
            {
                if (rigthLocationY < 200)
                {
                    pictureBox = Controls[NAME_UP_SIGNUM] as PictureBox;

                    var picture = Controls[NAME_DOWN_SIGNUM] as PictureBox;
                    picture.Location = _pointDownSignum;
                }
                else
                {
                    pictureBox = Controls[NAME_DOWN_SIGNUM] as PictureBox;

                    var picture = Controls[NAME_UP_SIGNUM] as PictureBox;
                    picture.Location = _pointUpSignum;
                }

                if (rigthLocationX < 70 || rigthLocationX > pictureBox1.Width + 20)
                {
                    rigthLocationX = pictureBox.Location.X;
                }

                pictureBox.Location = new Point(rigthLocationX, pictureBox.Location.Y);
                pictureBox.BackgroundImage = _currentSignumSpeed?.ImageSignum;
                pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                Refresh();
            }
        }

        private void PictureSpeedLimitFirstPaint(object sender, PaintEventArgs e)
        {
            var nameSign = "60.png";

            if (roadType != "Тоннель")
            {
                e.Graphics.DrawImage(Image.FromFile(nameSign), 0, 0, 40, 40);
            }

            base.OnPaint(e);
        }

        private void pictureSpeedLimitFirst_Click(object sender, EventArgs e)
        {
            timerSignum.Interval = 30;
            timerSignum.Tick += new EventHandler(TimerSignumTick);
            timerSignum.Start();

            var nameSign = "60.png";
            var speedSign = 60;

            _currentSignumSpeed = new SignumSpeed()
            {
                ImageSignum = Image.FromFile(nameSign),
                Speed = speedSign
            };
        }

        private void PictureSpeedLimitSecondPaint(object sender, PaintEventArgs e)
        {
            var nameSign = "70.png";
            if (roadType != "Тоннель")
            {
                e.Graphics.DrawImage(Image.FromFile(nameSign), 0, 0, 40, 40);
            }
            base.OnPaint(e);
        }
        private void pictureSpeedLimitSecond_Click(object sender, EventArgs e)
        {
            timerSignum.Interval = 30;
            timerSignum.Tick += new EventHandler(TimerSignumTick);
            timerSignum.Start();

            var nameSign = "70.png";
            var speedSign = 70;

            _currentSignumSpeed = new SignumSpeed()
            {
                ImageSignum = Image.FromFile(nameSign),
                Speed = speedSign
            };
        }
        private void PictureSpeedLimitThirdPaint(object sender, PaintEventArgs e)
        {
            var nameSign = "80.png";

            if (roadType != "Тоннель")
            {
                e.Graphics.DrawImage(Image.FromFile(nameSign), 0, 0, 40, 40);
            }

            base.OnPaint(e);
        }
        private void pictureSpeedLimitThird_Click(object sender, EventArgs e)
        {
            timerSignum.Interval = 30;
            timerSignum.Tick += new EventHandler(TimerSignumTick);
            timerSignum.Start();

            var nameSign = "80.png";

            var speedSign = 80;

            _currentSignumSpeed = new SignumSpeed()
            {
                ImageSignum = Image.FromFile(nameSign),
                Speed = speedSign
            };
        }
        private void PictureSpeedLimitFourthPaint(object sender, PaintEventArgs e)
        {
            var nameSign = "90.png";

            if (roadType != "Тоннель")
            {
                e.Graphics.DrawImage(Image.FromFile(nameSign), 0, 0, 40, 40);
            }

            base.OnPaint(e);
        }
        private void pictureSpeedLimitFirstFourth_Click(object sender, EventArgs e)
        {
            timerSignum.Interval = 30;
            timerSignum.Tick += new EventHandler(TimerSignumTick);
            timerSignum.Start();

            var nameSign = "90.png";
            var speedSign = 90;

            _currentSignumSpeed = new SignumSpeed()
            {
                ImageSignum = Image.FromFile(nameSign),
                Speed = speedSign
            };
        }

        private void PictureSpeedLimitFifthPaint(object sender, PaintEventArgs e)
        {
            var nameSign = "100.png";

            if (roadType != "Тоннель")
            {
                e.Graphics.DrawImage(Image.FromFile(nameSign), 0, 0, 40, 40);
            }

            base.OnPaint(e);
        }
        private void pictureSpeedLimitFirstFifth_Click(object sender, EventArgs e)
        {
            timerSignum.Interval = 30;
            timerSignum.Tick += new EventHandler(TimerSignumTick);
            timerSignum.Start();

            var nameSign = "100.png";
            var speedSign = 100;

            _currentSignumSpeed = new SignumSpeed()
            {
                ImageSignum = Image.FromFile(nameSign),
                Speed = speedSign
            };
        }
        private void PictureSpeedLimitMouseClick(object sender, EventArgs e)
        {
            var pictureBox = (PictureBox)sender;

            if (CountWays == 1)
            {
                if (pictureBox.Name == NAME_UP_SIGNUM)
                {
                    _lastUpImageSignumSpeed = _currentSignumSpeed;
                    _pointUpSignum = pictureBox.Location;
                }
            }
            else
            {
                if (pictureBox.Name == NAME_UP_SIGNUM)
                {
                    _lastUpImageSignumSpeed = _currentSignumSpeed;
                    _pointUpSignum = pictureBox.Location;
                }
                if (pictureBox.Name == NAME_DOWN_SIGNUM)
                {
                    _lastDownImageSignumSpeed = _currentSignumSpeed;
                    _pointDownSignum = pictureBox.Location;
                }
            }

            timerSignum.Tick -= new EventHandler(TimerSignumTick);
            timerSignum.Stop();
        }
        private void PictureSpeedLimitMouseDoubleClick(object sender, EventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            if (pictureBox.Name == NAME_UP_SIGNUM)
            {
                _lastUpImageSignumSpeed = null;
                pictureBox.BackgroundImage = null;
            }
            else
            {
                _lastDownImageSignumSpeed = null;
                pictureBox.BackgroundImage = null;
            }
        }

        private void SetUpTimers()
        {
            for (int j = 0; j < _cars.Count; j++)
            {
                if (_timersAppearsCar[j].Item2 == null || _timersAppearsCar[j].Item2.isGenerate)
                {
                    for (var i = 0; i < _cars[j].Count; i++)
                    {
                        if (!_cars[j][i].isGenerate)
                        {
                            var timerValue = (100 - _cars[j][i].cur_x) / _cars[j][i].speed;

                            var item = _timersAppearsCar[j];

                            item.Item1.Text = timerValue.ToString();
                            item.Item2 = _cars[j][i];

                            _timersAppearsCar[j] = item;

                            break;
                        }
                        else
                        {
                            _timersAppearsCar[j].Item1.Text = "0";
                        }
                    }
                }
                else
                {
                    var car = _timersAppearsCar[j].Item2;

                    var timerValue = ((-car.cur_x) / car.speed) * 0.31;
                    timerValue = Math.Round(timerValue / 10, 1);

                    _timersAppearsCar[j].Item1.Text = timerValue.ToString();
                }
            }
        }


        private void SetDownTimers()
        {
            for (int j = 0; j < _reverseCars.Count; j++)
            {
                if (_timersAppearsReverseCar[j].Item2 == null || _timersAppearsReverseCar[j].Item2.isGenerate)
                {
                    for (var i = 0; i < _reverseCars[j].Count; i++)
                    {
                        if (!_reverseCars[j][i].isGenerate)
                        {
                            var timerValue = (_reverseCars[j][i].cur_x - 100) / _reverseCars[j][i].speed;

                            var item = _timersAppearsReverseCar[j];

                            item.Item1.Text = timerValue.ToString();
                            item.Item2 = _reverseCars[j][i];

                            _timersAppearsReverseCar[j] = item;

                            break;
                        }
                        else
                        {
                            _timersAppearsReverseCar[j].Item1.Text = "0";
                        }
                    }
                }
                else
                {
                    var car = _timersAppearsReverseCar[j].Item2;

                    var timerValue = ((car.cur_x - pictureBox1.Width - 0) / car.speed) * 0.31;
                    timerValue = Math.Round(timerValue / 10, 1);

                    _timersAppearsReverseCar[j].Item1.Text = timerValue.ToString();
                }
            }
        }

        Graphics g;
        private void timer1_FirstTick(object sender, EventArgs e)
        {
            SetUpTimers();

            for (int j = 0; j < _cars.Count; j++)
            {
                for (var i = 0; i < _cars[j].Count; i++)
                {
                    if (_cars[j][i].cur_x > 10 && !_cars[j][i].isGenerate)
                    {
                        _cars[j][i].isGenerate = true;

                        var index = new Random().Next(0, _cars.Count);

                        GenerateCars(_cars[j][i].cur_x, _cars[index][0].cur_y, index, true);
                    }
                    if (_cars[j][i].cur_x + _cars[j][i].speed < _cars[j][i].goal_x)
                    {
                        if (_cars[j][i].cur_x > _pointUpSignum.X - wid * 2 &&
                            _lastUpImageSignumSpeed != null &&
                            _cars[j][i].speed > _lastUpImageSignumSpeed.Speed / 10)
                        {
                            _cars[j][i].speed = _lastUpImageSignumSpeed.Speed / 10;
                        }

                        _cars[j][i].cur_x += _cars[j][i].speed;
                    }

                    if (_cars[j][i].cur_x > 9900)
                    {
                        _cars[j].Remove(_cars[j][i]);
                    }
                }
            }
            this.Refresh();
        }
        private void timer1_SecondTick(object sender, EventArgs e)
        {
            SetDownTimers();

            for (int j = 0; j < _reverseCars.Count; j++)
            {
                for (var i = 0; i < _reverseCars[j].Count; i++)
                {
                    // Если авто появилось на экране и из-за неё еще не генерировалась новая машина,
                    // то создаем новую на расстоянии соответсвующем закону распределения.
                    if (_reverseCars[j][i].cur_x < 0 + pictureBox1.Width && !_reverseCars[j][i].isGenerate)
                    {
                        _reverseCars[j][i].isGenerate = true;

                        var index = new Random().Next(0, _reverseCars.Count);

                        GenerateCars(_reverseCars[j][i].cur_x, _reverseCars[index][0].cur_y, index, false);
                    }
                    // Изменяем позицию согласно скорости авто
                    if (_reverseCars[j][i].cur_x - _reverseCars[j][i].speed > _reverseCars[j][i].goal_x)
                    {
                        if (_reverseCars[j][i].cur_x < _pointDownSignum.X + 10 &&
                            _lastDownImageSignumSpeed != null &&
                            _reverseCars[j][i].speed > _lastDownImageSignumSpeed.Speed / 10)
                        {
                            _reverseCars[j][i].speed = _lastDownImageSignumSpeed.Speed / 10;
                        }

                        _reverseCars[j][i].cur_x -= _reverseCars[j][i].speed;
                    }
                    // Если авто удалилось от экрана слишком далеко, удаляем его
                    if (_reverseCars[j][i].cur_x < -9900)
                    {
                        _reverseCars[j].Remove(_reverseCars[j][i]);
                    }
                }
            }
            this.Refresh();
        }

        private void StopCars(object sender, EventArgs e)
        {
            _timerUpTonnelValue = (TimeTrafficLight == 0)
                            ? 3
                            : TimeTrafficLight;

            _timerDownTonnelValue = (TimeTrafficLight == 0)
                ? 3
                : TimeTrafficLight;

            // Останавливаем нижний поток машин.
            if (isReverseStopped)
            {
                SetStoppedDownThread();
            }
            // Останавливаем верхний поток машин.
            else
            {
                SetStoppedUpThread();
            }
        }

        private void SetStoppedDownThread()
        {
            // Запускаем машины сверху
            for (int i = 0; i < _cars[0].Count; i++)
            {
                _cars[0][i].goal_x = 10_000;
            }
            // Останавливаем нижний поток
            var centerX = pictureBox1.Width - 150;

            for (int i = 0; i < _reverseCars[0].Count; i++)
            {
                if (_reverseCars[0][i].cur_x > centerX)
                {
                    if (i == 0)
                    {
                        _reverseCars[0][i].goal_x = centerX - 1;
                    }
                    else if (_reverseCars[0][i - 1].cur_x < centerX)
                    {
                        _reverseCars[0][i].goal_x = centerX - 1;
                    }
                    else if (_reverseCars[0][i].goal_x != _reverseCars[0][i - 1].goal_x + OFFSET_CAR_STOP)
                    {
                        _reverseCars[0][i].goal_x = _reverseCars[0][i - 1].goal_x + OFFSET_CAR_STOP + 1;
                    }
                }
            }
            isReverseStopped = false;
        }


        private void SetStoppedUpThread()
        {
            // Запускаем машины снизу
            for (int i = 0; i < _reverseCars[0].Count; i++)
            {
                _reverseCars[0][i].goal_x = -10_000;
            }
            // Останавливаем верхний поток
            var centerX = 85;

            for (int i = 0; i < _cars[0].Count; i++)
            {
                if (_cars[0][i].cur_x < centerX)
                {
                    if (i == 0)
                    {
                        _cars[0][i].goal_x = centerX + 1;
                    }
                    else if (i != 0 && _cars[0][i - 1].cur_x > centerX)
                    {
                        _cars[0][i].goal_x = centerX - 1;
                    }
                    else if (_cars[0][i].goal_x != _cars[0][i - 1].goal_x - OFFSET_CAR_STOP)
                    {
                        _cars[0][i].goal_x = _cars[0][i - 1].goal_x - OFFSET_CAR_STOP - 1;
                    }
                }
            }
            isReverseStopped = true;
        }

        private void SetColorLights(Graphics g)
        {
            if (!isTonnel)
            {
                return;
            }
            // Останавливаем нижний поток машин.
            if (isReverseStopped)
            {
                g.FillEllipse(Brushes.Red, 150, 5, 17, 17);
                g.FillEllipse(Brushes.Gray, 150, 23, 17, 17);

                g.FillEllipse(Brushes.Gray, pictureBox1.Width - 170, pictureBox1.Height - 40, 17, 17);
                g.FillEllipse(Brushes.Green, pictureBox1.Width - 170, pictureBox1.Height - 22, 17, 17);
            }
            // Останавливаем верхний поток машин.
            else
            {
                g.FillEllipse(Brushes.Gray, 150, 5, 17, 17);
                g.FillEllipse(Brushes.Green, 150, 23, 17, 17);

                g.FillEllipse(Brushes.Red, pictureBox1.Width - 170, pictureBox1.Height - 40, 17, 17);
                g.FillEllipse(Brushes.Gray, pictureBox1.Width - 170, pictureBox1.Height - 22, 17, 17);
            }
        }

        /// <summary>
        /// Создать новую машину.
        /// </summary>
        /// <param name="x">Позиция Х.</param>
        /// <param name="y">Позиция Y.</param>
        /// <param name="index">Индекс полосы для генерации машины.</param>
        /// <param name="isReverse">Генерировать ли авто в противоположную сторону.</param>
        private void GenerateCars(int x, int y, int index, bool isReverse)
        {
            var positionX = 0f;

            if (_typeTransport.IsDeterminate)
            {
                positionX = (float)(5 / 0.03) * _typeTransport.DeterminateInterval;
            }
            else if (_typeTransport.IsRandom)
            {
                switch (_typeTransport.Law)
                {
                    case "Нормальный":
                        var t = new Random().NextDouble();
                        positionX = (float)(1 / Math.Sqrt(2 * Math.PI * Math.Pow(_typeTransport.RandomDispersion, 2)) * Math.Exp(-Math.Pow((t - _typeTransport.MathExpectation), 2) / 2 * _typeTransport.RandomDispersion));
                        break;
                    case "Равномерный":
                        t = new Random().NextDouble();
                        positionX = (float)((t - _typeTransport.StartInterval) / (_typeTransport.EndInterval - _typeTransport.StartInterval));
                        break;
                    case "Показательный":
                        t = new Random().NextDouble();
                        positionX = (float)(1 - Math.Exp(-_typeTransport.Intensity * t));
                        break;
                }
            }
            else
            {
                positionX = 100f;
            }
            var speed = 0f;
            if (_speedTransport.IsDeterminate)
            {
                speed = (float)_speedTransport.DeterminateInterval / 10f;
            }
            else if (_speedTransport.IsRandom)
            {
                switch (_speedTransport.Law)
                {
                    case "Нормальный":
                        var t = new Random().NextDouble();
                        speed = (float)(1 / Math.Sqrt(2 * Math.PI * Math.Pow(_speedTransport.RandomDispersion, 2)) * Math.Exp(-Math.Pow((t - _speedTransport.MathExpectation), 2) / 2 * _speedTransport.RandomDispersion));
                        break;
                    case "Равномерный":
                        t = new Random().NextDouble();
                        speed = (float)((t - _speedTransport.StartInterval) / (_speedTransport.EndInterval - _speedTransport.StartInterval));
                        break;
                    case "Показательный":
                        t = new Random().NextDouble();
                        speed = (float)(1 - Math.Exp(-_speedTransport.Intensity * t));
                        break;
                }
            }
            else
            {
                speed = 3f;
            }

            var car = new Car(wid, false);
            car.start_y = y;
            car.cur_y = y;
            car.speed = (int)speed;

            if (isReverse)
            {
                var coordX = (int)(x - positionX - 100);
                if (Math.Abs(_cars[index].Last().cur_x - coordX) < wid * 2)
                {
                    coordX -= wid * 2;
                }
                car.start_x = coordX;
                car.cur_x = coordX;
                car.SetIcon(false);

                if (_cars[index].Last().goal_x != 10_000)
                {
                    car.goal_x = _cars[index].Last().goal_x - OFFSET_CAR_STOP;
                }
                _cars[index].Add(car);
            }
            else
            {
                var coordX = (int)(x + positionX + 100);
                if (Math.Abs(_reverseCars[index].Last().cur_x - coordX) < wid * 2)
                {
                    coordX += wid * 2;
                }
                car.start_x = coordX;
                car.cur_x = coordX;
                car.goal_x *= -1;
                car.SetIcon(true);

                if (_reverseCars[index].Last().goal_x != -10_000)
                {
                    car.goal_x = _reverseCars[index].Last().goal_x + OFFSET_CAR_STOP;
                }
                _reverseCars[index].Add(car);
            }
        }

        /// <summary>
        /// Установить знаки на ограничение скорости.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void SetSignum(int x, int y, string name)
        {
            if (name == NAME_UP_SIGNUM)
            {
                _pointUpSignum = new Point(x, y);
            }
            else
            {
                _pointDownSignum = new Point(x, y);
            }

            var picture = new PictureBox();
            picture.Name = name;
            picture.Size = new Size(32, 32);
            picture.Location = new Point(x, y);
            picture.MouseClick += PictureSpeedLimitMouseClick;
            picture.MouseDoubleClick += PictureSpeedLimitMouseDoubleClick;
            picture.BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(picture);
            picture.BringToFront();
        }

        /// <summary>
        /// Установить label'ы для таймеров светофоров.
        /// </summary>
        private void SetTimerLight()
        {
            _timerUpTonnel = new Label();
            _timerUpTonnel.Text = "0";
            _timerUpTonnel.Location = new Point(210, 60);

            _timerDownTonnel = new Label();
            _timerDownTonnel.Text = "0";
            _timerDownTonnel.Location = new Point(865, 580);

            Controls.Add(_timerUpTonnel);
            Controls.Add(_timerDownTonnel);
        }

        /// <summary>
        /// Обработчик тиков верхнего таймера.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerUpLigthTick(object sender, EventArgs e)
        {
            _timerUpTonnelValue -= 0.015f;

            if (_timerUpTonnelValue < 0)
            {
                _timerUpTonnelValue = (TimeTrafficLight == 0)
                    ? 3f
                    : TimeTrafficLight;
            }

            _timerUpTonnel.Text = $"{Math.Round(_timerUpTonnelValue, 1)}";
        }

        /// <summary>
        /// Обработчик тиков нижнего таймера.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDownLigthTick(object sender, EventArgs e)
        {
            _timerDownTonnelValue -= 0.015f;

            if (_timerDownTonnelValue < 0)
            {
                _timerDownTonnelValue = (TimeTrafficLight == 0)
                    ? 3f
                    : TimeTrafficLight;
            }

            _timerDownTonnel.Text = $"{Math.Round(_timerDownTonnelValue, 1)}";
        }

        private void PaintRoad()
        {
            Menu form1 = new Menu();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            using (g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(Color.Black);
                var firstCoord = 0;
                var secondCoord = 0;
                Pen p1 = new Pen(Color.White, 4);
                switch (roadType)
                {
                    case "Автострада":
                        pictureSpeedLimitFirst.Visible = true;
                        pictureSpeedLimitSecond.Visible = true;
                        pictureSpeedLimitThird.Visible = true;
                        pictureSpeedLimitFourth.Visible = true;

                        SetSignum(pictureBox1.Location.X, 60, NAME_UP_SIGNUM); 
                        SetSignum(pictureBox1.Location.X, 560, NAME_DOWN_SIGNUM);

                        _minSpeed = MIN_SPEED_CITY;
                        _maxSpeed = MAX_SPEED_CITY;
                        isTonnel = false;
                        Pen p = new Pen(Color.White, 4);
                        Pen pen = new Pen(Color.Gray, 20);
                        p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                        g.DrawLine(pen, 0, 0, pictureBox1.Width, 0);
                        g.DrawLine(pen, 0, pictureBox1.Height, pictureBox1.Width, pictureBox1.Height);
                        for (int i = 1; i < CountLines * CountWays; i++)
                        {
                            if (CountWays > 1 && i == CountLines)
                            {
                                firstCoord = (i * pictureBox1.Height / (CountLines * CountWays)) - 5;
                                secondCoord = (i * pictureBox1.Height / (CountLines * CountWays)) + 5;

                                g.DrawLine(p1, 0, firstCoord, pictureBox1.Width - 1, firstCoord);
                                g.DrawLine(p1, 0, secondCoord, pictureBox1.Width - 1, secondCoord);
                                continue;
                            }
                            else
                            {
                                for (int j = 1; j < 10; j++)
                                {
                                    firstCoord = (i * pictureBox1.Height / (CountLines * CountWays)) - 5;
                                    g.DrawLine(p, 0, firstCoord, (pictureBox1.Width / 9) * j, firstCoord);
                                }
                            }
                        }

                        break;
                    case "Тоннель":
                        pictureSpeedLimitFirst.Visible = false;
                        pictureSpeedLimitSecond.Visible = false;
                        pictureSpeedLimitThird.Visible = false;
                        pictureSpeedLimitFourth.Visible = false;

                        _minSpeed = MIN_SPEED_TONNEL;
                        _maxSpeed = MAX_SPEED_TONNEL;

                        CountWays = 2;
                        CountLines = 1;
                        wid = pictureBox1.Height / CountLines / CountWays - 20;
                        isTonnel = true;

                        g.FillRectangle(Brushes.Gray, new Rectangle(175, 0, pictureBox1.Width - (175 * 2), wid / 4));  // Тоннель
                        g.FillRectangle(Brushes.LightGray, new Rectangle(175, wid / 4, pictureBox1.Width - (175 * 2), pictureBox1.Height - (wid / 2)));
                        g.FillRectangle(Brushes.Gray, new Rectangle(175, pictureBox1.Height - (wid / 4), pictureBox1.Width - (175 * 2), wid / 4));

                        firstCoord = (pictureBox1.Height / 2) - 5;
                        secondCoord = (pictureBox1.Height / 2) + 5;
                        g.DrawLine(p1, 0, firstCoord, pictureBox1.Width - 1, firstCoord);
                        g.DrawLine(p1, 0, secondCoord, pictureBox1.Width - 1, secondCoord);

                        timerTrafficLight.Interval = (TimeTrafficLight == 0)
                            ? 3
                            : TimeTrafficLight * 1000;
                        timerTrafficLight.Tick += new EventHandler(StopCars);
                        timerTrafficLight.Start();

                        _timerUpTonnelValue = (TimeTrafficLight == 0)
                            ? 3
                            : TimeTrafficLight;

                        _timerDownTonnelValue = (TimeTrafficLight == 0)
                            ? 3
                            : TimeTrafficLight;

                        SetColorLights(g);
                        SetTimerLight();
                        break;
                }
            }

            if (!_isStopped)
            {
                _reverseCars = new List<List<Car>>();
                _cars = new List<List<Car>>();

                var offsetPositionY = pictureBox1.Height / CountWays / CountLines / 2;

                for (int i = 0; i < CountLines; i++)
                {
                    var coordYReverse = 0;
                    var coordY = 0;
                    var timerOffset = pictureBox1.Location.Y + 25;

                    switch (roadType)
                    {
                        case "Автострада":
                            if (CountWays == 1)
                            {
                                switch (CountLines)
                                {
                                    case 1:
                                        if (i == 0)
                                            coordY = 200;
                                        break;

                                    case 2:
                                        if (i == 0)
                                            coordY = 100;
                                        else if (i == 1)
                                            coordY = 325;
                                        break;

                                    case 3:
                                        if (i == 0)
                                            coordY = 50;
                                        else if (i == 1)
                                            coordY = 225;
                                        else if (i == 2)
                                            coordY = 375;
                                        break;
                                }
                            }    
                            else
                            {
                                switch (CountLines)
                                {
                                    case 1:
                                        if (i == 0)
                                        {
                                            coordY = 100;
                                            coordYReverse = 325;
                                        }
                                        break;

                                    case 2:
                                        if (i == 0)
                                        {
                                            coordY = 40;
                                            coordYReverse = 275;
                                        }
                                        else if (i == 1)
                                        {
                                            coordY = 150;
                                            coordYReverse = 400;
                                        }
                                        break;

                                    case 3:
                                        if (i == 0)
                                        {
                                            coordY = 15;
                                            coordYReverse = 255;
                                        }
                                        else if (i == 1)
                                        {
                                            coordY = 90;
                                            coordYReverse = 330;
                                        }
                                        else if (i == 2)
                                        {
                                            coordY = 160;
                                            coordYReverse = 415;
                                        }
                                        break;
                                }
                            }
                            break;

                        case "Тоннель":
                            coordY = pictureBox1.Height / 2 - 150;
                            coordYReverse = pictureBox1.Height - 150;
                            break;
                    }
                    
                    var textBox = new Label();
                    textBox.Text = "";
                    textBox.Location = new Point(POSITION_X_TIMER_CARS, timerOffset + coordY);
                    Controls.Add(textBox);
                    _timersAppearsCar.Add((textBox, null));

                    _cars.Add(new List<Car>());

                    var car = new Car(wid, false);
                    car.start_x = -wid;
                    car.cur_x = -wid;
                    car.start_y = coordY;
                    car.cur_y = coordY;
                    car.speed = GetRandomSpeed();
                    car.isGenerate = false;

                    _cars[i].Add(car);

                    if (CountWays == 1)
                    {
                        continue;
                    }

                    var timerTextBox = new Label();
                    timerTextBox.Text = "";
                    timerTextBox.Location = new Point(POSITION_X_TIMER_REVERSE_CARS, timerOffset + coordYReverse);
                    Controls.Add(timerTextBox);
                    timerTextBox.BringToFront();
                    _timersAppearsReverseCar.Add((timerTextBox, null));

                    _reverseCars.Add(new List<Car>());

                    var reverseCar = new Car(wid, true);
                    reverseCar.start_x = wid + 890 + (i * 100);
                    reverseCar.cur_x = wid + 890 + (i * 100);
                    reverseCar.start_y = coordYReverse;
                    reverseCar.cur_y = coordYReverse;
                    reverseCar.speed = GetRandomSpeed();
                    reverseCar.isGenerate = false;
                    reverseCar.goal_x *= -1;

                    _reverseCars[i].Add(reverseCar);
                }
            }
            _isStopped = false;

            if (isTonnel)
            {
                SetStoppedDownThread();
            }
        }

        private int GetRandomSpeed()
        {
            var speed = 0f;
            if (_speedTransport.IsDeterminate)
            {
                speed = (float)_speedTransport.DeterminateInterval / 10f;
            }
            else if (_speedTransport.IsRandom)
            {
                switch (_speedTransport.Law)
                {
                    case "Нормальный":
                        var t = new Random().NextDouble();
                        speed = (float)(1 / Math.Sqrt(2 * Math.PI * Math.Pow(_speedTransport.RandomDispersion, 2))
                            * Math.Exp(-Math.Pow((t - _speedTransport.MathExpectation), 2) / 2 * _speedTransport.RandomDispersion));
                        break;
                    case "Равномерный":
                        t = new Random().NextDouble();
                        speed = (float)((t - _speedTransport.StartInterval) / (_speedTransport.EndInterval - _speedTransport.StartInterval));
                        break;
                    case "Показательный":
                        t = new Random().NextDouble();
                        speed = (float)(1 - Math.Exp(-_speedTransport.Intensity * t));
                        break;
                }
            }
            else
            {
                speed = 3f;
            }

            return (int)speed;
        }
    }
}

