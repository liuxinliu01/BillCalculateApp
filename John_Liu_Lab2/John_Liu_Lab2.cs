using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CustomerClass;


namespace John_Liu_Lab2
{
    public partial class John_Liu_Lab2 : Form
    {
        //Power Bill Calculate and store customer information to a file.
        //calculate the bill and put information to the listbox and collect number of customers, sum of total bills.

        List<Customer> CustomerList = new List<Customer>();
        List<string> CustomerNameList = new List<string>();
        //create some global variables 
        private double calculateResult;
        private string custType;
        private double valideNumber;
        private bool inputPeakEnable = false;
        private bool inputOffPeakEnable = false;
        private double chargeAmount;
        public John_Liu_Lab2()
        {
            InitializeComponent();
        }

        private void ResidentialRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //When customer type is Residential, hide offPeakHours input.
            UsedHoursInputLabel.Text = "Please enter the hours you used:";
            custType = "R";
            OffPeakHoursLable.Visible = false;
            OffPeakHoursTextBox.Visible = false;
        }

        private void CommercialRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //When customer type is Commercial, hide offPeakHours input.
            UsedHoursInputLabel.Text = "Please enter the hours you used:";
            custType = "C";
            OffPeakHoursLable.Visible = false;
            OffPeakHoursTextBox.Visible = false;
        }
        private void IndustrialRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //when customer type is Industrial, display offPeakHours input.
            if (IndustrialRadioBtn.Checked)
            {
                UsedHoursInputLabel.Text = "Please enter hours in peak time:";
                OffPeakHoursLable.Visible = Visible;
                OffPeakHoursTextBox.Visible = Visible;
                custType = "I";
            }
        }

        public void loadFileForCustomer()
        {
            //Method for loading the customers.txt file.
            try
            {
                string filePath = Application.StartupPath;
                string fileName = filePath + @"//customers.txt";
                //if the file is not exists, show a message.
                if (!(File.Exists(fileName)))
                {
                    MessageBox.Show("File is not exist.");
                    return;
                }
                else
                {
                    // read line by line from customers.txt
                    StreamReader input = new StreamReader(fileName);

                    while (!input.EndOfStream)
                    {
                        Customer cust = null;
                        cust = new Customer(input.ReadLine());
                        cust.ChargeAmount = cust.CalculateCharge();

                        if (cust != null)
                        {
                            //insert new cust values to the List CustomerList 
                            CustomerList.Add(cust);
                            //display the new values in the list box with calculate result.
                            SummeryBox.Items.Add(cust.ToFormattedString());
                            //display the user name if it is not duplex.
                            if (!(CustomerListBox.Items.Contains(cust.CustomerName)))
                            {
                                CustomerNameList.Add(cust.CustomerName);
                                CustomerListBox.Items.Add($"{cust.CustomerName}  {cust.CustomerType}");
                                countCustomerInType();
                            }
                            SumTotalValue.Text = CustomerList.Sum(item => item.ChargeAmount).ToString();
                            CustomerCountValue.Text = CustomerListBox.Items.Count.ToString();
                            
                        }

                    }
                    input.Close();

                }
            }
            catch (Exception excp)
            {
                MessageBox.Show($"File did not load. {excp.Message}");
                return;
            }
            MessageBox.Show($"Products have been loaded from Customers.txt");
        }
   

    
        private void countCustomerInType()
        {
            //count all customer number and numbers for three types of customer.
            int residentialNumber = 0;
            int commercialNumber = 0;
            int industrialNumber = 0;

            residentialNumber = (from n in CustomerList
                                 where n.CustomerType == "R"
                                 select n).Count();
            commercialNumber = (from n in CustomerList
                                where n.CustomerType == "C"
                                select n).Count();
            industrialNumber = (from n in CustomerList
                                where n.CustomerType == "I"
                                select n).Count();
            ResidengtialCountValue.Text = residentialNumber.ToString();
            commercialCountValue.Text = commercialNumber.ToString();
            IndustrialCountValue.Text = industrialNumber.ToString();
        }
        private void LoadFileBtn_Click(object sender, EventArgs e)
        {
            //Load customers list from file customers.txt;
            loadFileForCustomer();
           
        }

        private void SaveFile()
        {
            //save customerList to a file
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Write the file name to save the List";
            sfd.Filter = "Customer List Files|*.clf|Text files|*.txt|All files|*.*";
            sfd.FilterIndex = 2;
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DialogResult result = sfd.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            //all inside a try/catch
            //open a stream writer on 'customers.txt' under bin/debug
            //foreach product in my inventory, run the tofilestring() method 
            //and write that to file
            //close the file
            try
            {
                //append new values into the file customers.txt.
                StreamWriter output = File.AppendText(sfd.FileName);
                foreach (Customer p in CustomerList)
                {
                    output.WriteLine(p.ToFileString());
                }
                output.Close();

            }
            catch (Exception excp)
            {
                MessageBox.Show($"File did not write.{excp.Message}");
            }

            MessageBox.Show($"Customers have been saved in {sfd.FileName}");
        }
        
        private void SaveFileBtn_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
               
        private void John_Liu_Lab1_Load(object sender, EventArgs e)
        {
            ResidentialRadioBtn.Checked = true; //set default customer type is residential.
          
            loadFileForCustomer();  //load data saved in the file customers.txt.
        }

        
        
        public bool ValidateInput(string inputNumber) //Create a method to validate the input hours is positive not negative. 
        {
            if(inputNumber.Length == 0) //first, the input can't be blank
            {
                return false;
            }
            else if (double.TryParse(inputNumber.Trim(), out valideNumber))//then, input need valid positive number
            {
                if (valideNumber > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Please enter effective number. Kwh can not be empty, 0 or negative.", "Input error");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter effective number. Kwh can not be empty, 0 or negative.", "Input error");
                return false;
            }

        }
        private void UsedHoursTextBox_TextChanged(object sender, EventArgs e)
        {
            //disable the calculate button until the customer enter correct kwh.
            if (custType != "I")
            {
                CalculateBtn.Enabled = ValidateInput(UsedHoursTextBox.Text);
            }

            else
            {
                //for industrial customer, both peak hours kwh and off peak hours are required.
                if (ValidateInput(UsedHoursTextBox.Text))//validate input peak hours
                {
                    inputPeakEnable = true;
                }
                else
                {
                    inputPeakEnable = false;
                }
                /*if (ValidateInput(OffPeakHoursTextBox.Text))
                {
                    inputOffPeakEnable = true;
                }
                else
                {
                    inputOffPeakEnable = false;
                }*/
                if (inputPeakEnable && inputOffPeakEnable) //both peak hours and off peak hours required
                {
                    CalculateBtn.Enabled = true;
                }
                else
                {
                    CalculateBtn.Enabled = false;
                }
            }
        }
        private void OffPeakHoursTextBox_TextChanged(object sender, EventArgs e)
        {
            //off peak hours is required too.
            if (ValidateInput(OffPeakHoursTextBox.Text))
            {
                inputOffPeakEnable = true;
            }
            else
            {
                inputOffPeakEnable = false;
            }
            
                if (inputPeakEnable && inputOffPeakEnable) //both peak hours and off peak hours required
            {
                CalculateBtn.Enabled = true;
            }
            else
            {
                CalculateBtn.Enabled = false;
            }
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            //after click the calculate button, create a new Customer.
            Customer cust;
            try
            {
                if (custType == "I")
                {
                    cust = new Customer(int.Parse(AccountNumTextBox.Text.Trim()),
                                        ClientNameTextBox.Text,
                                        custType,
                                        int.Parse(UsedHoursTextBox.Text.Trim()),
                                        int.Parse(OffPeakHoursTextBox.Text.Trim()));
                }
                else
                {
                    cust = new Customer(int.Parse(AccountNumTextBox.Text.Trim()),
                                        ClientNameTextBox.Text,
                                        custType,
                                        int.Parse(UsedHoursTextBox.Text.Trim()));
                }
            //calculate the charge amount.
                calculateResult = cust.CalculateCharge();
                chargeAmount = calculateResult;
                cust.ChargeAmount = chargeAmount;

            }
            catch (ArgumentException excp)
            {
                MessageBox.Show($"Unable to create new record. Invalid information. {excp.Message}");
                return;
            }
            catch (FormatException excp)
            {
                MessageBox.Show($"Non numeric data in a numeric field. Invalid information. {excp.Message}");
                return;
            }
            // add the new customer into the CustomerList.
            CustomerList.Add(cust);
            string str = cust.ToFormattedString();
            //insert values into the listbox.
            SummeryBox.Items.Add(str);
            //display the charge amount
            CalculateResultValue.Text = calculateResult.ToString("C2");
            //disable the button and wait for next input.
            CalculateBtn.Enabled = false;
            if (!(CustomerListBox.Items.Contains(cust.CustomerName + " "+ cust.CustomerType)))
            {
            //add a new customer name and type into the customer Name list if not duplicated.
                CustomerNameList.Add(cust.CustomerName);
                CustomerListBox.Items.Add($"{cust.CustomerName} {cust.CustomerType}");
                countCustomerInType();
            }
            //display the sum of all bill
            SumTotalValue.Text = CustomerList.Sum(item => item.ChargeAmount).ToString();
            //count the number of all customers.
            CustomerCountValue.Text = CustomerListBox.Items.Count.ToString();
        }
        private void ClearBtn_Click(object sender, EventArgs e)//Clear all input area and make all button false.
        {
            //return default empty values
            UsedHoursTextBox.Clear();
            UsedHoursInputLabel.Text = "Please enter the hours you used:";
            OffPeakHoursTextBox.Clear();
            CalculateResultValue.Text = "Result";
            CalculateBtn.Enabled = false;

        }

        private void QuitBtn_Click(object sender, EventArgs e) //Quit 
        {
            SaveFile();
            Close();
            
        }
        
    }
}
