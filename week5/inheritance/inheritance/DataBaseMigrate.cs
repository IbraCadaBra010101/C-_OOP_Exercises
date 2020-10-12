using System;

namespace Interfaces
{ 
    internal class DataBaseMigrate
    {
        private readonly ILogger _logger;

        public DataBaseMigrate(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);
            _logger.LogInfo("Migration finished at " + DateTime.Now);
        }
    }
}   