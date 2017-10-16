using Autofac;
using Spelling.Bll.Abstract;
using Spelling.Bll.Helpers;

namespace Spelling.Bll
{
    public class Bll_IoCModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<FileHelper>().As<IFileHelper>().SingleInstance();
            builder.RegisterType<TextToNumbersHelper>().As<ITextToNumbersHelper>().SingleInstance();
        }
    }
}