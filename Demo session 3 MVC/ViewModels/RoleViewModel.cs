﻿using System;

namespace Demo_session_3_MVC.ViewModels
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        public string  RoleName { get; set; }

        public RoleViewModel()
        {
            Id = Guid.NewGuid().ToString();
        }

    }
}