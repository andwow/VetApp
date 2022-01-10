using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetApp.Models;

namespace VetApp.ViewModels
{
    class AllSalesVM : INotifyPropertyChanged
    {
        public AllSalesVM()
        {
            Sales = new ObservableCollection<Sale>();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT Items.items_id, Intervention.intv_date, Items.prod_name, items.items_type, Items.items_quantity, Items.items_price FROM Items, Intervention WHERE Items.Intervention_id = Intervention.intv_id ORDER BY Intervention.intv_date DESC; ", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //Connection open here   
            con.Open();
            cmd.ExecuteNonQuery();
            startDate = DateTime.MaxValue;
            endDate = DateTime.MinValue;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    Sale sale = new Sale
                    {
                        Date = (DateTime)dt.Rows[i]["intv_date"],
                        Id = (int)dt.Rows[i]["items_id"],
                        Name = (string)dt.Rows[i]["prod_name"],
                        Type = (int)dt.Rows[i]["items_type"],
                        Quantity = (double)dt.Rows[i]["items_quantity"],
                        Price = (double)dt.Rows[i]["items_price"]
                    };
                    if(sale.Date < startDate)
                    {
                        StartDate = sale.Date;
                        StartDateStr = sale.Date.ToString(@"dd.MM.yyyy");
                    }
                    if(sale.Date > endDate)
                    {
                        EndDate = sale.Date;
                        EndDateStr = sale.Date.ToString(@"dd.MM.yyyy");
                    }
                    Sales.Add(sale);
                    TotalPrice += sale.Price * sale.Quantity;
                }
            }
            con.Close();
        }

        public void Search(DateTime startDate, DateTime endDate)
        {
            Sales.Clear();
            TotalPrice = 0;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-I78MCPL;Initial Catalog=VetApp;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT Items.items_id, Intervention.intv_date, Items.prod_name, items.items_type, Items.items_quantity, Items.items_price FROM Items, Intervention WHERE Items.Intervention_id = Intervention.intv_id AND Intervention.intv_date >= @StartDate AND Intervention.intv_date <= @EndDate ORDER BY Intervention.intv_date DESC; ", con);
            cmd.Parameters.AddWithValue("@StartDate", startDate);
            cmd.Parameters.AddWithValue("@EndDate", endDate);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //Connection open here   
            con.Open();
            cmd.ExecuteNonQuery();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    Sale sale = new Sale
                    {
                        Date = (DateTime)dt.Rows[i]["intv_date"],
                        Id = (int)dt.Rows[i]["items_id"],
                        Name = (string)dt.Rows[i]["prod_name"],
                        Type = (int)dt.Rows[i]["items_type"],
                        Quantity = (double)dt.Rows[i]["items_quantity"],
                        Price = (double)dt.Rows[i]["items_price"]
                    };
                    Sales.Add(sale);
                    TotalPrice += sale.Price * sale.Quantity;
                }
            }
            con.Close();
        }

        public ObservableCollection<Sale> Sales { get; }

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set 
            {
                startDate = value;
                NotifyPropertyChanged(nameof(StartDate));
            }
            
        }
        public string StartDateStr
        {
            get
            {
                return startDate.Date.ToString(@"dd.MM.yyyy");
            }
            set
            {
                startDate = DateTime.ParseExact(value, @"dd.MM.yyyy", provider);
                NotifyPropertyChanged(nameof(StartDate));
                NotifyPropertyChanged(nameof(StartDateStr));
            }
        }
        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
                NotifyPropertyChanged(nameof(EndDate));
            }
        }
        public string EndDateStr
        {
            get
            {
                return endDate.Date.ToString(@"dd.MM.yyyy");
            }
            set
            {
                endDate = DateTime.ParseExact(value, @"dd.MM.yyyy", provider);
                NotifyPropertyChanged(nameof(EndDate));
                NotifyPropertyChanged(nameof(EndDateStr));
            }
        }
        public double TotalPrice 
        {
            get
            {
                return totalPrice;
            }
            set
            {
                totalPrice = value;
                NotifyPropertyChanged(nameof(TotalPrice));
            }
        }
        public string TotalPriceStr 
        { 
            get 
            {
                return totalPrice.ToString(); 
            }
            set
            {
                totalPrice = double.Parse(value);
                NotifyPropertyChanged(nameof(TotalPrice));
                NotifyPropertyChanged(nameof(TotalPriceStr));
            }
        }

        double totalPrice;
        DateTime startDate;
        DateTime endDate;

        CultureInfo provider = CultureInfo.InvariantCulture;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
