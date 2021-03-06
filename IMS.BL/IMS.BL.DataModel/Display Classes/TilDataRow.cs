﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.BL.DataModel
{
    public class TillDataRow
    {
        public string Description { get; private set; }
        public decimal TotalPrice { get; private set; }
        public decimal RRP { get; set; }
        public int Quantity { get; private set; }
        //This wont be displayed to user
        //Its for querying the database
        public Item Item { get; private set; }
        public TillDataRow(Item _Item, int _Quantity)
        {
            Item = _Item;
            Quantity = _Quantity;
            Description = _Item.Description;
            RRP = _Item.RRP;

            //Round to 2dp
            TotalPrice = Math.Round(_Quantity * _Item.RRP, 2); 
        }
    }
}
