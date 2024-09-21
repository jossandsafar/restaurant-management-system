using System;
using System.Collections.Generic;

namespace WinFormsApp2.Model
{
    public partial class MealType
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public string OrderType { get; set; } = null!;
    }
}
