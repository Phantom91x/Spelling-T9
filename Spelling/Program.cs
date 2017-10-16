using System;
using System.Linq;
using Autofac;
using Spelling.Bll;
using Spelling.Bll.Abstract;
using Spelling.Bll.Helpers;

namespace Spelling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AutofacInitialize();

                var fileHelper = IoC.Instance.Resolve<IFileHelper>();
                var textConvertHelper = IoC.Instance.Resolve<ITextToNumbersHelper>();

                string filepathin;
                if (args.Any())
                {
                    filepathin = args[0];
                }
                else
                {
                    Console.WriteLine("Enter filepath: ");
                    filepathin = Console.ReadLine();
                }
                var filepathout = filepathin.Replace(".in", ".out");
                var textInput = fileHelper.LoadFileToText(filepathin);
                var textResult = textConvertHelper.TextToNumbers(textInput);
                fileHelper.SaveTextToFile(filepathout, textResult);
                Console.WriteLine($"The result was successfully saved in {filepathout}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error! {e}");
                Console.ReadLine();
            }
        }

        static void AutofacInitialize()
        {
            IoC.Initialize(new Bll_IoCModule());
        }
    }
}