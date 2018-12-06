using MVVMDemo.Services;
using MVVMDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMDemo.Helpers
{
    class ViewModelLocator
    {
        private PersonenService service = new PersonenService();
        // 50 services hinterlegen oder einen IoC-Container verwenden (Unity, Autofac, Castle Windsor ...)
        public MainViewModel Main => new MainViewModel(service); // Jedes mal ein neues VM zurückliefern mit einem geteiltem Service
        // 50 ViewModels ...
    }
}
