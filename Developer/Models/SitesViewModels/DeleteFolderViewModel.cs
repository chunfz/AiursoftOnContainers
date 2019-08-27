﻿using Aiursoft.Developer.Models.AppsViewModels;
using Aiursoft.Pylon.Models.Developer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aiursoft.Developer.Models.SitesViewModels
{
    public class DeleteFolderViewModel : AppLayoutModel
    {
        [Obsolete(message: "This method is only for framework", error: true)]
        public DeleteFolderViewModel() { }
        public DeleteFolderViewModel(DeveloperUser user) : base(user, 2)
        {

        }

        public void Recover(DeveloperUser user)
        {
            RootRecover(user, 5);
        }

        public bool ModelStateValid { get; set; } = true;

        public string AppId { get; set; }

        [Required]
        [MaxLength(50)]
        public string SiteName { get; set; }

        [Required]
        public string FolderPath { get; set; }
    }
}