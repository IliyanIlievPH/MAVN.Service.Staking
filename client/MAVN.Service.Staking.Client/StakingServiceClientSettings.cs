using Lykke.SettingsReader.Attributes;

namespace MAVN.Service.Staking.Client 
{
    /// <summary>
    /// Staking client settings.
    /// </summary>
    public class StakingServiceClientSettings 
    {
        /// <summary>Service url.</summary>
        [HttpCheck("api/isalive")]
        public string ServiceUrl {get; set;}
    }
}
