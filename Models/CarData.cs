using System;
using System.ComponentModel.DataAnnotations;

namespace Test_DataTables.Models {
    public class CarData {

        public string Name { get; set; }

        [Required]
        public short? Year { get; set; }

    }
}