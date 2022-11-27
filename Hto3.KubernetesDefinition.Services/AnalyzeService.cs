using Hto3.KubernetesDefinition.Models;
using Hto3.KubernetesDefinition.Models.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.KubernetesDefinition.Services
{
    public class AnalyzeService : IAnalyzeService
    {
        private readonly ISaveService saveService;
        private static Boolean firstTimeRun = true;

        public AnalyzeService(ISaveService saveService)
        {
            this.saveService = saveService;
        }

        public ValidationOutput ValidateBestPractices(IEnumerable<IObjectGraph> graph)
        {
            var tempFilePath = Path.GetTempFileName();
            tempFilePath = Path.ChangeExtension(tempFilePath, "yml");
            saveService.WriteYml(graph, tempFilePath);            

            var startInfo = new ProcessStartInfo();
            startInfo.FileName = MakeValidatorBinAvailable();
            startInfo.Arguments = $"test \"{tempFilePath}\" --output json";
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;

            var errorString = new StringBuilder();
            var outputString = new StringBuilder();

            using (var validatorProcess = Process.Start(startInfo))
            {                
                validatorProcess.ErrorDataReceived += (sender, e) => errorString.AppendLine(e.Data);
                validatorProcess.OutputDataReceived += (sender, e) => outputString.AppendLine(e.Data);
                validatorProcess.BeginErrorReadLine();
                validatorProcess.BeginOutputReadLine();
                validatorProcess.WaitForExit();
            }

            File.Delete(tempFilePath);

            if (errorString.ToString().Trim().Length > 0)
                throw new InvalidOperationException(errorString.ToString());

            var validationOutput = JsonConvert.DeserializeObject<ValidationOutput>(outputString.ToString());
            return validationOutput;
        }

        private String MakeValidatorBinAvailable()
        {
            var tempValidatorBin = Path.Combine(Path.GetTempPath(), "validator.exe");
            if (!firstTimeRun && File.Exists(tempValidatorBin))
                return tempValidatorBin;

            using (var resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Hto3.KubernetesDefinition.Services.Resources.validator.exe"))
            using (var fileStream = new FileStream(tempValidatorBin, FileMode.Create))
            {
                resourceStream.CopyTo(fileStream);
            }
            firstTimeRun = false;

            return tempValidatorBin;
        }
    }
}