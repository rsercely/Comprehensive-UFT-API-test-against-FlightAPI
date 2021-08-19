using System;
    using System.Collections.Generic;
    using System.Text;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    
    namespace Script
    {
    
    public class TestEntities
    {
    public ISTRunTimeContext Context = null;
    public Dictionary<string, HP.ST.Fwk.RunTimeFWK.DataHandling.IDataSource> dataSourceNameToDataSource = new Dictionary<string, HP.ST.Fwk.RunTimeFWK.DataHandling.IDataSource>();
    
    protected HP.ST.Fwk.RunTimeFWK.DataHandling.IDataSource GetDataSource(string dataSourceName)
    {
    if(!dataSourceNameToDataSource.ContainsKey(dataSourceName))
    	throw new Exception(("A data source with the specified name does not exist."));
    return dataSourceNameToDataSource[dataSourceName];
    }
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity52 = null;
    public HP.ST.Ext.BasicActivities.StartActivity StartActivity1 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input> Loop2 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity54 = null;
    public HP.ST.Ext.BasicActivities.DataExporterCloseActivity DataExporterCloseActivity55 = null;
    public HP.ST.Ext.BasicActivities.EndActivity EndActivity3 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity53 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence49 = null;
    public HP.ST.Ext.WebServicesActivities.StServiceCallActivity StServiceCallActivity48 = null;
    public HP.ST.Ext.BasicActivities.ReportMessageActivity ReportMessageActivity47 = null;
    public HP.ST.Ext.BasicActivities.DateIncActivity DateIncActivity11 = null;
    public HP.ST.Ext.DatabaseRunTime.DbOpenConnection DbOpenConnection16 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop42Input> Loop42 = null;
    public HP.ST.Ext.WebServicesActivities.StServiceCallActivity StServiceCallActivity25 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop33Input> Loop33 = null;
    public HP.ST.Ext.DatabaseRunTime.DbCloseConnection DbCloseConnection34 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence50 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence51 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData18 = null;
    public HP.ST.Ext.WebServicesActivities.StServiceCallActivity StServiceCallActivity9 = null;
    public HP.ST.Ext.WebServicesActivities.StServiceCallActivity StServiceCallActivity13 = null;
    public HP.ST.Ext.BasicActivities.ConcatenateStringsActivity ConcatenateStringsActivity44 = null;
    public HP.ST.Ext.BasicActivities.ReportMessageActivity ReportMessageActivity43 = null;
    public HP.ST.Ext.WebServicesActivities.StServiceCallActivity StServiceCallActivity32 = null;
    
    }
    
    }
    