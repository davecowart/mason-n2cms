[assembly: WebActivator.PreApplicationStartMethod(typeof(Mason.Web.App_Start.ElmahMvc), "Start")]
namespace Mason.Web.App_Start
{
    public class ElmahMvc
    {
        public static void Start()
        {
            Elmah.Mvc.Bootstrap.Initialize();
        }
    }
}