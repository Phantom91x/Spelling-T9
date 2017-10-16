using System.IO;
using System.Reflection;
using System.Text;
using Autofac;
using Spelling.Bll;
using Spelling.Bll.Abstract;
using Spelling.Bll.Helpers;
using Xunit;

namespace Spelling.UnitTest
{
    public class UnitTestConvert
    {
        [Fact]
        public void TestConvert()
        {
            IoC.Initialize(new Bll_IoCModule());
            var textInput = GetResource("test.in");
            var textOuput = GetResource("test.out");
            var textConvertHelper = IoC.Instance.Resolve<ITextToNumbersHelper>();
            var result = textConvertHelper.TextToNumbers(textInput);
            Assert.False(result != textOuput, "Conversion is not true");
        }

        private string GetResource(string name)
        {
            var assembly = typeof(UnitTestConvert).GetTypeInfo().Assembly;
            var resourceStream = assembly.GetManifestResourceStream($"Spelling.UnitTest.TestContent.{name}");
            using (var reader = new StreamReader(resourceStream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
    }
}