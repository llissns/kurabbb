using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kurabbb.Forms;

namespace kurabbb
{
    public partial class Main : Form
    {
        private readonly int userId;
        private readonly string connectionString;
        public Main(int userId, string connectionString)
        {
            InitializeComponent();
            this.userId = userId;
            this.connectionString = connectionString;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            // Панель для содержимого
            Panel aboutPanel = new Panel
            {
                Size = new Size(panel1.Width - 40, panel1.Height - 40),
                Location = new Point(20, 20),
                BackColor = Color.White,
                AutoScroll = true,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10),
                Margin = new Padding(5)
            };

            // Заголовок
            Label titleLabel = new Label
            {
                Text = "Arbor — пространство тишины, уюта и природы.",
                Font = new Font("Segoe UI", 16, FontStyle.Italic | FontStyle.Bold),
                ForeColor = Color.FromArgb(62, 39, 35),
                AutoSize = true,
                MaximumSize = new Size(aboutPanel.Width - 40, 0)
            };

            // Основной текст
            RichTextBox aboutText = new RichTextBox
            {
                ReadOnly = true,
                BorderStyle = BorderStyle.None,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                ForeColor = Color.Black,
                Location = new Point(0, titleLabel.Bottom + 50),
                Size = new Size(aboutPanel.Width - 40,600),
                WordWrap = true,
                ScrollBars = RichTextBoxScrollBars.None,
                Text =
    "Гостиница Arbor расположена в самом сердце хвойного леса, у кристально чистого озера Кальма. " +
    "Это идеальное место для тех, кто хочет отдохнуть от суеты города, вдохнуть свежий лесной воздух и почувствовать настоящую гармонию с природой.\n\n" +
    "Arbor — это не просто гостиница. Это эко-пространство для тех, кто ценит тишину, тепло живого дерева, комфорт и душевный отдых в любое время года.\n\n" +
    "В вашем распоряжении — банный комплекс на берегу озера, аренда инвентаря для игр на свежем воздухе, плавательные средства и множество вариантов активного и расслабленного досуга. " +
    "Здесь круглый год найдется занятие по душе — как для взрослых, так и для детей.\n\n" +
    "На первом этаже главного здания работает уютный ресторан с камином — идеальное место для зимних вечеров. " +
    "Летом же гостей ждет просторная веранда с видом на озеро и величественные сосны.\n\n" +
    "Для маленьких гостей мы создали безопасное и интересное пространство: игровая площадка, спортивная зона, летом — футбол, волейбол, велосипеды и настольные игры, " +
    "зимой — деревянная горка, катание на коньках и снежные развлечения.\n\n" +
    "Arbor гостеприимен для всех: будь вы семьей, влюбленной парой или компанией друзей — мы позаботимся о том, чтобы ваш отдых был по-настоящему тёплым, насыщенным и незабываемым."
            };

            // Выделяем все вхождения "Arbor"
            string keyword = "Arbor";
            int index = aboutText.Text.IndexOf(keyword);
            while (index != -1)
            {
                aboutText.Select(index, keyword.Length);
                aboutText.SelectionFont = new Font("Lucida Handwriting", 11, FontStyle.Bold);
                aboutText.SelectionColor = Color.FromArgb(62, 39, 35);
                index = aboutText.Text.IndexOf(keyword, index + keyword.Length);
            }

            // Добавляем на панель
            aboutPanel.Controls.Add(titleLabel);
            aboutText.DeselectAll();
            aboutPanel.Controls.Add(aboutText);
            panel1.Controls.Add(aboutPanel);
        }
    
        private void buttonRooms_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); // Очищаем основную панель

            // Панель с прокруткой
            Panel scrollPanel = new Panel
            {
                AutoScroll = true,
                Size = new Size(panel1.Width - 20, panel1.Height - 20),
                Location = new Point(10, 10),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };

            var rooms = new List<(string Name, Image Img, string Area, string Capacity, string Details)>
                {
                    ("Стандартный", Properties.Resources.standart, "20 м²", "до 2 гостей",
                    "Общая площадь: 20 кв.м.\n\nВместимость: до 2 гостей\n\n" +
                    "Номера категории «Стандартный» расположены на 1 этаже.\n" +
                    "Идеальны для пары или индивидуального размещения.\n\nВ номере:\n" +
                    "Двуспальная кровать или кровати 1+1\nТелевизор\nТелефон\nФен\nМини-холодильник\nСтол и стулья\nЗеркало\nШкаф\nСейф\n\n" +
                    "В ванной комнате:\nДушевая кабина\nБанные принадлежности\nСанузел\n\n" + 
                    "Прочее:\nБалкон"),

                    ("Семейный", Properties.Resources.semeiniy, "35 м²", "до 3 гостей",
                    "Общая площадь: 28 кв.м.\n\nВместимость: до 3 гостей (2 основных места и 1 дополнительное место)\n\n" +
                    "Номера категории «Семейный» расположены на 2 и 3 этаже. В номере — 2 комнаты.\n" +
                    "Номера на 2 этаже с балконом. Из окон открывается вид на озеро или лес.\n" +
                    "Номера на 3 этаже без балкона. Окна — мансардные.\n\nВ номере:\n" +
                    "Двуспальная кровать или кровати 1+1\nТелевизор\nТелефон\nФен\nМини-холодильник\nЗеркало\nСтулья\nШкаф\nСейф\n\n" +
                    "В ванной комнате:\nДушевая кабина\nБанные принадлежности\nСанузел\n\n" +
                    "Прочее:\nВ номерах на 2-м этаже балкон"),

                    ("Большой", Properties.Resources.bolshoy, "50 м²", "до 2 гостей",
                    "Общая площадь: 50 кв.м.\n\nВместимость: до 2 гостей\n\n" +
                    "Номера категории «Большой» расположены на 4 этаже.\n" +
                    "Номера с балконом. Из окон открывается вид на озеро или лес.\n\nВ номере:\n" +
                    "Двуспальная кровать\nТелевизор\nТелефон\nФен\nМини-холодильник\nКресла, журнальный стол\nЗеркало\nТумбы\nШкаф\nСейф\n\n" +
                    "В ванной комнате:\nДушевая кабина\nБанные принадлежности\nСанузел\nХалаты\n\n" +
                    "Прочее:\nБалкон, плетеная мебель"),

                    ("Молодёжный", Properties.Resources.molodesh, "25 м²", "до 3 гостей",
                    "Общая площадь: 25 кв.м.\n\nВместимость: до 3 гостей(2 основных места и 1 дополнительное место)\n\n" +
                    "Номера категории «Молодежный» расположены на 4 этаже.\n" +
                    "Из окон открывается вид на озеро или лес.Номера без балкона.\n\nВ номере:\n" +
                    "Двуспальная кровать\nТелевизор\nТелефон\nФен\nМини-холодильник\nЗеркало\nСтулья\nТумбы\nШкаф\nСейф\n\n" +
                    "В ванной комнате:\nДушевая кабина\nБанные принадлежности\nСанузел"),

                    ("Мансардный", Properties.Resources.mansard, "30 м²", "до 2 гостей",
                    "Общая площадь: 30 кв.м.\n\nВместимость: до 2 гостей\n\n" +
                    "Номера категории «Мансардный» расположены на 3 этаже.Номера без балкона.Окна - мансардные.\n\nВ номере:\n" +
                    "Двуспальная кровать или кровати 1+1\nТелевизор\nТелефон\nФен\nМини-холодильник\nСтулья\nТумбы\nЗеркало\nШкаф\nСейф\n\n" +
                    "В ванной комнате:\nДушевая кабина\nБанные принадлежности\nСанузел"),
                };

            int y = 10;

            foreach (var room in rooms)
            {
                Panel card = new Panel
                {
                    Size = new Size(scrollPanel.Width - 40, 180),
                    Location = new Point(10, y),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(10),
                    Margin = new Padding(5)
                };

                PictureBox img = new PictureBox
                {
                    Image = room.Img,
                    Size = new Size(130, 130),
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                Label info = new Label
                {
                    Text = $"{room.Name}\nПлощадь: {room.Area}\nВместимость: {room.Capacity}",
                    Location = new Point(150, 10),
                    Font = new Font("Segoe UI", 10, FontStyle.Italic),
                    AutoSize = true
                };

                Button btnMore = new Button
                {
                    Text = "Подробнее",
                    Location = new Point(150, 110),
                    Size = new Size(100, 30),
                    BackColor = Color.FromArgb(62, 39, 35),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                btnMore.Click += (s, ev) => MessageBox.Show(room.Details, $"Номер: {room.Name}");

                Button btnBook = new Button
                {
                    Text = "Забронировать",
                    Location = new Point(260, 110),
                    Size = new Size(120, 30),
                    BackColor = Color.FromArgb(62, 39, 35),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                int roomId = GetRoomIdByName(room.Name); // получаем ID номера по имени

                btnBook.Click += (s, ev) =>
                {
                    var bookingForm = new Bookings(roomId,userId);
                    bookingForm.ShowDialog();
                };
                card.Controls.Add(img);
                card.Controls.Add(info);
                card.Controls.Add(btnMore);
                card.Controls.Add(btnBook);
                scrollPanel.Controls.Add(card);

                y += card.Height + 10;
            }

            panel1.Controls.Add(scrollPanel); // Добавляем всю прокручиваемую панель
        }
        private int GetRoomIdByName(string name)
        {
            using (var conn = new Npgsql.NpgsqlConnection("Host=172.20.7.53;Port=5432;Username=st3996;Password=pwd3996;Database=db3996_19"))
            {
                conn.Open();
                var cmd = new Npgsql.NpgsqlCommand(@"
                SELECT r.room_id 
                FROM infhotel.rooms r
                JOIN infhotel.room_types rt ON r.type_id = rt.type_id
                WHERE rt.name = @name
                LIMIT 1", conn);

                cmd.Parameters.AddWithValue("name", name);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private void buttonServices_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); // Очищаем панель

            // Панель с прокруткой
            Panel scrollPanel = new Panel
            {
                AutoScroll = true,
                Size = new Size(panel1.Width - 20, panel1.Height - 20),
                Location = new Point(10, 10),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };

            // Данные об услугах
            var services = new List<(string Name, Image Img, string ShortDescription, string FullDescription)>
            {
                ("Спа-кабинет", Properties.Resources.spa,
                "Расслабляющие процедуры для тела и души в уютной атмосфере.",
                "Спа-услуги:\n- Уход за лицом — от 2500₽\n- Обёртывания — от 3000₽\n- Арома-терапия — 1500₽\n- Пилинг и маски — от 2000₽\n\nВсе процедуры проводятся с использованием натуральной косметики."),

                ("Бани и сауны", Properties.Resources.banya,
                "Традиционные русские бани и сауны для релаксации и оздоровления.",
                "Бани и сауны:\n- Русская баня — 2000₽/час\n- Финская сауна — 1800₽/час\n- Инфракрасная сауна — 1500₽/час\n- Аренда веников — 300₽\n\nДоступна зона релакса с чаем и шезлонгами."),

                ("Каток", Properties.Resources.katok,
                "Зимние развлечения для всей семьи.",
                "Каток:\n- Вход на каток — бесплатно для гостей\n- Прокат коньков — 300₽/час\n- Детские ходунки — 100₽\n- Горячий чай и глинтвейн рядом на террасе."),

                ("Экскурсии", Properties.Resources.ecscurs,
                "Познавательные экскурсии по живописным окрестностям.",
                "Экскурсии:\n- Лесная прогулка с гидом — 1000₽/чел\n- Озёрное путешествие — 1500₽/чел\n- Исторический тур — от 2000₽/чел\n\nЕжедневно, по предварительной записи."),

                ("Массаж", Properties.Resources.masss,
                "Профессиональные массажи для расслабления и восстановления.",
                "Массаж:\n- Классический — 2500₽/час\n- Расслабляющий — 2000₽/час\n- Антицеллюлитный — от 2800₽\n- Детский — 1500₽/30 мин\n\nИндивидуальный подход и тёплая атмосфера."),

                ("Рыбалка", Properties.Resources.fishing,
                "Рыбалка на озере с возможностью поймать различные виды рыб.",
                "Рыбалка:\n- Аренда удочек — 300₽/день\n- Лодка с веслами — 500₽/час\n- Лодка с мотором — 1000₽/час\n\nУлов можно приготовить в ресторане.")
            };

            int y = 10;

            foreach (var service in services)
            {
                Panel card = new Panel
                {
                    Size = new Size(scrollPanel.Width - 40, 180),
                    Location = new Point(10, y),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White,
                    Padding = new Padding(10),
                    Margin = new Padding(5)
                };

                PictureBox img = new PictureBox
                {
                    Image = service.Img,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(10, 10),
                    Size = new Size(130, 130)
                };

                Label info = new Label
                {
                    Text = $"{service.Name}\n{service.ShortDescription}",
                    Location = new Point(150, 10),
                    Font = new Font("Segoe UI", 10, FontStyle.Italic),
                    AutoSize = true
                };

                Button btnMore = new Button
                {
                    Text = "Подробнее",
                    Location = new Point(150, 110),
                    Size = new Size(100, 30),
                    BackColor = Color.FromArgb(62, 39, 35),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                btnMore.Click += (s, ev) =>
                {
                    MessageBox.Show(service.FullDescription, $"Услуга: {service.Name}");
                };

            

                card.Controls.Add(img);
                card.Controls.Add(info);
                card.Controls.Add(btnMore);
                scrollPanel.Controls.Add(card);

                y += card.Height + 10;
            }

            panel1.Controls.Add(scrollPanel);
        }

        private void buttonContacts_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); // Очищаем панель

            Panel contactPanel = new Panel
            {
                Size = new Size(panel1.Width - 40, 350),
                Location = new Point(20, 20),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Padding = new Padding(20)
            };

            Label titleLabel = new Label
            {
                Text = "Свяжитесь с нами",
                Font = new Font("Segoe UI", 18, FontStyle.Italic),
                AutoSize = true,
                ForeColor = Color.FromArgb(62, 39, 35),
                Location = new Point(10, 10)
            };

            Label addressLabel = new Label
            {
                Text = "Адрес: ул. Лесная, 1, г. Лесное, Россия",
                Font = new Font("Segoe UI", 12),
                AutoSize = true,
                Location = new Point(10, 60)
            };

            Label phoneLabel = new Label
            {
                Text = "Телефон: +7 (123) 456-78-90",
                Font = new Font("Segoe UI", 12),
                AutoSize = true,
                Location = new Point(10, 95)
            };

            Label emailLabel = new Label
            {
                Text = "Email: contact@arbor.ru",
                Font = new Font("Segoe UI", 12),
                AutoSize = true,
                Location = new Point(10, 130)
            };

            Label socialLabel = new Label
            {
                Text = "Мы в социальных сетях:",
                Font = new Font("Segoe UI", 12, FontStyle.Italic),
                ForeColor = Color.FromArgb(62, 39, 35),
                AutoSize = true,
                Location = new Point(10, 180)
            };

            
            PictureBox fbIcon = new PictureBox
            {
                Image = Properties.Resources.facebook,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(10, 220),
                Size = new Size(40, 40),
                Cursor = Cursors.Hand
            };
            fbIcon.Click += (s, ev) => Process.Start("https://www.facebook.com/yourpage");

            PictureBox vkIcon = new PictureBox
            {
                Image = Properties.Resources.vk, // замените на реальную иконку
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(60, 220),
                Size = new Size(40, 40),
                Cursor = Cursors.Hand
            };
            vkIcon.Click += (s, ev) => Process.Start("https://vk.com/yourpage");

            PictureBox instaIcon = new PictureBox
            {
                Image = Properties.Resources.instagram, // замените на реальную иконку
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(110, 220),
                Size = new Size(40, 40),
                Cursor = Cursors.Hand
            };
            instaIcon.Click += (s, ev) => Process.Start("https://www.instagram.com/yourpage");

            contactPanel.Controls.Add(titleLabel);
            contactPanel.Controls.Add(addressLabel);
            contactPanel.Controls.Add(phoneLabel);
            contactPanel.Controls.Add(emailLabel);
            contactPanel.Controls.Add(socialLabel);
            contactPanel.Controls.Add(fbIcon);
            contactPanel.Controls.Add(vkIcon);
            contactPanel.Controls.Add(instaIcon);

            panel1.Controls.Add(contactPanel);
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            if (Autorization.UserSession.CurrentUser != null)
            {
                var profileForm = new Profil(Autorization.UserSession.CurrentUser.Id, connectionString);
                this.Hide();
                profileForm.FormClosed += (s, args) => this.Show();
                profileForm.Show();
            }
            else
            {
                var authForm = new Autorization();
                authForm.ShowDialog();

                if (Autorization.UserSession.CurrentUser != null && authForm.IsAuthorized)
                {
                    var profileForm = new Profil(Autorization.UserSession.CurrentUser.Id, connectionString);
                    this.Hide();
                    profileForm.FormClosed += (s, args) => this.Show();
                    profileForm.Show();
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}

