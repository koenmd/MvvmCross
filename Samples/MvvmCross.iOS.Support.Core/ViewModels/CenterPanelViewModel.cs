﻿namespace MvvmCross.iOS.Support.Core.ViewModels
{
    using MvvmCross.Core.ViewModels;

    public class CenterPanelViewModel : BaseViewModel
    {
        public CenterPanelViewModel()
        {
            ExampleValue = "Center Panel";

        }

        public string RightPanelInstructions
        {
            get { return "Drag from the right hand side to show the right hand panel!  To see the SplitView feature, launch the app on an iPad simulator!"; }
        }

        public IMvxCommand ShowMasterCommand
        {
            get
            {
                return new MvxCommand(ShowMasterCommandExecuted);
            }
        }

        public void ShowMenu()
        {
            // Loads the flyout menu on the left
            ShowViewModel<LeftPanelViewModel>();
        }

        private void ShowMasterCommandExecuted()
        {
            ShowViewModel<MasterViewModel>();
        }

        public IMvxCommand ShowKeyboardHandlingCommand
        {
            get
            {
                return new MvxCommand(ShowKeyboardHandlingCommandExecuted);
            }
        }

        private void ShowKeyboardHandlingCommandExecuted()
        {
            ShowViewModel<KeyboardHandlingViewModel>();
        }
    }
}