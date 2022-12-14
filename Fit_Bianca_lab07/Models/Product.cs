using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Fit_Bianca_lab07.Models
{
        public class Product
        {
            [PrimaryKey, AutoIncrement]
            public int ID { get; set; }
            public string Description { get; set; }
            [OneToMany]
            public List<ListProduct> ListProducts { get; set; }
        }
    }

