namespace Neutrino.Configs
{
    public sealed class Plugins
    {
        public string Directory 
        {
            get; 
            init
            {
                field = string.IsNullOrWhiteSpace(value) ? Constants.Plugins.Directory : value;
            }
        } = Constants.Plugins.Directory;

        public string[] Load { get; init; } = [];
    }
}