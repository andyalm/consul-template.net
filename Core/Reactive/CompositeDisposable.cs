using System;
using System.Collections.Generic;

namespace ConsulRazor.Reactive
{
    internal class CompositeDisposable : IDisposable
    {
        private readonly List<IDisposable> _disposables = new List<IDisposable>();

        public void Add(IDisposable disposable)
        {
            _disposables.Add(disposable);
        }
        
        public void Dispose()
        {
            foreach (var disposable in _disposables)
            {
                disposable.Dispose();
            }
        }
    }
}