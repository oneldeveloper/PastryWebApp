using Microsoft.EntityFrameworkCore;
using PastryWebApp.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastryWebApp.Database
{
    public static class PastryDemo
    {
        public static void CreateTortaParadiso(DbContext context)
        {
            Pastry pastry = new Pastry
            {
                Name = "Torta Paradiso",
                ProductionDate = DateTime.Today,
                Quantity = 3,
                Price = 12.5m
            };
            int pastryId = DbUtils.Initialize<Pastry>(context, pastry);
            Ingredient uova = new Ingredient
            {
                PastryId = pastryId,
                Name = "Uova",
                Quantity = 4
            };
            Ingredient zucchero = new Ingredient
            {
                PastryId = pastryId,
                Name = "Zucchero",
                Quantity = 200,
                MeasureUnit = "g"
            };
            Ingredient burro = new Ingredient
            {
                PastryId = pastryId,
                Name = "Burro",
                Quantity = 120,
                MeasureUnit = "g"
            };
            Ingredient farina = new Ingredient
            {
                PastryId = pastryId,
                Name = "Farina",
                Quantity = 180,
                MeasureUnit = "g"
            };
            Ingredient buccia = new Ingredient
            {
                PastryId = pastryId,
                Name = "Buccia di limone grattuggiata",
                Quantity = 1
            };
            Ingredient lievito = new Ingredient
            {
                PastryId = pastryId,
                Name = "Lievito",
                Quantity = 16,
                MeasureUnit = "g"
            };
            Ingredient velo = new Ingredient
            {
                Pastry = pastry,
                Name = "Zucchero a velo"

            };
            DbUtils.Initialize<Ingredient>(context, uova);
            DbUtils.Initialize<Ingredient>(context, zucchero);
            DbUtils.Initialize<Ingredient>(context, farina);
            DbUtils.Initialize<Ingredient>(context, buccia);
            DbUtils.Initialize<Ingredient>(context, lievito);
            DbUtils.Initialize<Ingredient>(context, velo);
        }

        public static void CreateTiramisu(DbContext context)
        {
            Pastry pastry = new Pastry
            {
                Name = "Tiramisù",
                ProductionDate = DateTime.Today - TimeSpan.FromDays(1),
                Quantity = 5,
                Price = 19.9m
            };
            int pastryId = DbUtils.Initialize<Pastry>(context, pastry);
            Ingredient uova = new Ingredient
            {
                PastryId = pastryId,
                Name = "Uova",
                Quantity = 4,
                MeasureUnit = "tuorli"
            };
            Ingredient zucchero = new Ingredient
            {
                PastryId = pastryId,
                Name = "Zucchero",
                Quantity = 100,
                MeasureUnit = "g"
            };
            Ingredient mascarpone = new Ingredient
            {
                PastryId = pastryId,
                Name = "Mascarpone",
                Quantity = 500,
                MeasureUnit = "g"
            };
            Ingredient caffe = new Ingredient
            {
                PastryId = pastryId,
                Name = "Caffè",
                Quantity = 3,
                MeasureUnit = "tazzine"
            };
            Ingredient savoiardi = new Ingredient
            {
                PastryId = pastryId,
                Name = "Savoiardi",
                Quantity = 300,
                MeasureUnit = "g"
            };
            Ingredient cacao = new Ingredient
            {
                PastryId = pastryId,
                Name = "Cacao amaro in polvere",
                MeasureUnit = "qb"
            };

            DbUtils.Initialize<Ingredient>(context, savoiardi);
            DbUtils.Initialize<Ingredient>(context, caffe);
            DbUtils.Initialize<Ingredient>(context, mascarpone);
            DbUtils.Initialize<Ingredient>(context, cacao);
            DbUtils.Initialize<Ingredient>(context, zucchero);
            DbUtils.Initialize<Ingredient>(context, uova);
        }
        public static void CreateCrostata(DbContext context)
        {
            Pastry pastry = new Pastry
            {
                Name = "Crostata alla marmellata",
                ProductionDate = DateTime.Today - TimeSpan.FromDays(2),
                Quantity = 5,
                Price = 14.6m
            };
            int pastryId = DbUtils.Initialize<Pastry>(context, pastry);
            Ingredient uova = new Ingredient
            {
                PastryId = pastryId,
                Name = "Uova",
                Quantity = 1,
                MeasureUnit = "tuorlo"
            };
            Ingredient zucchero = new Ingredient
            {
                PastryId = pastryId,
                Name = "Zucchero",
                Quantity = 125,
                MeasureUnit = "g"
            };
            Ingredient marmellata = new Ingredient
            {
                PastryId = pastryId,
                Name = "Marmellata",
                Quantity = 350,
                MeasureUnit = "g"
            };
            Ingredient burro = new Ingredient
            {
                PastryId = pastryId,
                Name = "Burro",
                Quantity = 100,
                MeasureUnit = "g"
            };
            Ingredient limone = new Ingredient
            {
                PastryId = pastryId,
                Name = "Limone",
                Quantity = 1,
                MeasureUnit = "scorza"
            };
            Ingredient lievito = new Ingredient
            {
                PastryId = pastryId,
                Name = "Lievito per dolci",
                Quantity = 16,
                MeasureUnit = "g"
            };
            Ingredient velo = new Ingredient
            {
                PastryId = pastryId,
                Name = "Zucchero a velo",
                MeasureUnit = "qb"
            };
            Ingredient sale = new Ingredient
            {
                PastryId = pastryId,
                Name = "Sale",
                Quantity = 1,
                MeasureUnit = "pizzico"
            };
            Ingredient farina = new Ingredient
            {
                PastryId = pastryId,
                Name = "Farina",
                Quantity = 480,
                MeasureUnit = "g"
            };

            DbUtils.Initialize<Ingredient>(context, farina);
            DbUtils.Initialize<Ingredient>(context, marmellata);
            DbUtils.Initialize<Ingredient>(context, burro);
            DbUtils.Initialize<Ingredient>(context, zucchero);
            DbUtils.Initialize<Ingredient>(context, uova);
            DbUtils.Initialize<Ingredient>(context, limone);
            DbUtils.Initialize<Ingredient>(context, lievito);
            DbUtils.Initialize<Ingredient>(context, velo);
            DbUtils.Initialize<Ingredient>(context, sale);
        }
        public static void CreateBavarese(DbContext context)
        {
            Pastry pastry = new Pastry
            {
                Name = "Bavarese al limone",
                ProductionDate = DateTime.Today - TimeSpan.FromDays(3),
                Quantity = 5,
                Price = 28m
            };
            int pastryId = DbUtils.Initialize<Pastry>(context, pastry);
            Ingredient uova = new Ingredient
            {
                PastryId = pastryId,
                Name = "Uova",
                Quantity = 4,
                MeasureUnit = "tuorli"
            };
            Ingredient zucchero = new Ingredient
            {
                PastryId = pastryId,
                Name = "Zucchero",
                Quantity = 80,
                MeasureUnit = "g"
            };
            Ingredient latte = new Ingredient
            {
                PastryId = pastryId,
                Name = "Latte intero",
                Quantity = 300,
                MeasureUnit = "ml"
            };
            Ingredient panna = new Ingredient
            {
                PastryId = pastryId,
                Name = "Panna",
                Quantity = 250,
                MeasureUnit = "g"
            };
            Ingredient limone = new Ingredient
            {
                PastryId = pastryId,
                Name = "Limoni",
                Quantity = 2,
                MeasureUnit = "Succo e scorza"
            };
            Ingredient pesce = new Ingredient
            {
                PastryId = pastryId,
                Name = "Colla di pesce",
                MeasureUnit = "qb"
            };
 
            DbUtils.Initialize<Ingredient>(context, latte);
            DbUtils.Initialize<Ingredient>(context, panna);
            DbUtils.Initialize<Ingredient>(context, zucchero);
            DbUtils.Initialize<Ingredient>(context, uova);
            DbUtils.Initialize<Ingredient>(context, limone);
            DbUtils.Initialize<Ingredient>(context, pesce);
        }

    }
}
