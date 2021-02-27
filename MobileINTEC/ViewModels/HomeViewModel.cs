using System;
using System.Collections.Generic;
using System.Text;
using MobileINTEC.Models;

namespace MobileINTEC.ViewModels
{
    public class HomeViewModel
    {
        public MenuOption BarAndHotelsMenuOption { get; set; } = new MenuOption();
        public MenuOption FineAndDinningMenuOption { get; set; } = new MenuOption();
        public MenuOption CafesMenuOption { get; set; } = new MenuOption();
        public MenuOption NearbyMenuOption { get; set; } = new MenuOption();
        public MenuOption FastFoodsMenuOption { get; set; } = new MenuOption();
        public MenuOption FeaturedFoodsMenuOption { get; set; } = new MenuOption();


        public HomeViewModel()
        {
            BarAndHotelsMenuOption.Title = "BAR & HOTELS";
            FineAndDinningMenuOption.Title = "FINE & DINNING";
            CafesMenuOption.Title = "CAFES";
            NearbyMenuOption.Title = "NEARBY";
            FastFoodsMenuOption.Title = "FAST FOODS";
            FeaturedFoodsMenuOption.Title = "FEATURED FOODS";


            FineAndDinningMenuOption.Image = "restaurant36";
            BarAndHotelsMenuOption.Image = "hotel36";
            CafesMenuOption.Image = "cafe36";
            NearbyMenuOption.Image = "nearby356";
            FastFoodsMenuOption.Image = "fastfood36";
            FeaturedFoodsMenuOption.Image = "featured36";
        }

    }
}
