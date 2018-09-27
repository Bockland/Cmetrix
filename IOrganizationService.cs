public static void ServicioCRM_2011()
{
    string CredencialUsuario = System.Configuration.ConfigurationManager.AppSettings["CredencialUsuario"];
    string CredencialContrasena = System.Configuration.ConfigurationManager.AppSettings["CredencialContrasena"];
    string CredencialDominio = System.Configuration.ConfigurationManager.AppSettings["CredencialDominio"];
    string CRMOrganizationName = System.Configuration.ConfigurationManager.AppSettings["CRMOrganizationName"];
    string CRMServidor = System.Configuration.ConfigurationManager.AppSettings["CRMServidor"];


    System.Net.NetworkCredential credenciales = new System.Net.NetworkCredential(CredencialUsuario, CredencialContrasena, CredencialDominio);
    ClientCredentials Credentials = new ClientCredentials();
    Credentials.Windows.ClientCredential = credenciales;
    Uri OrganizationUri = new Uri("http://" + CRMServidor + "/" + CRMOrganizationName + "/XRMServices/2011/Organization.svc");


    Uri HomeRealmUri;
    HomeRealmUri = null;

    OrganizationServiceProxy _serviceProxy;
    _serviceProxy = new OrganizationServiceProxy(OrganizationUri, HomeRealmUri, Credentials, null);

    _serviceProxy.ServiceConfiguration.CurrentServiceEndpoint.Behaviors.Add(new ProxyTypesBehavior());
    _ServicioCRM = ((IOrganizationService)_serviceProxy);

    
}