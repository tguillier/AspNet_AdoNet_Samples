using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class IndexViewModel
    {
        public string MessagePromotionnel { get; set; }
        public Product ProduitVedette { get; set; }
    }
}