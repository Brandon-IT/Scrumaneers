using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Model
{
    public class TaskModel
    {
        public int Task_Id { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitutde { get; set; }
        public string Task_Info { get; set; }
        public string QR_Code { get; set; }

    }
}
