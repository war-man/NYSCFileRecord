﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NYSCFileRecord.Models.ViewModels
{
    public class DashboardViewModels
    {

        public IEnumerable<FileRecord> FileRecord { get; set; }
        public IEnumerable<User> User { get; set; }
        public IEnumerable<User> Top8Users { get; set; }
        public User UserModel { get; set; }
        public FileRecord FileRecordModel { get; set; }
    }
}