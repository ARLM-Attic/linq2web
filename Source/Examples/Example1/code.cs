using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using linqtoweb.Core.datacontext;
using linqtoweb.Core.extraction;
using linqtoweb.Core.methods;
using linqtoweb.Core.storage;

namespace Example1
{
    public partial class WebContext : ExtractionContext
    {
        #region Public classes declaration
        public partial class XXX : ExtractionObjectBase
        {
            #region Properties
            private string _str = null;
            public string str{get{while(_str==null){if (!DoNextAction<object>(null))throw new NotExtractedDataException("str cannot reach any data.");} return _str;}set{_str=value;}}
            
            private int? _number = null;
            public int? number{get{while(_number==null){if (!DoNextAction<object>(null))throw new NotExtractedDataException("number cannot reach any data.");} return _number;}set{_number=value;}}
            
            private DateTime _lastseen = DateTime.MinValue;
            public DateTime lastseen{get{while(_lastseen==DateTime.MinValue){if (!DoNextAction<object>(null))throw new NotExtractedDataException("lastseen cannot reach any data.");} return _lastseen;}set{_lastseen=value;}}
            
            public readonly ExtractionList<XXX> xxxs;
            
            #endregion
            #region Constructors
            public XXX():this(null){}
            public XXX(ExtractionObjectBase parent):base(parent)
            {
                xxxs = new ExtractionList<XXX>(this as ExtractionObjectBase);
            }
            #endregion
        }
        #endregion

        #region Private extraction methods
        private static void _9_0(DataContext _datacontext, LocalVariables _parameters)
        {
            ExtractionListBase<XXX> sampleList = (ExtractionListBase<XXX>)_parameters["sampleList"];
            XXX el = (XXX)_parameters["el"];
            ScopesStack __l = new ScopesStack(_datacontext, null);
            {
                {
                    __l.Push(__l.context.OpenContextDynamic("open", new object[] {"http://www.freesutra.cz/"}), null);
                    foreach (var __fe12_1 in ForeachMethods.regexp(__l.context, "Porno\\s+(?<x>\\w+)"))
                    {
                        __l.Push(null,__fe12_1);
                        {
                            ActionItem.AddAction( new ActionItem.ExtractionMethod[]{addel_19_0}, __l.context, new LocalVariables() {
                                {"l", sampleList},
                                {"val", (__l["x"].ToString())} }.SetCannotAddAction(new Dictionary<string,bool>(){{"l",_parameters.CannotAddActionForVariable("sampleList")},{"val",_parameters.CannotAddActionForVariable("x")}}));
                            el.str = (__l["x"].ToString());
                        }
                        __l.Pop();
                    }

                    __l.Pop();
                }

            }
        }

        private static void addel_19_0(DataContext _datacontext, LocalVariables _parameters)
        {
            ExtractionListBase<XXX> l = (ExtractionListBase<XXX>)_parameters["l"];
            string val = (string)_parameters["val"];
            ScopesStack __l = new ScopesStack(_datacontext, null);
            {
                l.AddElement((new XXX(){ str = val }));
            }
        }

        #endregion

        #region Public extracted data
        public readonly ExtractionList<XXX> sampleList = new ExtractionList<XXX>();
        public readonly XXX el = new XXX();
        #endregion

        #region Data initialization
        protected override void InitActionsToDo()
        {
            base.InitActionsToDo();
            ActionItem.AddAction(_9_0, InitialDataContext, new LocalVariables(new Dictionary<string, object>() {
                {"sampleList", sampleList}
                ,                 {"el", el}
                }));
        }
        #endregion

        #region Constructors
        public WebContext():base(){}
        public WebContext(StorageBase cache):base(cache){}
        #endregion
    }
}
