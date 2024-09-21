using System;
using System.Collections.Generic;

namespace WinFormsApp2.Model
{
    public partial class Table
    {
        public int Id { get; set; }
        public int TableNumber { get; set; }
        public string TableState { get; set; } = null!;
    }
}
