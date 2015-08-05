﻿namespace Winium.Desktop.Driver.CommandExecutors
{
    #region using

    using Winium.Cruciatus.Extensions;
    using Winium.Desktop.Driver.Extensions;
    using Winium.StoreApps.Common;

    #endregion

    internal class SelectMenuItemExecutor : CommandExecutorBase
    {
        #region Methods

        protected override string DoImpl()
        {
            var dataGridKey = this.ExecutedCommand.Parameters["ID"].ToString();
            var headersPath = this.ExecutedCommand.Parameters["PATH"].ToString();

            var munu = this.Automator.ElementsRegistry.GetRegisteredElement(dataGridKey).ToMenu();

            munu.SelectItem(headersPath);

            return this.JsonResponse();
        }

        #endregion
    }
}