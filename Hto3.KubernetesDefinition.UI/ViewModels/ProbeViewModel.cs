using Hto3.KubernetesDefinition.UI.Common.Contracts;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.UI.ViewModels
{
    public class ProbeViewModel : MvxViewModel, IClearableViewModel
    {
        public ProbeViewModel()
        {
            this.Commands = new MvxObservableCollection<String>();
            this.CustomHeaders = new MvxObservableCollection<Tuple<String, String>>();
            this.ByCommand = true;
        }

        public String ExecToAdd { get; set; }
        public MvxObservableCollection<String> Commands { get; }
        public Boolean ByCommand { get; set; }
        public Boolean ByHttpRequest { get; set; }
        public Boolean ByTcpSocket { get; set; }
        public String RequestUrl { get; set; }
        public Int32 RequestPort { get; set; }
        public MvxObservableCollection<Tuple<String, String>> CustomHeaders { get; }
        public Int32 TCPSocketPort { get; set; }
        public Int32 InitialDelay { get; set; }
        public Int32 Interval { get; set; }
        public Int32 Timeout { get; set; }
        public Int32 SucessThreshold { get; set; }
        public Int32 FailureThreshold { get; set; }
        public String InstanceHashCode => this.GetHashCode().ToString();

        public MvxCommand AddCommandCommand => new MvxCommand(() =>
        {
            if (String.IsNullOrWhiteSpace(this.ExecToAdd))
                return;
            this.Commands.Add(this.ExecToAdd);
            this.ExecToAdd = String.Empty;
        });

        public MvxCommand<Int32> RemoveCommandCommand => new MvxCommand<Int32>((index) =>
        {
            this.Commands.RemoveAt(index);
        });

        public void Clear()
        {
            this.ExecToAdd = String.Empty;
            this.Commands.Clear();
            this.ByTcpSocket = false;
            this.ByHttpRequest = false;
            this.ByCommand = true;
            this.RequestUrl = String.Empty;
            this.RequestPort = 0;
            this.CustomHeaders.Clear();
            this.TCPSocketPort = 0;
            this.InitialDelay = 0;
            this.Interval = 0;
            this.Timeout = 0;
            this.SucessThreshold = 0;
            this.FailureThreshold = 0;
        }
    }
}
