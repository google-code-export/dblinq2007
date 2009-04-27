#region MIT license
// 
// MIT license
//
// Copyright (c) 2009 Novell, Inc.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// 
#endregion

using System;
using System.Data;
using System.Data.Common;
// using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.IO;

using DbLinq.Data.Linq;

using NUnit.Framework;

using DbLinq.Null;

namespace DbLinqTest {

    class DummyConnection : IDbConnection
    {
        public IDbTransaction BeginTransaction() {return null;}
        public IDbTransaction BeginTransaction(IsolationLevel il) {return null;}
        public void ChangeDatabase(string databaseName) {}
        public void Close() {}
        public IDbCommand CreateCommand() {return null;}
        public string ConnectionString{get; set;}
        public int ConnectionTimeout{get {return 0;}}
        public string Database{get {return null;}}
        public void Dispose() {}
        public void Open() {}
        public ConnectionState State{get {return ConnectionState.Closed;}}
    }

    public abstract class DataContextTest
    {
        DataContext context;

        [SetUp]
        public void SetUp()
        {
            context = new DataContext(new NullConnection());
        }

        [TearDown]
        public void TearDown()
        {
            context = null;
        }

        [Test, ExpectedException(typeof(ArgumentNullException))]
        public void Ctor_ConnectionStringNull()
        {
            string connectionString = null;
            new DataContext(connectionString);
        }

        [Test, ExpectedException(typeof(NullReferenceException))]
        public void Ctor_ConnectionNull()
        {
            IDbConnection connection = null;
            new DataContext(connection);
        }

        [Test]
        public void Connection()
        {
            IDbConnection connection = new NullConnection();
            DataContext dc = new DataContext(connection);
            Assert.AreEqual(connection, dc.Connection);

            dc = new DataContext (new DummyConnection());
            Assert.AreEqual(null, dc.Connection);
        }

        [Test]
        public void ExecuteQuery_ElementTypeNull()
        {
            // TODO: Should this really not generate an exception?
            Type elementType = null;
            context.ExecuteQuery(elementType, "command");
        }

        [Test, ExpectedException(typeof(ArgumentNullException))]
        public void ExecuteQuery_QueryNull()
        {
            Type elementType = typeof(Person);
            context.ExecuteQuery(elementType, null);
        }

        [Test /*, ExpectedException(typeof(ArgumentNullException))*/]
        public void ExecuteQueryTResult_QueryNull()
        {
            // TODO: should this really not generate an exception?
            context.ExecuteQuery<Person>(null);
        }

        [Test, ExpectedException(typeof(NullReferenceException))]
        public void GetCommand_QueryNull()
        {
            IQueryable query = null;
            context.GetCommand(query);
        }
    }
}
