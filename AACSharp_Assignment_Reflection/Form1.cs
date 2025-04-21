using AACSharp_Assignment_Reflection.Classes;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AACSharp_Assignment_Reflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Attribute kod parçalarına ek açıklama / meta bilgi eklemeye yarayan yapılardır.
        // Kodun nasıl çalıştığını etkilemeden ekstra bilgi sağlayarak esnekliği arttırmak için.
        // [Obsolete]
        // Yazdığımız class Attribute sınıfından imlement edilir. AttributeUsage ile kullanılan alan belirlenir.
        // GetCostumAttribute ile Reflection üzerinden okunur.
        // Doğrulama için ise [Required] gibi ifadelerle alanlar zorunlu hale geirilir.




        private string currentPath = "";
        private string rootPath = "";
        private IPaySystem payObject;

        private void ShowDirectory(string path)
        {
            try
            {
                currentPath = path;
                listView1.Items.Clear();

                if (currentPath != rootPath)
                {
                    var backItem = new ListViewItem("Geri Git", "back");
                    backItem.Tag = Directory.GetParent(currentPath)?.FullName;
                    listView1.Items.Add(backItem);
                }


                // Klasörler
                foreach (var dir in Directory.GetDirectories(path))
                {
                    var item = new ListViewItem(Path.GetFileName(dir), "folder");
                    item.Tag = dir; // path bilgisini saklıyoruz
                    listView1.Items.Add(item);
                }

                foreach (var file in Directory.GetFiles(path))
                {
                    string extension = Path.GetExtension(file).ToLower(); // .cs, .txt, .pdf gibi
                    string iconKey = "default";

                    switch (extension)
                    {
                        case ".cs":
                            iconKey = "class";
                            break;
                        case ".txt":
                            iconKey = "txt";
                            break;
                        case ".pdf":
                            iconKey = "pdf";
                            break;
                        case ".png":
                        case ".jpg":
                        case ".jpeg":
                            iconKey = "image";
                            break;
                        // İstediğin kadar uzantı ekle
                        default:
                            iconKey = "file"; // bilinmeyen tür için varsayılan
                            break;
                    }

                    var item = new ListViewItem(Path.GetFileName(file), iconKey);
                    item.Tag = file;
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {

            initializeComboBox();

            // İkonları ImageList'e ekle
            imageList1.Images.Add("folder", Properties.Resources.folder);
            imageList1.Images.Add("file", Properties.Resources.file);
            imageList1.Images.Add("class", Properties.Resources._class);
            imageList1.Images.Add("image", Properties.Resources.image);
            imageList1.Images.Add("pdf", Properties.Resources.pdf);
            imageList1.Images.Add("txt", Properties.Resources.txt);
            imageList1.Images.Add("back", Properties.Resources.back);



        }

        private void selectFolder_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    rootPath = fbd.SelectedPath;

                    ShowDirectory(fbd.SelectedPath);
                }
            }
        }



        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            var selectedItem = listView1.SelectedItems[0];
            var selectedPath = selectedItem.Tag?.ToString();

            if (selectedItem.ImageKey == "back" && selectedPath != null)
            {
                ShowDirectory(selectedPath); // Geri git
            }
            else if (Directory.Exists(selectedPath))
            {
                ShowDirectory(selectedPath); // Alt klasöre gir
            }
            else if (File.Exists(selectedPath))
            {
                MessageBox.Show("Bu bir dosyadır");
            }

        }

        private void initializeComboBox()
        {
            var interfaceType = typeof(IPaySystem);

            var types = Assembly.GetExecutingAssembly()
                                .GetTypes()
                                .Where(t => interfaceType.IsAssignableFrom(t) && t.IsClass && !t.IsAbstract);

            foreach (var type in types)
            {
                cb_payType.Items.Add(type); // string değil, doğrudan Type objesi
            }

            cb_payType.DisplayMember = "Name"; // Görünen isim
            cb_payType.SelectedIndex = 0;
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {

            try
            {
                Payer payer = new Payer(payObject);
                lbl_result.Text =payer.Pay(Convert.ToDecimal(txt_price.Text));
            }
            catch (Exception ex)
            {
                lbl_result.Text = "Beklenmedik bir hata meydana geldi";
            }
        }

        private void cb_payType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_payType.SelectedItem is Type selectedType)
            {
                // Dinamik olarak instance oluştur
                payObject = (IPaySystem)Activator.CreateInstance(selectedType);
            }
        }
    }
}
