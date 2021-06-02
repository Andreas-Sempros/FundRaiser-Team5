﻿using FundRaiser_Team5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundRaiser_Team5.Options
{
    public class OptionUserFundingPackage
    {
        public int OptionUserFundingPackageId { get; set; }
        public int UserId { get; set; }
        public int FundingPackageId { get; set; }
        public DateTime CreateDate { get; set; }
        public int Price { get; set; }
        public UserFundingPackageStatus BackerFundingPackageStatus { get; set; }
        public UserFundingPackageStatus UserFundingPackageStatus { get; internal set; }

        public OptionUserFundingPackage() { }
        public OptionUserFundingPackage(UserFundingPackage userFundingPackage)
        {
            if (userFundingPackage != null)
            {
                OptionUserFundingPackageId = userFundingPackage.UserFundingPackageId;
                UserId = userFundingPackage.User.UserId;
                FundingPackageId = userFundingPackage.FundingPackage.FundingPackageId;
                CreateDate = userFundingPackage.CreateDate;
                Price = userFundingPackage.Price;
                BackerFundingPackageStatus = userFundingPackage.BackerFundingPackageStatus;
            }
        }

        public UserFundingPackage GetUserFundingPackage()
        {
            return new UserFundingPackage
            {

                UserFundingPackageId = OptionUserFundingPackageId,
                CreateDate = DateTime.Now,
                Price = Price,
                BackerFundingPackageStatus = UserFundingPackageStatus.CREATED
            };
        }
    }
}
