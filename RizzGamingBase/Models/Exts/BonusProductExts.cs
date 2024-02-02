﻿using RizzGamingBase.Models.Dtos;
using RizzGamingBase.Models.Repositories.EFRepositories;
using RizzGamingBase.Models.Services;
using RizzGamingBase.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RizzGamingBase.Models.Exts
{
    public static class BonusProductExts
    {
        public static List<BonusProductsIndexVm> GetAll()
        {
            var repo = new BonusProductsEFRepository();
            var service = new BonusProductsServices(repo);
            var dto = service.GetAll();
            var data = new List<BonusProductsIndexVm>();
            foreach (var item in dto)
            {
                var model = new BonusProductsIndexVm
                {
                    Id = item.Id,
                    ProductTypeid = item.ProductTypeid,
                    TypeName = item.TypeName,
                    Price = item.Price,
                    URL = item.URL,
                    Name = item.Name
                };
                data.Add(model);
            }
            return data;
        }

        public static void CreateProduct(this BonusProductsCreateVm model)
        {
            var repo = new BonusProductsEFRepository();
            var service = new BonusProductsServices(repo);

            BonusProductsDto dto = new BonusProductsDto
            {
                Id = model.Id,
                ProductTypeid = model.ProductTypeid,
                Price = model.Price,
                URL = model.URL,
                Name = model.Name
            };
            service.Create(dto);
        }


        public static void UpdateProduct(this BonusProductsVm model)
        {
            var repo = new BonusProductsEFRepository();
            var service = new BonusProductsServices(repo);
            BonusProductsDto dto = new BonusProductsDto
            {
                Id = model.Id,
                ProductTypeid = model.ProductTypeid,
                Price = model.Price,
                URL = model.URL,
                Name = model.Name
            };
            service.Update(dto);
        }
    }
}