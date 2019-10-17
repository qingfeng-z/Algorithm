#region license
// <copyright company="ZAN LLC" file="Program.cs">
//   Copyright (c)2019 ZAN ALL RIGHTS RESERVED.
// </copyright>
#endregion
namespace 队列
{
    using AutoMapper;
    #region region

    using System;

    using Utils;

    #endregion

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        private IMapper Mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="Program"/> class. 
        /// </summary>
        public Program()
        {
            // 配置 DbModel 与 Entity 映射
            var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<User,UserDto>();
                    cfg.CreateMap<Account, AccountDto>();
                });
            this.Mapper = config.CreateMapper();
        }

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            //this.gets();
        }

        private  void gets()
        {
            var user = new User
                           {
                               name = "san",
                               age = "1",
                               Account = new Account { name = "mima", password = "password" }
                           };
            var userDto = this.Mapper.Map<User, UserDto>(user);
            var e = 1;
        }
    }

    /// <summary>
    /// The account.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string name { get; set; }
    }

    /// <summary>
    /// The account dto.
    /// </summary>
    public class AccountDto
    {
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string name { get; set; }
    }

    /// <summary>
    /// The user.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        public string age { get; set; }

        /// <summary>
        /// Gets or sets the account.
        /// </summary>
        public Account Account { get; set; }

    }

    /// <summary>
    /// The user dto.
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        public string age { get; set; }

        /// <summary>
        /// Gets or sets the account.
        /// </summary>
        public AccountDto Account { get; set; }
    }
}
