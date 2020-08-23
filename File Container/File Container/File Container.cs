using System;
using System.Windows.Forms;
using System.IO; //пространство имен чтения/записи файлов
using System.Runtime.Serialization; // пространство имен для сериализации и десериализации
using System.Runtime.Serialization.Formatters.Binary; // пространство имен для сериализации и десериализации в двоичном формате

namespace File_Container
{
    public partial class File_Container : Form
    {
        public File_Container()
        {
            InitializeComponent();
        }
        // упаковка файлов в контейнер
        private void buttonChooseFiles_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            try
            {
                BinaryFormatter bfw = new BinaryFormatter(); // сериализует и десериализует объекты в двоичном формате
                BinaryFormatter bf = new BinaryFormatter(); 
                FileStream FileStream; // класс для операций с файлами в файловой сис.
                OpenFileDialog openFiles = new OpenFileDialog(); // диалоговое окно выбора файлов
                openFiles.Title = "Выберите файлы, которые необходимо упаковать"; // заголовок окна 
                openFiles.Multiselect = true; // возможность выбора нескольких файлов

                if (openFiles.ShowDialog() == DialogResult.OK) // проверка выбора файла
                {
                    try
                    {
                        SaveFileDialog saveFile = new SaveFileDialog(); // диалоговое окно сохранения файла
                        saveFile.Title = "Выберите директорию для сохранения";
                        saveFile.FileName = "Container (" + DateTime.Now.ToShortDateString() + ")"; // имя по умолчанию с текущей датой
                        saveFile.Filter = "Файл dat|*.dat"; // фильтр файлов для отображения

                        if (saveFile.ShowDialog() == DialogResult.OK)
                        {
                            FilesData FileData = new FilesData(openFiles.FileNames,openFiles.SafeFileNames); // передача выбранных файлов в класс файлов для обработки
                            // Сериализуем - сохраняем данные в файл
                            using (FileStream = new FileStream(saveFile.FileName, FileMode.Create, FileAccess.Write))
                            {
                                bf.Serialize(FileStream, FileData);
                                FileStream.Close(); // закрываем поток
                            }
                            try
                            {
                                FilesData desObj = new FilesData();
                                // просмотр контейнера (десериализация)
                                using (FileStream = new FileStream(saveFile.FileName, FileMode.Open))
                                {
                                    desObj = (FilesData)bfw.Deserialize(FileStream);
                                }
                                FileStream.Close();
                                // запоняем RTB именями файлов содержащихся в контенере
                                foreach (FilesData.fi y in desObj.dataFi)
                                {
                                    richTextBox1.Text += y.name.ToString() + "\r\n";
                                }
                            }
                            catch (Exception ex) { MessageBox.Show("Ошибка при попытки просмотре контейнера, попробуйте еще раз! " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            // выводим сообщение об успехе 
                            MessageBox.Show("Данные успешно сохранены", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    // обработка исключений 
                    catch (Exception ex) { MessageBox.Show("Ошибка при попытки сохранения контейнера, попробуйте еще раз! " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка во время выбора файлов для упаковки, попробуйте еще раз! " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        // упаковка содержимого папки
        private void buttonChooseFolder_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream FileStream;
                FolderBrowserDialog FolderBr = new FolderBrowserDialog(); //диалоговое окно выбора папки
                OpenFileDialog openFiles = new OpenFileDialog(); // диалоговое окно выбора файлов

                if (FolderBr.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        SaveFileDialog saveFile = new SaveFileDialog();
                        saveFile.Title = "Выберите директорию для сохранения";
                        saveFile.FileName = "Container (" + DateTime.Now.ToShortDateString() + ")";
                        saveFile.Filter = "Файл dat|*.dat";

                        if (saveFile.ShowDialog() == DialogResult.OK)
                        {
                            FilesData FileData = new FilesData(Directory.GetFiles(FolderBr.SelectedPath)); // передача файлов содержащихся в папке в класс файлов для обработки

                            using (FileStream = new FileStream(saveFile.FileName, FileMode.Create, FileAccess.Write))
                            {
                                BinaryFormatter bf = new BinaryFormatter();
                                bf.Serialize(FileStream, FileData);
                                FileStream.Close();
                            }
                            MessageBox.Show("Данные успешно сохранены", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Ошибка при попытки сохранения контейнера, попробуйте еще раз! " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка во время выбора файлов для упаковки, попробуйте еще раз! " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        // дополняем конейнер файлами
        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream FileStream;
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Выберите контейнер, который необходимо дополнить";
                openFile.Filter = "Файл dat|*.dat";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    OpenFileDialog openFiles = new OpenFileDialog();
                    openFiles.Title = "Выберите файлы, которые необходимо добавить";
                    openFiles.Multiselect = true;
                    openFiles.ShowDialog();
                    // дописываем выбранные  файлы в конец контейнера
                    using (FileStream = new FileStream(openFile.FileName, FileMode.Append, FileAccess.Write))
                    {
                        FilesData FileData = new FilesData(openFiles.FileNames, openFiles.SafeFileNames);
                        bf.Serialize(FileStream, FileData);
                        FileStream.Close();
                    }
                    try
                    {
                        BinaryFormatter bfw = new BinaryFormatter();
                        FilesData desObj = new FilesData();
                        // просмотр контейнера (десериализация)
                        using (FileStream = new FileStream(openFile.FileName, FileMode.Open))
                        {
                            desObj = (FilesData)bfw.Deserialize(FileStream);
                        }
                        FileStream.Close();
                        // запоняем RTB именями файлов содержащихся в контенере
                        foreach (FilesData.fi y in desObj.dataFi)
                        {
                            richTextBox1.Text += y.name.ToString() + "\r\n";
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Ошибка при попытки просмотре контейнера, попробуйте еще раз! " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    MessageBox.Show("Данные успешно добавлены", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка во время упаковки, попробуйте еще раз! " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        // дополняем конейнер файлами содержащихся в папке
        private void buttonAddFolder_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream FileStream;
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Выберите контейнер, который необходимо дополнить";
                openFile.Filter = "Файл dat|*.dat";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    FolderBrowserDialog FolderBr = new FolderBrowserDialog();
                    FolderBr.ShowDialog();

                    using (FileStream = new FileStream(openFile.FileName, FileMode.Append, FileAccess.Write))
                    {
                        FilesData FileData = new FilesData(Directory.GetFiles(FolderBr.SelectedPath));
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(FileStream, FileData);
                        FileStream.Close();
                    }
                    MessageBox.Show("Данные успешно добавлены", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка во время упаковки, попробуйте еще раз! " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //распаковка контейнера
        private void buttonChooseContainer_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream FileStream;
                FilesData desObj;
                BinaryFormatter bf = new BinaryFormatter();
                OpenFileDialog openFiles = new OpenFileDialog();
                openFiles.Title = "Выберите контейнер, которые необходимо распаковать";
                openFiles.Filter = "Файл dat|*.dat";

                if (openFiles.ShowDialog() == DialogResult.OK)
                {
                    FolderBrowserDialog FolderBr = new FolderBrowserDialog();
                    FolderBr.ShowDialog();

                    // Десериализуем - "распаковываем" файлы из файла
                    using (FileStream = new FileStream(openFiles.FileName, FileMode.Open))
                    {
                        desObj = (FilesData)bf.Deserialize(FileStream);
                    }
                    FileStream.Close();

                    foreach (FilesData.fi y in desObj.dataFi)
                    {
                        FileStream = new FileStream(FolderBr.SelectedPath+"\\"+y.name, FileMode.Create, FileAccess.Write); // создаем новые файлы в указоную папку
                        FileStream.Write(y.data, 0, y.data.Length); // переносим содержимое файла
                        FileStream.Flush(); // записываем файл
                        FileStream.Close();
                    }
                    MessageBox.Show("Данные успешно распакованы", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка во время выбора файлов для распаковки, попробуйте еще раз! " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}


//FileStream FileStream;
//    FilesData desObj;
//    BinaryFormatter bf = new BinaryFormatter();
//    OpenFileDialog openFiles = new OpenFileDialog();
//    openFiles.Title = "Выберите контейнер, которые необходимо распаковать";
//    openFiles.Filter = "Файл dat|*.dat";

//    if (openFiles.ShowDialog() == DialogResult.OK)
//    {
//        // Десериализуем - "распаковываем" файлы из файла
//        using (FileStream = new FileStream(openFiles.FileName, FileMode.Open))
//        {
//            desObj = (FilesData)bf.Deserialize(FileStream);
//        }
//        FileStream.Close();

//        foreach (FilesData.fi y in desObj.dataFi)
//        {
//            richTextBox1.Text += y.name.ToString() + "\r\n";
//        }
//    }