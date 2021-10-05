using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace CopyCloneTest_3.ViewModels
{
   public class ItemsViewModel : ReactiveObject
    {
        public string textBoxValue;
        private MainViewModel _mainVM;

        private void OnCopy() => _mainVM.Copy();
        private void OnClone() => _mainVM.Clone();


        #region Commands

        private ReactiveCommand<Unit, Unit> _cloneCommand;
        public ReactiveCommand<Unit, Unit> CloneCommand => _cloneCommand ??= ReactiveCommand.Create<Unit, Unit>((unit) =>
        {
            return Unit.Default;
        });
        private ReactiveCommand<Unit, Unit> _copyCommand;
        public ReactiveCommand<Unit, Unit> CopyCommand => _copyCommand ??= ReactiveCommand.Create<Unit, Unit>((unit) =>
        {
            return Unit.Default;
        });
        #endregion
    }
}
