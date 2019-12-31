﻿using System.Collections;
using System.Collections.Generic;

namespace RestClientDotNet.Abstractions
{
    public sealed class RestRequestHeadersCollection : IRestHeadersCollection
    {
        #region Fields
        private readonly Dictionary<string, IEnumerable<string>> _dictionary = new Dictionary<string, IEnumerable<string>>();
        #endregion

        #region Public Properties
        IEnumerable<string> IRestHeadersCollection.this[string name] => _dictionary[name];
        public IEnumerable<string> Names => _dictionary.Keys;
        #endregion

        #region Public Methods
        public void Add(KeyValuePair<string, IEnumerable<string>> keyValuePair)
        {
            _dictionary.Add(keyValuePair.Key, keyValuePair.Value);
        }

        public void Clear()
        {
            _dictionary.Clear();
        }

        public bool Contains(string name)
        {
            return _dictionary.ContainsKey(name);
        }

        public IEnumerator<KeyValuePair<string, IEnumerable<string>>> GetEnumerator()
        {
            return _dictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _dictionary.GetEnumerator();
        }
        #endregion
    }
}