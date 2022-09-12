namespace ServerToolsUI.Properties
{


    // This class allows you to handle specific events in the settings class:
    // The Setting Changing event is raised before changing a setting value.
    // The Property Changed event is raised after a configuration value has been changed.
    // The Settings Loaded event is raised after loading configuration values.
    // The Settings Saving event is raised before saving configuration values.
    internal sealed partial class Settings
    {

        public Settings()
        {
            // // To add event handlers for saving and changing settings, uncomment the lines below:
            //
            // this.SettingChanging += this.SettingChangingEventHandler;
            //
            // this.SettingsSaving += this.SettingsSavingEventHandler;
            //
        }

        private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e)
        {
            // Add code to handle the Setting Changing Event here.
        }

        private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Add code to handle the Settings Saving event here.
        }
    }
}
