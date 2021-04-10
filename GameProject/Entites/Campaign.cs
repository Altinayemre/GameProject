using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entites
{
    class Campaign:IEntity
    {
        public int Id { get; set; }

        public string DiscountName { get; set; }

        public double DiscountAmount { get; set; }
    }
}
