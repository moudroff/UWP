﻿using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSqlite.Models
{
    internal class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull, MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Default(value: 0)]
        public decimal Price { get; set; }
    }
}
