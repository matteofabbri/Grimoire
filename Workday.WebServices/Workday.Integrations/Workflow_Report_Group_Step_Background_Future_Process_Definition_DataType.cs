using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Workflow_Report_Group_Step_Background_Future_Process_Definition_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType report_Group_ReferenceField;

		private Report_Parameter_Initialization_DataType[] report_Parameter_Initialization_DataField;

		private bool do_Not_Output_Empty_ReportField;

		private bool do_Not_Output_Empty_ReportFieldSpecified;

		private decimal file_Expiration_in_DaysField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Report_Group_Reference
		{
			get
			{
				return this.report_Group_ReferenceField;
			}
			set
			{
				this.report_Group_ReferenceField = value;
				this.RaisePropertyChanged("Report_Group_Reference");
			}
		}

		[XmlElement("Report_Parameter_Initialization_Data", Order = 1)]
		public Report_Parameter_Initialization_DataType[] Report_Parameter_Initialization_Data
		{
			get
			{
				return this.report_Parameter_Initialization_DataField;
			}
			set
			{
				this.report_Parameter_Initialization_DataField = value;
				this.RaisePropertyChanged("Report_Parameter_Initialization_Data");
			}
		}

		[XmlElement(Order = 2)]
		public bool Do_Not_Output_Empty_Report
		{
			get
			{
				return this.do_Not_Output_Empty_ReportField;
			}
			set
			{
				this.do_Not_Output_Empty_ReportField = value;
				this.RaisePropertyChanged("Do_Not_Output_Empty_Report");
			}
		}

		[XmlIgnore]
		public bool Do_Not_Output_Empty_ReportSpecified
		{
			get
			{
				return this.do_Not_Output_Empty_ReportFieldSpecified;
			}
			set
			{
				this.do_Not_Output_Empty_ReportFieldSpecified = value;
				this.RaisePropertyChanged("Do_Not_Output_Empty_ReportSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal File_Expiration_in_Days
		{
			get
			{
				return this.file_Expiration_in_DaysField;
			}
			set
			{
				this.file_Expiration_in_DaysField = value;
				this.RaisePropertyChanged("File_Expiration_in_Days");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
