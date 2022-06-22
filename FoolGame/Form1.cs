using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoolGame
{
    //проследить насколько просто угадывать что у противника
    //развернуть ножницы если их поставил враг
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            updateInfo += UpdateInfo;
            levelUp += LevelUp;
            fight += Fight;
            updateReadyStatus += UpdateCheckBoxReady;
            updateStats += ChangeStats;
        }
        public static Action updateInfo;
        public static Action levelUp;
        public static Action fight;
        public static Action updateReadyStatus;
        public static Action updateStats;
        [Serializable]
        class Player
        {
            public double Dmg;
            public double Def;
            public double Heal;
            public double HP;
            public byte? Action;
            public byte? Ult;
            public Player(double dmg, double def, double heal, double hp, byte? ult = null, byte? action = null)
            {
                Dmg = dmg;
                Def = def;
                Heal = heal;
                HP = hp;
                Action = action;
                Ult = ult;
            }
        }
        static Random rand = new Random();
        public static double GetRandomDoubleNumber(double minimum, double maximum)
        {
            return rand.NextDouble() * (maximum - minimum) + minimum;
        }
        static Player firstPlayer = new Player(0, 0, 0, 50);
        static Player secondPlayer = new Player(0, 0, 0, 50);
        static double[] statsFP = new double[] { firstPlayer.Def, firstPlayer.Dmg, firstPlayer.Heal, firstPlayer.HP };
        static double[] statsSP = new double[] { secondPlayer.Def, secondPlayer.Dmg, secondPlayer.Heal, secondPlayer.HP };
        static double[] backupStatsFP = new double[3];
        static int roundCounter = 0;
        Thread receiveThread = new Thread(new ThreadStart(ReceiveData));

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxFP.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSP.SizeMode = PictureBoxSizeMode.StretchImage;
            receiveThread.Start();
            ChangeHP();
            if (roundCounter == 0)
            {
                int whichBoosted = rand.Next(0, 2);
                statsFP[whichBoosted] += 2;
                levelUp();
                updateInfo();
            }
            labelDefFP.Text = "Ваша ЗАЩ: " + statsFP[0].ToString();
            labelDmgFP.Text = "Ваш УРН: " + statsFP[1].ToString();
            labelHealFP.Text = "Ваше ЛЕЧ: " + statsFP[2].ToString();
            labelDefSP.Text = "Ваш штраф к УРН: ?";
            labelDmgSP.Text = "Вам нанесенный УРН: ?";
            labelHealSP.Text = "Враг получил ЛЕЧ: ?";

            bDone.Enabled = false;
            checkBoxReady.Enabled = false;
            ChangePicture(pictureBoxFP, 0);
            ChangePicture(pictureBoxSP, 0);

        }
        void SwitchUltVisible() //не меняется напдись ульты после перевыбора
        {
            switch (firstPlayer.Ult)
            {
                case 1:
                    {
                        bUseContr.Visible = true;
                        bUseContr.Enabled = false;
                        bUseBleed.Visible = false;
                        bUseBleed.Enabled = false;
                        bUseVamp.Visible = false;
                        bUseVamp.Enabled = false;
                        if (ultCoolDown <= 0)
                        {
                            bUseContr.Enabled = true;
                        }
                        break;

                    }
                case 2:
                    {
                        bUseBleed.Visible = true;
                        bUseBleed.Enabled = false;
                        bUseContr.Visible = false;
                        bUseContr.Enabled = false;
                        bUseVamp.Visible = false;
                        bUseVamp.Enabled = false;
                        if (ultCoolDown <= 0)
                        {
                            bUseBleed.Enabled = true;
                        }
                        break;
                    }
                case 3:
                    {
                        bUseVamp.Visible = true;
                        bUseVamp.Enabled = false;
                        bUseBleed.Visible = false;
                        bUseBleed.Enabled = false;
                        bUseContr.Visible = false;
                        bUseContr.Enabled = false;
                        if (ultCoolDown <= 0)
                        {
                            bUseVamp.Enabled = true;
                        }
                        break;
                    }
                default:
                    break;
            }
        }
        private void LevelUp()
        {
            canSelectUlt = true;
            Invoke((MethodInvoker)delegate
            {
                var previousUlt = firstPlayer.Ult;
                Skills skills = new Skills(statsFP);
                skills.ShowDialog();
                statsFP = skills.GiveDataToMainForm();
                firstPlayer.Ult = skills.GiveUltToMain();
                if (firstPlayer.Ult == null)
                {
                    firstPlayer.Ult = previousUlt;
                }
                SwitchUltVisible();
                statsFP[3] = firstPlayer.HP;
            });
        }
        int updateCounter = 1;
        private void ChangeStats()
        {
            Invoke((MethodInvoker)delegate
            {
                labelDefFP.Text = "Ваша ЗАЩ: " + statsFP[0].ToString();
                labelDmgFP.Text = "Ваш УРН: " + statsFP[1].ToString();
                labelHealFP.Text = "Ваше ЛЕЧ: " + statsFP[2].ToString();
                if (updateCounter == 2)
                {
                    labelDefSP.Text = "Ваш штраф к УРН: " + secondPlayer.Def;
                    labelDmgSP.Text = "Вам нанесенный УРН: " + secondPlayer.Dmg;
                    labelHealSP.Text = "Враг получил ЛЕЧ: " + secondPlayer.Heal;
                    labelHpSP.Text = secondPlayer.HP + "/50";
                    labelDataUpdate.Text = "СВЕЖЕСТЬ\nДАННЫХ:\n" + "0ход";
                    updateCounter = 0;
                }
                else
                {
                    labelDataUpdate.Text = "СВЕЖЕСТЬ\nДАННЫХ:\n" + (updateCounter + 1 - updateCounter).ToString() + "ход";
                    labelDefSP.Text = "Ваш штраф к УРН: ?";
                    labelDmgSP.Text = "Вам нанесенный УРН: ?";
                    labelHealSP.Text = "Враг получил ЛЕЧ: ?";
                }
                updateCounter++;
            });
        }
        private void ChangeHP()
        {
            if (firstPlayer.HP > 50) progressBarFirstPlayer.Value = 100;
            else if (firstPlayer.HP < 0) progressBarFirstPlayer.Value = 0;
            else progressBarFirstPlayer.Value = Convert.ToInt32(firstPlayer.HP) * 2;
            if (secondPlayer.HP > 50) progressBarSecondPlayer.Value = 100;
            else if (secondPlayer.HP < 0) progressBarSecondPlayer.Value = 0;
            else progressBarSecondPlayer.Value = Convert.ToInt32(secondPlayer.HP) * 2;
            labelHpFP.Text = firstPlayer.HP.ToString() + "/50";
            labelHpSP.Text = secondPlayer.HP.ToString() + "/50";
        }
        bool isUltUsed = false;
        int ultCoolDown;
        private void Fight()
        {
            switch (firstPlayer.Action)
            {
                case 1:
                    {
                        if (secondPlayer.Action == 1)
                        {
                            firstPlayer.Def *= 0.5;
                            secondPlayer.Def *= 0.5;
                        }
                        else if (secondPlayer.Action == 3)
                        {
                            firstPlayer.Def *= 0.2;
                        }
                        else
                        {
                            secondPlayer.Dmg *= 0.2;
                        }
                        break;
                    }
                case 2:
                    {
                        if (secondPlayer.Action == 2)
                        {
                            firstPlayer.Dmg *= 0.5;
                            secondPlayer.Dmg *= 0.5;
                        }
                        else if (secondPlayer.Action == 1)
                        {
                            firstPlayer.Dmg *= 0.2;
                        }
                        else
                        {
                            secondPlayer.Heal *= 0.2;

                        }
                        break;
                    }
                case 3:
                    {
                        if (secondPlayer.Action == 3)
                        {
                            firstPlayer.Heal *= 0.5;
                            secondPlayer.Heal *= 0.5;

                        }
                        else if (secondPlayer.Action == 2) firstPlayer.Heal *= 0.2;
                        else
                        {
                            secondPlayer.Def *= 0.2;
                        }
                        break;
                    }
                default:
                    break;
            }

            void fight(Player player1, Player player2)
            {
                player1.HP += player1.Heal;
                double ruinedDamge = player1.Def;
                double allDamageSP = player2.Dmg - ruinedDamge;
                if (allDamageSP < 0) allDamageSP = 0;
                player1.HP -= allDamageSP;
                if (player1.HP > 50) player1.HP = 50;
                ChangePicture(pictureBoxFP, (byte)firstPlayer.Action);
                ChangePicture(pictureBoxSP, (byte)secondPlayer.Action);
            }
            fight(firstPlayer, secondPlayer);
            fight(secondPlayer, firstPlayer);
            statsFP = new double[] { backupStatsFP[0], backupStatsFP[1], backupStatsFP[2], firstPlayer.HP };
            statsSP = new double[] { secondPlayer.Def, secondPlayer.Dmg, secondPlayer.Heal, secondPlayer.HP };
        }
        private void ChangePicture(PictureBox pictureBox, byte num)  //0-? 1-rock 2-scirioss 3-paper 4-vamp 5-contr 6-bleed
        {
            string fileToDisplay = String.Empty;
            Bitmap MyImage;
            void changePicture()
            {
                MyImage = new Bitmap(fileToDisplay);
                pictureBox.Image = (Image)MyImage;
            }
            switch (num)
            {
                case 0:
                    {
                        fileToDisplay = "res/questionMark.jpg";
                        changePicture();
                        break;
                    }
                case 1:
                    {
                        fileToDisplay = "res/rock.jpg";
                        changePicture();
                        break;
                    }
                case 2:
                    {
                        fileToDisplay = "res/scirioss.jpg";
                        changePicture();
                        if (pictureBox == pictureBoxFP)
                        {
                            Image img = pictureBox.Image;
                            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        }

                        break;
                    }
                case 3:
                    {
                        fileToDisplay = "res/paper.jpg";
                        changePicture();
                        break;
                    }
                default:
                    break;
            }
        }

        static byte[] PlayerSerialize(object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        static Player SerilizedToPlayer(byte[] obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            Stream stream = new MemoryStream(obj);
            var message = (Player)bf.Deserialize(stream);
            stream.Close();
            return message;

        }

        static bool flagCanSend = false;

        private void SendData(string message = null)
        {
            UdpClient sender = new UdpClient();
            void SendSpecificData()
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                sender.Send(data, data.Length, remoteAddress, remotePort);
            }
            try
            {
                switch (message)
                {
                    case "#101#":
                        {
                            SendSpecificData();
                            break;
                        }
                    case "#100#":
                        {
                            SendSpecificData();
                            break;
                        }
                    case "#103#":
                        {
                            SendSpecificData();
                            break;
                        }
                    case "#104#":
                        {
                            SendSpecificData();
                            break;
                        }
                    default:
                        {
                            if (flagEnemyConnected)
                            {
                                var data = PlayerSerialize(firstPlayer);
                                sender.Send(data, data.Length, remoteAddress, remotePort);
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Некуда отправлять");
                                break;
                            }
                        }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sender.Close();
            }
        }
        bool isSend = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (flagCanSend && isSend == false)
            {
                SendData();
                isSend = true;
            }
            else MessageBox.Show("Сейчас нельзя");
        }

        static bool flagEnemyConnected = false;
        static string[] cfg = File.ReadAllText("res/cfg.txt").Split(';');
        static int localPort = Int32.Parse(cfg[1]);
        //static int remotePort = localPort;
        static int remotePort = Int32.Parse(cfg[2]);
        static string remoteAddress = cfg[0];
        static bool isActionSelected = false;
        static bool isFightEnded = false;
        static bool isReadyFP = false;
        static bool isReadySP = false;
        bool canSelectUlt = true;
        static int randomedPercentageForStats;
        private static void ReceiveData()
        {
            UdpClient receiver = new UdpClient(localPort);
            IPEndPoint ip = null;
            try
            {
                while (true)
                {
                    byte[] data = receiver.Receive(ref ip);
                    switch (Encoding.UTF8.GetString(data))
                    {
                        case "#101#":
                            {
                                if (flagEnemyConnected == true)
                                {
                                    byte[] dataCheckSecond = Encoding.UTF8.GetBytes("Друг, уже не прокатит");
                                    receiver.Send(dataCheckSecond, dataCheckSecond.Length, remoteAddress, remotePort);
                                    break;
                                }
                                byte[] dataCheck = Encoding.UTF8.GetBytes("#102#");
                                receiver.Send(dataCheck, dataCheck.Length, remoteAddress, remotePort);
                                flagEnemyConnected = true;
                                updateInfo();
                                flagCanSend = false;
                                randomedPercentageForStats = rand.Next(10, 30);
                                dataCheck = Encoding.UTF8.GetBytes(randomedPercentageForStats.ToString());
                                receiver.Send(dataCheck, dataCheck.Length, remoteAddress, remotePort);
                                break;
                            }
                        case "#102#":
                            {
                                MessageBox.Show("Противник подключен.");
                                flagEnemyConnected = true;
                                flagCanSend = true;
                                updateInfo();
                                break;
                            }
                        case "#103#":
                            {
                                isReadySP = true;
                                updateReadyStatus();
                                break;
                            }
                        case "#104#":
                            {
                                isReadySP = false;
                                updateReadyStatus();
                                break;
                            }
                        case "#100#":
                            {
                                MessageBox.Show("Противник отключился.");
                                flagEnemyConnected = false;
                                Environment.Exit(0);
                                break;
                            }
                        default:
                            {
                                var checkDouble = int.TryParse(Encoding.UTF8.GetString(data), out int rp);
                                if (!checkDouble)
                                {
                                    roundCounter++;
                                    var receivedInfo = SerilizedToPlayer(data);
                                    secondPlayer = receivedInfo;
                                    if (!flagCanSend)
                                    {
                                        var dataSendAction = PlayerSerialize(firstPlayer);
                                        receiver.Send(dataSendAction, dataSendAction.Length, remoteAddress, remotePort);
                                        fight();
                                        updateInfo();
                                        updateStats();
                                        levelUp();
                                        updateInfo();
                                    }
                                    else
                                    {
                                        fight();
                                        updateInfo();
                                        updateStats();
                                        levelUp();
                                        updateInfo();
                                    }
                                    isFightEnded = true;
                                    updateReadyStatus();

                                }
                                else
                                {
                                    randomedPercentageForStats = rp;
                                }
                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                receiver.Close();
            }
        }

        private void UpdateAfterSkillClick()
        {
            labelDefFP.Text = $"Ваша ЗАЩ:{backupStatsFP[0]} => {firstPlayer.Def}";
            labelDmgFP.Text = $"Ваш УРН:{backupStatsFP[1]} => {firstPlayer.Dmg}";
            labelHealFP.Text = $"Ваше ЛЕЧ:{backupStatsFP[2]} => {firstPlayer.Heal}";
        }
        private void UpdateInfo()
        {
            firstPlayer.Def = statsFP[0];
            firstPlayer.Dmg = statsFP[1];
            firstPlayer.Heal = statsFP[2];
            firstPlayer.HP = statsFP[3];
            secondPlayer.Def = statsSP[0];
            secondPlayer.Dmg = statsSP[1];
            secondPlayer.Heal = statsSP[2];
            secondPlayer.HP = statsSP[3];
            Invoke((MethodInvoker)delegate
            {
                if (flagEnemyConnected == false)
                {
                    checkBoxReady.Enabled = false;
                    bCheckEnemyConnection.Enabled = true;
                    labelIsConnected.Text = "Соединение: нет";
                    bDone.Enabled = false;
                    this.Text = $"Раунд {roundCounter + 1}";
                }
                else
                {
                    if (isUltUsed)
                    {
                        bUseVamp.Enabled = false;
                        bUseBleed.Enabled = false;
                        bUseContr.Enabled = false;
                        ultCoolDown--;
                        if (ultCoolDown <= 0)
                        {
                            isUltUsed = false;
                            SwitchUltVisible();
                        }
                    }
                    isActionSelected = false;
                    checkBoxReady.Enabled = true;
                    bRock.Enabled = true;
                    bScissors.Enabled = true;
                    bHeal.Enabled = true;
                    this.Text = $"Раунд {roundCounter + 1}";
                    labelIsConnected.Text = "Соединение: есть";
                    bCheckEnemyConnection.Enabled = false;
                    ChangeHP();
                    isSend = false;
                    if (firstPlayer.HP < 1)
                    {
                        panel1.Enabled = false;
                        panel2.Enabled = false;
                        panel3.Enabled = false;
                        panel4.Enabled = false;
                        panel5.Enabled = false;
                        panel6.Enabled = false;
                        MessageBox.Show("Вы проиграли!");
                    }
                    else if (secondPlayer.HP < 1)
                    {
                        panel1.Enabled = false;
                        panel2.Enabled = false;
                        panel3.Enabled = false;
                        panel4.Enabled = false;
                        panel5.Enabled = false;
                        panel6.Enabled = false;
                        MessageBox.Show("Вы победили!");
                    }
                }

            });
        }

        private void bCheckEnemyConnection_Click(object sender, EventArgs e)
        {
            SendData("#101#");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SendData("#100#");
            Environment.Exit(0);
        }

        private void StatsSetDefault()
        {
            firstPlayer.Def = statsFP[0];
            firstPlayer.Dmg = statsFP[1];
            firstPlayer.Heal = statsFP[2];
        }
        //Action 1-Rock, 2-Scissors, 3-Heal
        private void bRock_Click(object sender, EventArgs e)
        {
            ChangePicture(pictureBoxFP, 1);
            firstPlayer.Action = 1;
            StatsSetDefault();
            firstPlayer.Def += 5;
            firstPlayer.Dmg *= (double)randomedPercentageForStats / 100;
            firstPlayer.Heal *= (double)randomedPercentageForStats / 100;
            firstPlayer.Action = 1;
            isActionSelected = true;
            for (int i = 0; i < 3; i++) backupStatsFP[i] = statsFP[i];
            UpdateAfterSkillClick();
        }

        private void bScissors_Click(object sender, EventArgs e)
        {
            ChangePicture(pictureBoxFP, 2);
            firstPlayer.Action = 2;
            StatsSetDefault();
            firstPlayer.Dmg += 5;
            firstPlayer.Def *= (double)randomedPercentageForStats / 100;
            firstPlayer.Heal *= (double)randomedPercentageForStats / 100;
            firstPlayer.Action = 2;
            isActionSelected = true;
            for (int i = 0; i < 3; i++) backupStatsFP[i] = statsFP[i];
            UpdateAfterSkillClick();
        }

        private void bHeal_Click(object sender, EventArgs e)
        {
            ChangePicture(pictureBoxFP, 3);
            firstPlayer.Action = 3;
            StatsSetDefault();
            firstPlayer.Heal += 5;
            firstPlayer.Dmg *= (double)randomedPercentageForStats / 100;
            firstPlayer.Def *= (double)randomedPercentageForStats / 100;
            firstPlayer.Action = 3;
            isActionSelected = true;
            for (int i = 0; i < 3; i++) backupStatsFP[i] = statsFP[i];
            UpdateAfterSkillClick();
        }
        // 1-contr 2-bleed 3-vamp
        private void UltVamp(Player player)
        {
            player.Dmg += player.Heal * 0.5;
            player.Def *= (double)randomedPercentageForStats / 100;
            player.Heal += 5;

        }
        private void UltContr(Player player)
        {
            player.Dmg += player.Def * 0.5;
            player.Heal *= (double)randomedPercentageForStats / 100;
            player.Def += 5;

        }
        private void UltBleed(Player player)
        {
            player.Def += player.Dmg * 0.25;
            player.Heal += player.Dmg * 0.25;
            player.Dmg += 5;

        }
        int ultCD = 6;
        private void bUseUlt_Vamp(object sender, EventArgs e)
        {
            firstPlayer.Ult = 3;
            firstPlayer.Action = 3;
            StatsSetDefault();
            UltVamp(firstPlayer);
            ChangePicture(pictureBoxFP, 3);
            isUltUsed = true;
            ultCoolDown = ultCD;
            isActionSelected = true;
            for (int i = 0; i < 3; i++) backupStatsFP[i] = statsFP[i];
            UpdateAfterSkillClick();
        }
        private void bUseUlt_Contr(object sender, EventArgs e)
        {
            firstPlayer.Ult = 1;
            firstPlayer.Action = 1;
            StatsSetDefault();
            UltContr(firstPlayer);
            ChangePicture(pictureBoxFP, 1);
            isUltUsed = true;
            ultCoolDown = ultCD;
            isActionSelected = true;
            for (int i = 0; i < 3; i++) backupStatsFP[i] = statsFP[i];
            UpdateAfterSkillClick();
        }
        private void bUseUlt_Bleed(object sender, EventArgs e)
        {
            firstPlayer.Ult = 2;
            firstPlayer.Action = 2;
            StatsSetDefault();
            UltBleed(firstPlayer);
            ChangePicture(pictureBoxFP, 2);
            isUltUsed = true;
            ultCoolDown = ultCD;
            isActionSelected = true;
            for (int i = 0; i < 3; i++) backupStatsFP[i] = statsFP[i];
            UpdateAfterSkillClick();
        }

        private void UpdateCheckBoxReady()
        {
            Invoke((MethodInvoker)delegate
            {
                if (isReadySP && isReadyFP && flagCanSend)
                {
                    bDone.Enabled = true;
                }
                else
                {
                    bDone.Enabled = false;
                }
                if (isFightEnded == true)
                {
                    isReadyFP = false;
                    isReadySP = false;
                    checkBoxReady.Checked = false;
                    isFightEnded = false;
                    bDone.Enabled = false;
                }

            });
        }
        private void checkBoxReady_Click(object sender, EventArgs e)
        {
            if (isActionSelected)
            {
                if (checkBoxReady.Checked)
                {
                    isReadyFP = true;
                    SendData("#103#");
                    UpdateCheckBoxReady();
                    checkBoxReady.Enabled = false;
                }
                else if (checkBoxReady.Checked == false)
                {
                    SendData("#104#");
                    isReadyFP = false;
                    bDone.Enabled = false;
                    UpdateCheckBoxReady();
                }
            }
            else
            {
                checkBoxReady.Checked = false;
                MessageBox.Show("Сначала выберите действие");
            }

        }

        private void bHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра \"Дурак\". Для старта нажмите \"Проверка связи\", чтобы удостовериться, что по ту сторону есть другой игрок с запущенной игрой.\n\n"
            + "Игра строится по такому принципу: каждый раунд вам предлагается на выбор прокачать характеристику: Защита, Урон, Лечение.\n"
            + "Защита отвечает за штраф к урону противника, Урон отвечает за нанесение урона врагу, Лечение отвечает за восстановление здоровья себе.\n"
            + "затем вы выбираете навык: Камень(ЗАЩ), Ножницы(УРН), Бумага(ЛЕЧ) - сокращенно КНБ, и жмете готов. Когда противник также намжет готов, если у вас горит кнопка Сделать ход - жмите ее, если нет, то просто ждите.\n"
            + "Далее происходит бой. Когда вы выбрали навык, характеристика, привязанная к этому навыку, увеличилась на 5, а остальные характеристики сокращаются на определенный процент(от 70 до 90),"
            + " то есть остальные характеристики так же участвуют в бою. Затем происходит сравнение элементов КНБ, как в обычной игре, то есть если вы поставили ножницы, а враг бумагу - вы победили в этом бою.\n\n"
            + "Но, действенность характеристики так же привязана к КНБ. Если вы поставили бумагу, то есть лечение, а враг ножницы, то ваше лечение сокращается на 75%, если же вы оба поставите бумагу, то на 50, в ином случае ваше лечение пройдет полностью.\n\n"
            + "Ближе к середине игры вам станут доступны ультимативные способности, они так же привязаны к элементам КНБ. Их можно использовать раз в 2 хода.\n\n"
            + "Ниже представлены формулы расчета в бою:\n"
            + "МоеЗдоровье = МоеЗдоровье+МоеЛечение\nУронПоМне = УронВрага - МояБроня\n\n"
            + "Ниже представлены формулы ультимативных способностей:\n"
            + "Вампиризм: МойУрон =МойУрон+(МоеЛечение*50%), МоеЛечение = МоеЛечение+5\n\n"
            + "Контр-атака: МойУрон = МойУрон+(МояЗащита*50%), МояЗащита = МояЗащита+5\n\n"
            + "Кровотечение: МояЗащита = МояЗащита+(МойУрон*25%), МоеЛечение = МоеЛечение+(МойУрон*25%), МойУрон = МойУрон+5");
        }
    }
}
