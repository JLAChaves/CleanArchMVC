﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Application.Products.Commands
{
    public class ProductUpdateCommand : ProductComand
    {
        public int Id { get; set; }
    }
}
