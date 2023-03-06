using System.Collections.Generic;
using static Kassa_Systeem.MainForm;

namespace Kassa_Systeem
{
     
    public partial class MainForm : Form
    {
        public static MainForm instance;
        public MainForm()
        {
            InitializeComponent();
            instance = this;
        }

        public class Customer
        {
            public string naam { get; set; }
            public int age { get; set; }
            public string email { get; set; }

            public Customer(string naam, int age, string email)
            {
                this.naam = naam;
                this.age = age;
                this.email = email;
            }
        }
        public class VIP_Customer : Customer
        {
            public int discount { get; set; }

            public VIP_Customer(string naam, int age, string email, int discount) : base(naam, age, email)
            {
                this.discount = discount;
            }
        }
        public class Product
        {
            public int iD { get; set; }
            public string naam { get; set; }
            public string gewicht { get; set; }
            public decimal prijs { get; set; }

        }
        public class Winkelwagen
        {
            public List<Product> Producten { get; set; }

            public Winkelwagen()
            {
                Producten = new List<Product>();
            }

        }

        private void create_customer_button_Click(object sender, EventArgs e)
        {
            string customer_name = customer_name_box.Text;
            string customer_age = customer_age_box.Text;
            int converted_customer_age = int.Parse(customer_age);
            string customer_email = customer_email_box.Text;
            
            if (!vip_checkBox.Checked)
            {
                Customer klant_1 = new Customer(customer_name, converted_customer_age, customer_email);
            }
            else
            {
                VIP_Customer vip_klant_1 = new VIP_Customer(customer_name, converted_customer_age, customer_email, 15);
            }
            

        }


        private void display_Number_TextChanged(object sender, EventArgs e)
        {

        }
        private void winkelwagen_text_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            display_Number.Text += "1";

        }

        private void button_Number_2_Click(object sender, EventArgs e)
        {
            display_Number.Text += "2";
        }

        private void button_Number_3_Click(object sender, EventArgs e)
        {
            display_Number.Text += "3";
        }

        private void button_Number_4_Click(object sender, EventArgs e)
        {
            display_Number.Text += "4";
        }

        private void button_Number_5_Click(object sender, EventArgs e)
        {
            display_Number.Text += "5";
        }

        private void button_Number_6_Click(object sender, EventArgs e)
        {
            display_Number.Text += "6";
        }

        private void button_Number_7_Click(object sender, EventArgs e)
        {
            display_Number.Text += "7";
        }

        private void button_Number_8_Click(object sender, EventArgs e)
        {
            display_Number.Text += "8";
        }

        private void button_Number_9_Click(object sender, EventArgs e)
        {
            display_Number.Text += "9";
        }

        private void button_Number_0_Click(object sender, EventArgs e)
        {
            display_Number.Text += "0";
        }

        private void id_Enter_Click(object sender, EventArgs e)
        {

            //lezen wat in de textbox staat
            string id_string = display_Number.Text;
            int id_number = int.Parse(id_string);

            //lijst aan maken voor de bestaande product ids
            // de product ids kunnen dus barcodes zijn maar voor de makkelijk heid heb ik geen volledige barcodes gebruikt
            List<int> product_ids = new List<int>();
            product_ids.AddRange(new int[] { 1, 2, 3, 4, 5 });
            var winkelwagen_1 = new Winkelwagen();

            //producten aanmaken
            Product item_1 = new Product();
            item_1.iD = 1;
            item_1.naam = "Peer ";
            item_1.gewicht = "150g \n";
            item_1.prijs = 1.50m;

            Product item_2 = new Product();
            item_2.iD = 2;
            item_2.naam = "Appel ";
            item_2.gewicht = "150g \n";
            item_2.prijs = 1.25m;

            Product item_3 = new Product();
            item_3.iD = 3;
            item_3.naam = "kaas ";
            item_3.gewicht = "500g \n";
            item_3.prijs = 4.00m;

            Product item_4 = new Product();
            item_4.iD = 4;
            item_4.naam = "lasagna ";
            item_4.gewicht = "300g \n";
            item_4.prijs = 6.76m;

            Product item_5 = new Product();
            item_5.iD = 5;
            item_5.naam = "snoep mix ";
            item_5.gewicht = "500g \n";
            item_5.prijs = 8.99m;



            //het id checken
            if (product_ids.Contains(id_number))
            {
                winkelwagen_error_box.Text = "";
                
                
                if (id_number == 1)
                {
                    winkelwagen_text.Text += item_1.naam + item_1.gewicht + item_1.prijs;
                    winkelwagen_1.Producten.Add(item_1);
                }
                if (id_number == 2)
                {
                    winkelwagen_text.Text += item_2.naam + item_2.gewicht + item_2.prijs;
                    winkelwagen_1.Producten.Add(item_2);
                }
                if (id_number == 3)
                {
                    winkelwagen_text.Text += item_3.naam + item_3.gewicht + item_3.prijs;
                    winkelwagen_1.Producten.Add(item_3);
                }
                if (id_number == 4)
                {
                    winkelwagen_text.Text += item_4.naam + item_4.gewicht + item_4.prijs;
                    winkelwagen_1.Producten.Add(item_4);
                }
                if (id_number == 5)
                {
                    winkelwagen_text.Text += item_5.naam + item_5.gewicht + item_5.prijs;
                    winkelwagen_1.Producten.Add(item_5);
                }


            }
            else
            {
                winkelwagen_error_box.Text += "verkeerde input";
            }
            //leegmaken van id invoerveld
            display_Number.Text = "";
        }

        
        private void button_Betalen_Click(object sender, EventArgs e)
        {

        }

        private void uitlog_button_Click(object sender, EventArgs e)
        {
            display_Number.Text += "0";
            this.Close();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }
    }
}