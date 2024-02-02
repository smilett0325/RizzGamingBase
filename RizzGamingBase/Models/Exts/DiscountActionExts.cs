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
    public class DiscountActionExts
    {
        public static List<DiscountIndexVm> GetAllEvent()
        {
            var repo = new DiscountEFRepository();
            var service = new DiscountService(repo);
            var vm = service.GetAllEvent();

            return DiscountExts.GetDtoToVm(vm);
        }

        public static DiscountCreateVm GetEvent(int id)
        {
            var repo = new DiscountEFRepository();
            var service = new DiscountService(repo);
            var vm = service.GetEvent(id);

            return DiscountExts.GetDtoToVm(vm);
        }

        public static void Create(DiscountCreateVm vm)
        {
            var repo = new DiscountEFRepository();
            var service = new DiscountService(repo);
            var dto = DiscountExts.CreateVmToDto(vm);
            service.Create(dto);
        }

        public static void Edit(DiscountCreateVm vm)
        {
            var repo = new DiscountEFRepository();
            var service = new DiscountService(repo);
            var dto = DiscountExts.EditVmToDto(vm);
            service.Edit(dto);
        }
    }
}