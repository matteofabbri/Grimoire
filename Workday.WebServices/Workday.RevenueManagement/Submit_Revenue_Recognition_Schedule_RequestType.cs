using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_Revenue_Recognition_Schedule_RequestType : INotifyPropertyChanged
	{
		private Revenue_Recognition_ScheduleObjectType revenue_Recognition_Schedule_ReferenceField;

		private Financials_Business_Process_ParametersType financials_Business_Process_ParametersField;

		private Revenue_Recognition_Schedule_DataType revenue_Recognition_Schedule_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Revenue_Recognition_ScheduleObjectType Revenue_Recognition_Schedule_Reference
		{
			get
			{
				return this.revenue_Recognition_Schedule_ReferenceField;
			}
			set
			{
				this.revenue_Recognition_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Revenue_Recognition_Schedule_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Financials_Business_Process_ParametersType Financials_Business_Process_Parameters
		{
			get
			{
				return this.financials_Business_Process_ParametersField;
			}
			set
			{
				this.financials_Business_Process_ParametersField = value;
				this.RaisePropertyChanged("Financials_Business_Process_Parameters");
			}
		}

		[XmlElement(Order = 2)]
		public Revenue_Recognition_Schedule_DataType Revenue_Recognition_Schedule_Data
		{
			get
			{
				return this.revenue_Recognition_Schedule_DataField;
			}
			set
			{
				this.revenue_Recognition_Schedule_DataField = value;
				this.RaisePropertyChanged("Revenue_Recognition_Schedule_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
