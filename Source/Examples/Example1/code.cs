/* Generated LinqToWeb context
 * Date: 18.2.2010 17:17:10
 */

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
        public partial class Result : ExtractionObjectBase
        {
            #region Properties
            // string title
            public string title{get{while(_title==null){if (!DoNextAction<object>(null))throw new NotExtractedDataException("title cannot reach any data.");} return _title;}set{_title=value;}}
            private string _title = null;
            
            // string url
            public string url{get{while(_url==null){if (!DoNextAction<object>(null))throw new NotExtractedDataException("url cannot reach any data.");} return _url;}set{_url=value;}}
            private string _url = null;
            
            #endregion
            #region Constructors
            public Result():this(null){}
            public Result(ExtractionObjectBase parent):base(parent)
            {
            }
            #endregion
        }
        #endregion

        #region Private extraction methods
        // urlencode
        private static string urlencode_7_0(string str)
        {
        return System.Web.HttpUtility.UrlEncode(str);
        }
        // htmldecode
        private static string htmldecode_8_0(string str)
        {
        return System.Web.HttpUtility.HtmlDecode(str);
        }
        // 
        private static void _10_0(DataContext _datacontext, LocalVariables _parameters)
        {
            ExtractionListBase<Result> GoogleResults = (ExtractionListBase<Result>)_parameters["GoogleResults"];
            string query = (string)_parameters["query"];
            ScopesStack __l = new ScopesStack(_datacontext, null);
            {
                {
                    __l.Push(__l.context.OpenContextDynamic("open", new object[] {(("http://www.google.com/search?q=")+(urlencode_7_0(query)))}), null);
                    ActionItem.AddAction( new ActionItem.ExtractionMethod[]{googlepage_16_0}, __l.context, new LocalVariables() {
                        {"items", GoogleResults} }.SetCannotAddAction(new Dictionary<string,bool>(){{"items",_parameters.CannotAddActionForVariable("GoogleResults")}}));
                    __l.Pop();
                }

            }
        }

        // googlepage
        private static void googlepage_16_0(DataContext _datacontext, LocalVariables _parameters)
        {
            ExtractionListBase<Result> items = (ExtractionListBase<Result>)_parameters["items"];
            ScopesStack __l = new ScopesStack(_datacontext, null);
            {
                foreach(var __fe18_1 in ForeachMethods.regexp(__l.context, "\\<h3\\sclass=r\\>\\<a\\shref=\\\"(?<rurl>[^\\\"]*)\\\"[^\\>]*\\>(?<rtitle>[^(.)]*)\\</a\\>\\</h3\\>"))
                {
                    __l.Push(null,__fe18_1);
                    {
                        items.AddElement((new Result(){ url = htmldecode_8_0((__l["rurl"].ToString())), title = (__l["rtitle"].ToString()) }));
                    }
                    __l.Pop();
                }

                foreach(var __fe23_1 in ForeachMethods.regexp(__l.context, "\\<a\\shref=\\\"(?<rurl>[^\\\"]*)\\\"[^\\>]*\\>\\<span\\sclass=\\\"csb\\sch\\\"\\sstyle=\\\"background-position:-76px"))
                {
                    __l.Push(null,__fe23_1);
                    {
                        __l.Push(__l.context.OpenContextDynamic("open", new object[] {htmldecode_8_0((__l["rurl"].ToString()))}), null);
                        ActionItem.AddAction( new ActionItem.ExtractionMethod[]{googlepage_16_0}, __l.context, new LocalVariables() {
                            {"items", items} }.SetCannotAddAction(new Dictionary<string,bool>(){{"items",_parameters.CannotAddActionForVariable("items")}}));
                        __l.Pop();
                    }
                    __l.Pop();
                }

            }
        }

        #endregion

        #region Public extracted data
        // Result[] GoogleResults
        public readonly ExtractionList<Result> GoogleResults = new ExtractionList<Result>();
        // string query
        #endregion

        #region Context construct
        private void InitActionsToDo(string query)
        {
            ActionItem.AddAction(_10_0, InitialDataContext, new LocalVariables(){
                {"GoogleResults", GoogleResults},
                {"query", query}});
        }
        #region Constructors
        public WebContext(string query):base(){InitActionsToDo(query);}
        public WebContext(string query, StorageBase cache):base(cache){InitActionsToDo(query);}
        #endregion
        #endregion

    }
}
