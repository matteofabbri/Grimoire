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
	public class Submit_Billing_Schedule_RequestType : INotifyPropertyChanged
	{
		private Billing_ScheduleObjectType billing_Schedule_ReferenceField;

		private Financials_Business_Process_ParametersType business_Processing_ParametersField;

		private Billing_Schedule_DataType billing_Schedule_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Billing_ScheduleObjectType Billing_Schedule_Reference
		{
			get
			{
				return this.billing_Schedule_ReferenceField;
			}
			set
			{
				this.billing_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Billing_Schedule_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Financials_Business_Process_ParametersType Business_Processing_Parameters
		{
			get
			{
				return this.business_Processing_ParametersField;
			}
			set
			{
				this.business_Processing_ParametersField = value;
				this.RaisePropertyChanged("Business_Processing_Parameters");
			}
		}

		[XmlElement(Order = 2)]
		public Billing_Schedule_DataType Billing_Schedule_Data
		{
			get
			{
				return this.billing_Schedule_DataField;
			}
			set
			{
				this.billing_Schedule_DataField = value;
				this.RaisePropertyChanged("Billing_Schedule_Data");
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
