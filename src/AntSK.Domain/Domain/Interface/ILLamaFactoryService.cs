﻿using AntSK.LLamaFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AntSK.Domain.Domain.Service.LLamaFactoryService;

namespace AntSK.Domain.Domain.Interface
{
    public interface ILLamaFactoryService
    {
        public event LogMessageHandler LogMessageReceived;
        Task PipInstall();

        Task PipInstallName(string name);
        Task StartLLamaFactory(string modelName);

        void KillProcess();

        List<LLamaModel> GetLLamaFactoryModels();
    }
}
